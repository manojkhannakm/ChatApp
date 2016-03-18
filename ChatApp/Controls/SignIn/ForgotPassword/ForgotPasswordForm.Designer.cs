namespace ChatApp.Controls.SignIn.ForgotPassword
{
    partial class ForgotPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.emailPage = new ChatApp.Controls.SignIn.ForgotPassword.EmailPage();
            this.SuspendLayout();
            // 
            // emailPage
            // 
            this.emailPage.BackColor = System.Drawing.Color.Transparent;
            this.emailPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailPage.Location = new System.Drawing.Point(0, 0);
            this.emailPage.MinimumSize = new System.Drawing.Size(262, 81);
            this.emailPage.Name = "emailPage";
            this.emailPage.Size = new System.Drawing.Size(291, 115);
            this.emailPage.TabIndex = 0;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(291, 115);
            this.Controls.Add(this.emailPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(307, 154);
            this.Name = "ForgotPasswordForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Forgot Password";
            this.ResumeLayout(false);

        }

        #endregion

        private EmailPage emailPage;


    }
}