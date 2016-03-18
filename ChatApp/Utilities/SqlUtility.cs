using ChatApp.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp.Utilities
{
    class SqlUtility
    {
        //private const string CONNECTION_STRING = "workstation id=chat-app.mssql.somee.com;packet size=4096;user id=manojkhannakm_SQLLogin_1;pwd=tc846igrib;data source=chat-app.mssql.somee.com;persist security info=False;initial catalog=chat-app";
        private const string CONNECTION_STRING = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=E:\\Manoj\\Projects\\ChatApp\\ChatApp\\database.mdf;Integrated Security=True;Connect Timeout=30";

        public delegate void OnException(SqlException e);

        public static async Task<SqlDataReader> Read(string commandString, string[] parameterStrings, OnException onException)
        {
            MatchCollection matches = Regex.Matches(commandString, "@[a-z]+");
            if (matches.Count != parameterStrings.Length)
            {
                throw new Exception("Invalid no. of parameters!");
            }

            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            try
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand(commandString, connection))
                {
                    for (int i = 0; i < matches.Count; i++)
                    {
                        command.Parameters.AddWithValue(matches[i].Value, parameterStrings[i]);
                    }

                    return await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);

                connection.Close();

                if (onException != null)
                {
                    onException(e);
                }

                if (e.Class >= 17)
                {
                    MessageBox.Show("Connection unavailable!", ChatAppForm.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return null;
        }

        public static async Task<int> Write(string commandString, string[] parameterStrings, OnException onException)
        {
            MatchCollection matches = Regex.Matches(commandString, "@[a-z]+");
            if (matches.Count != parameterStrings.Length)
            {
                throw new Exception("Invalid no. of parameters!");
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(commandString, connection))
                    {
                        for (int i = 0; i < matches.Count; i++)
                        {
                            command.Parameters.AddWithValue(matches[i].Value, parameterStrings[i]);
                        }

                        return await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);

                if (onException != null)
                {
                    onException(e);
                }

                if (e.Class >= 17)
                {
                    MessageBox.Show("Connection unavailable!", ChatAppForm.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return -1;
        }
    }
}
