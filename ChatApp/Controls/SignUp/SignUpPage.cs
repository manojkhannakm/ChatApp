using ChatApp.Controls.SignIn;
using ChatApp.Utilities;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChatApp.Controls.SignUp
{
    public partial class SignUpPage : Page
    {
        private Image pictureImage = ChatApp.Properties.Resources.picture;
        private Rectangle pictureOriginalRectangle, pictureRectangle, pictureInitialRectangle;
        private PictureEditMode pictureEditMode = PictureEditMode.NONE;
        private Point mouseInitialLocation;

        public SignUpPage()
        {
            InitializeComponent();

            pictureFramePictureBox.Location = new Point(0, 0);
            picturePictureBox.Controls.Add(pictureFramePictureBox);

            pictureOriginalRectangle = new Rectangle(0, 0, picturePictureBox.Width, picturePictureBox.Height);
            pictureRectangle = pictureOriginalRectangle;
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {
            ParentForm.CancelButton = cancelButton;

            ActiveControl = nameTextBox;
        }

        private void picturePictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(1, 1, picturePictureBox.Width - 2, picturePictureBox.Height - 2);
            graphics.SetClip(graphicsPath);

            graphics.DrawImage(pictureImage, pictureRectangle);
        }

        private void picturePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (new Rectangle(0, 0, 15, 15).Contains(e.Location))
            {
                pictureEditMode = PictureEditMode.RESIZE_NW;
            }
            else if (new Rectangle(45, 0, 15, 15).Contains(e.Location))
            {
                pictureEditMode = PictureEditMode.RESIZE_NE;
            }
            else if (new Rectangle(45, 45, 15, 15).Contains(e.Location))
            {
                pictureEditMode = PictureEditMode.RESIZE_SE;
            }
            else if (new Rectangle(0, 45, 15, 15).Contains(e.Location))
            {
                pictureEditMode = PictureEditMode.RESIZE_SW;
            }
            else
            {
                pictureEditMode = PictureEditMode.MOVE;
            }

            mouseInitialLocation = e.Location;
            pictureInitialRectangle = pictureRectangle;
        }

        private void picturePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            switch (pictureEditMode)
            {

                case PictureEditMode.NONE:
                    if (new Rectangle(0, 0, 15, 15).Contains(e.Location)
                        || new Rectangle(45, 45, 15, 15).Contains(e.Location))
                    {
                        picturePictureBox.Cursor = Cursors.SizeNWSE;
                    }
                    else if (new Rectangle(45, 0, 15, 15).Contains(e.Location)
                        || new Rectangle(0, 45, 15, 15).Contains(e.Location))
                    {
                        picturePictureBox.Cursor = Cursors.SizeNESW;
                    }
                    else
                    {
                        picturePictureBox.Cursor = Cursors.SizeAll;
                    }
                    break;

                case PictureEditMode.MOVE:
                    {
                        int x = pictureInitialRectangle.X + e.X - mouseInitialLocation.X,
                            y = pictureInitialRectangle.Y + e.Y - mouseInitialLocation.Y;
                        if (x > 0)
                        {
                            x = 0;
                        }
                        else if (x + pictureRectangle.Width < picturePictureBox.Width)
                        {
                            x = picturePictureBox.Width - pictureRectangle.Width;
                        }

                        if (y > 0)
                        {
                            y = 0;
                        }
                        else if (y + pictureRectangle.Height < picturePictureBox.Height)
                        {
                            y = picturePictureBox.Height - pictureRectangle.Height;
                        }

                        pictureRectangle.X = x;
                        pictureRectangle.Y = y;

                        picturePictureBox.Invalidate();
                        break;
                    }

                case PictureEditMode.RESIZE_NW:
                    {
                        float xRatio = (float)(pictureInitialRectangle.Width + mouseInitialLocation.X - e.X) / pictureOriginalRectangle.Width,
                            yRatio = (float)(pictureInitialRectangle.Height + mouseInitialLocation.Y - e.Y) / pictureOriginalRectangle.Height,
                            ratio = Math.Max(xRatio, yRatio);
                        if (ratio < 1.0f)
                        {
                            ratio = 1.0f;
                        }

                        int width = (int)(pictureOriginalRectangle.Width * ratio),
                            height = (int)(pictureOriginalRectangle.Height * ratio),
                            x = pictureInitialRectangle.X - (width - pictureInitialRectangle.Width),
                            y = pictureInitialRectangle.Y - (height - pictureInitialRectangle.Height);
                        if (x > 0 || y > 0)
                        {
                            break;
                        }

                        pictureRectangle.X = x;
                        pictureRectangle.Y = y;
                        pictureRectangle.Width = width;
                        pictureRectangle.Height = height;

                        picturePictureBox.Invalidate();
                        break;
                    }

                case PictureEditMode.RESIZE_NE:
                    {
                        float xRatio = (float)(pictureInitialRectangle.Width + e.X - mouseInitialLocation.X) / pictureOriginalRectangle.Width,
                            yRatio = (float)(pictureInitialRectangle.Height + mouseInitialLocation.Y - e.Y) / pictureOriginalRectangle.Height,
                            ratio = Math.Max(xRatio, yRatio);
                        if (ratio < 1.0f)
                        {
                            ratio = 1.0f;
                        }

                        int width = (int)(pictureOriginalRectangle.Width * ratio),
                            height = (int)(pictureOriginalRectangle.Height * ratio),
                            y = pictureInitialRectangle.Y - (height - pictureInitialRectangle.Height);
                        if (pictureInitialRectangle.X + width < picturePictureBox.Width || y > 0)
                        {
                            break;
                        }

                        pictureRectangle.Y = y;
                        pictureRectangle.Width = width;
                        pictureRectangle.Height = height;

                        picturePictureBox.Invalidate();
                        break;
                    }

                case PictureEditMode.RESIZE_SE:
                    {
                        float xRatio = (float)(pictureInitialRectangle.Width + e.X - mouseInitialLocation.X) / pictureOriginalRectangle.Width,
                            yRatio = (float)(pictureInitialRectangle.Height + e.Y - mouseInitialLocation.Y) / pictureOriginalRectangle.Height,
                            ratio = Math.Max(xRatio, yRatio);
                        if (ratio < 1.0f)
                        {
                            ratio = 1.0f;
                        }

                        int width = (int)(pictureOriginalRectangle.Width * ratio),
                            height = (int)(pictureOriginalRectangle.Height * ratio);
                        if (pictureInitialRectangle.X + width < picturePictureBox.Width
                            || pictureInitialRectangle.Y + height < picturePictureBox.Height)
                        {
                            break;
                        }

                        pictureRectangle.Width = width;
                        pictureRectangle.Height = height;

                        picturePictureBox.Invalidate();
                        break;
                    }

                case PictureEditMode.RESIZE_SW:
                    {
                        float xRatio = (float)(pictureInitialRectangle.Width + mouseInitialLocation.X - e.X) / pictureOriginalRectangle.Width,
                            yRatio = (float)(pictureInitialRectangle.Height + e.Y - mouseInitialLocation.Y) / pictureOriginalRectangle.Height,
                            ratio = Math.Max(xRatio, yRatio);
                        if (ratio < 1.0f)
                        {
                            ratio = 1.0f;
                        }

                        int width = (int)(pictureOriginalRectangle.Width * ratio),
                            height = (int)(pictureOriginalRectangle.Height * ratio),
                            x = pictureInitialRectangle.X - (width - pictureInitialRectangle.Width);
                        if (x > 0 || pictureInitialRectangle.Y + height < picturePictureBox.Height)
                        {
                            break;
                        }

                        pictureRectangle.X = x;
                        pictureRectangle.Width = width;
                        pictureRectangle.Height = height;

                        picturePictureBox.Invalidate();
                        break;
                    }

            }
        }

        private void picturePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            pictureEditMode = PictureEditMode.NONE;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.bmp;*.jpg;*.png";
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Image image = Image.FromFile(dialog.FileName);
            if (image.Width < picturePictureBox.Width || image.Height < picturePictureBox.Height)
            {
                MessageBox.Show("Picture size should be atleast " + picturePictureBox.Width + " x " + picturePictureBox.Height + "!",
                    ChatAppForm.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pictureImage.Dispose();
            pictureImage = image;

            float xRatio = (float)picturePictureBox.Width / pictureImage.Width,
                yRatio = (float)picturePictureBox.Height / pictureImage.Height,
                ratio = Math.Max(xRatio, yRatio);
            pictureOriginalRectangle = new Rectangle(0, 0, (int)(pictureImage.Width * ratio), (int)(pictureImage.Height * ratio));
            pictureRectangle = pictureOriginalRectangle;

            picturePictureBox.Invalidate();
        }

        private bool Validate(TextBox textBox, bool[] conditions, string[] errorTexts)
        {
            for (int i = 0; i < conditions.Length; i++)
            {
                if (conditions[i])
                {
                    textBox.BackColor = Color.LightCoral;
                    errorToolTip.SetToolTip(textBox, errorTexts[i]);

                    signUpButton.Enabled = false;
                    return false;
                }
            }

            textBox.BackColor = Color.LightGreen;
            errorToolTip.SetToolTip(textBox, null);

            if (nameTextBox.BackColor != Color.LightCoral
                && emailTextBox.BackColor != Color.LightCoral
                && passwordTextBox.BackColor != Color.LightCoral
                && confirmPasswordTextBox.BackColor != Color.LightCoral)
            {
                signUpButton.Enabled = true;
            }

            return true;
        }

        private bool Validate(TextBox textBox, bool condition, string errorText)
        {
            return Validate(textBox, new bool[] { condition }, new string[] { errorText });
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            name = Regex.Replace(name, "[a-zA-Z]+", delegate(Match match)
            {
                string value = match.Value;
                return char.ToUpper(value[0]) + value.Substring(1);
            });
            if (!name.Equals(nameTextBox.Text))
            {
                nameTextBox.Text = name;
                nameTextBox.Select(name.Length, 0);
                return;
            }

            Validate(nameTextBox,
                new bool[]
                { 
                    name.Length < 5,
                    name.StartsWith(" ") || name.EndsWith(" "),
                    name.Contains("  "),
                    !Regex.IsMatch(name, "^[a-zA-Z]+( +[a-zA-Z]+)*$")
                },
                new string[]
                {
                    "Name should have at least 5 characters!",
                    "Name should start and end only with alphabets!",
                    "Name should not have consecutive spaces!",
                    "Name should only have alphabets and spaces!"
                });
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            Validate(emailTextBox, !Regex.IsMatch(emailTextBox.Text, "^.+@.+\\..+$"), "Email should be valid!");
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmPasswordTextBox.Text = null;
            confirmPasswordTextBox.BackColor = SystemColors.Window;
            errorToolTip.SetToolTip(confirmPasswordTextBox, null);

            string password = passwordTextBox.Text;
            if (Validate(passwordTextBox, password.Length < 6, "Password should have at least 6 characters!"))
            {
                switch (Convert.ToInt32(Regex.IsMatch(password, "[a-zA-Z]+"))
                    + Convert.ToInt32(Regex.IsMatch(password, "[0-9]+"))
                    + Convert.ToInt32(Regex.IsMatch(password, "[^a-zA-Z0-9]+")))
                {

                    case 1:
                        passwordTextBox.BackColor = Color.Khaki;
                        break;

                    case 2:
                        passwordTextBox.BackColor = Color.LightBlue;
                        break;

                    case 3:
                        passwordTextBox.BackColor = Color.LightGreen;
                        break;

                }
            }
        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            string confirmPassword = confirmPasswordTextBox.Text;
            Validate(confirmPasswordTextBox,
                new bool[] {
                    confirmPassword.Length < 6,
                    !confirmPassword.Equals(passwordTextBox.Text)
                },
                new string[] {
                    "Confirm password should have at least 6 characters!",
                    "Confirm password should match password!"
                });
        }

        private void StopLoading()
        {
            loadingPictureBox.Visible = false;
            loadingPictureBox.Stop();
            signUpButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void OnException(SqlException e)
        {
            StopLoading();
        }

        private void SwitchToSignIn()
        {
            ParentForm.CancelButton = null;

            pictureImage.Dispose();
            pictureImage = ChatApp.Properties.Resources.picture;

            pictureRectangle.X = pictureRectangle.Y = 0;
            pictureRectangle.Width = pictureImage.Width;
            pictureRectangle.Height = pictureImage.Height;

            SwitchTo(new SignInPage(), SWITCH_RIGHT);
        }

        private async void signUpButton_Click(object sender, EventArgs e)
        {
            signUpButton.Visible = false;
            cancelButton.Visible = false;
            loadingPictureBox.Start();
            loadingPictureBox.Visible = true;

            string email = emailTextBox.Text;
            using (SqlDataReader dataReader = await SqlUtility.Read("SELECT [email] FROM [users] WHERE [email] = @email;",
                new string[] { email }, OnException))
            {
                if (dataReader == null)
                {
                    return;
                }

                if (!Validate(emailTextBox, await dataReader.ReadAsync(), "Email should not be linked to another account!"))
                {
                    StopLoading();
                    return;
                }
            }

            string name = nameTextBox.Text,
                    verificationCode = new Random().Next(0x100000, 0xffffff + 1).ToString("X").ToLower();
            if (!await SmtpUtility.Send(email, "Welcome",
                "Hello " + name + ",\n\n"
                + "Welcome to Chat App! Please verify your account using the following verification code.\n\n"
                + "Verification code: #" + verificationCode, delegate(SmtpException ex)
                {
                    StopLoading();
                }))
            {
                return;
            }

            loadingPictureBox.Pause();

            EmailVerificationForm verificationForm = new EmailVerificationForm(verificationCode);
            verificationForm.ShowDialog();
            verificationForm.Dispose();
            if (verificationForm.DialogResult != DialogResult.OK)
            {
                StopLoading();
                SwitchToSignIn();
                return;
            }

            loadingPictureBox.Resume();

            if (await SqlUtility.Write("INSERT INTO [users] ([email], [name], [password]) VALUES (@email, @name, @password);",
                new string[] { email, name, passwordTextBox.Text }, OnException) != 1)
            {
                return;
            }

            StopLoading();
            MessageBox.Show("Sign up successful!", ChatAppForm.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            SwitchToSignIn();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            SwitchToSignIn();
        }

        private enum PictureEditMode
        {
            NONE, MOVE, RESIZE_NW, RESIZE_NE, RESIZE_SE, RESIZE_SW
        }
    }
}
