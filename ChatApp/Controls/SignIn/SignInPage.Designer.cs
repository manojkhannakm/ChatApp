namespace ChatApp.Controls.SignIn
{
    partial class SignInPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titlePictureBox = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.newUserGroupBox = new System.Windows.Forms.GroupBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.signInGroupBox = new System.Windows.Forms.GroupBox();
            this.keepMeSignedInCheckBox = new System.Windows.Forms.CheckBox();
            this.forgotPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.signInButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.loadingPictureBox = new ChatApp.Controls.LoadingPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.newUserGroupBox.SuspendLayout();
            this.signInGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePictureBox
            // 
            this.titlePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titlePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.titlePictureBox.Image = global::ChatApp.Properties.Resources.title;
            this.titlePictureBox.Location = new System.Drawing.Point(97, 84);
            this.titlePictureBox.Name = "titlePictureBox";
            this.titlePictureBox.Size = new System.Drawing.Size(206, 36);
            this.titlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.titlePictureBox.TabIndex = 0;
            this.titlePictureBox.TabStop = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = global::ChatApp.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(170, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(60, 60);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // newUserGroupBox
            // 
            this.newUserGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newUserGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.newUserGroupBox.Controls.Add(this.signUpButton);
            this.newUserGroupBox.Location = new System.Drawing.Point(12, 283);
            this.newUserGroupBox.Name = "newUserGroupBox";
            this.newUserGroupBox.Size = new System.Drawing.Size(376, 54);
            this.newUserGroupBox.TabIndex = 0;
            this.newUserGroupBox.TabStop = false;
            this.newUserGroupBox.Text = "New user?";
            // 
            // signUpButton
            // 
            this.signUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpButton.BackColor = System.Drawing.Color.Transparent;
            this.signUpButton.Location = new System.Drawing.Point(151, 19);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpButton.TabIndex = 6;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // signInGroupBox
            // 
            this.signInGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signInGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.signInGroupBox.Controls.Add(this.keepMeSignedInCheckBox);
            this.signInGroupBox.Controls.Add(this.forgotPasswordLinkLabel);
            this.signInGroupBox.Controls.Add(this.signInButton);
            this.signInGroupBox.Controls.Add(this.passwordTextBox);
            this.signInGroupBox.Controls.Add(this.emailTextBox);
            this.signInGroupBox.Controls.Add(this.passwordLabel);
            this.signInGroupBox.Controls.Add(this.emailLabel);
            this.signInGroupBox.Controls.Add(this.loadingPictureBox);
            this.signInGroupBox.Location = new System.Drawing.Point(12, 132);
            this.signInGroupBox.Name = "signInGroupBox";
            this.signInGroupBox.Size = new System.Drawing.Size(376, 139);
            this.signInGroupBox.TabIndex = 0;
            this.signInGroupBox.TabStop = false;
            this.signInGroupBox.Text = "Sign in";
            // 
            // keepMeSignedInCheckBox
            // 
            this.keepMeSignedInCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.keepMeSignedInCheckBox.AutoSize = true;
            this.keepMeSignedInCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.keepMeSignedInCheckBox.Location = new System.Drawing.Point(60, 80);
            this.keepMeSignedInCheckBox.Name = "keepMeSignedInCheckBox";
            this.keepMeSignedInCheckBox.Size = new System.Drawing.Size(113, 17);
            this.keepMeSignedInCheckBox.TabIndex = 3;
            this.keepMeSignedInCheckBox.Text = "Keep me signed in";
            this.keepMeSignedInCheckBox.UseVisualStyleBackColor = false;
            // 
            // forgotPasswordLinkLabel
            // 
            this.forgotPasswordLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forgotPasswordLinkLabel.AutoSize = true;
            this.forgotPasswordLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.forgotPasswordLinkLabel.Location = new System.Drawing.Point(229, 81);
            this.forgotPasswordLinkLabel.Name = "forgotPasswordLinkLabel";
            this.forgotPasswordLinkLabel.Size = new System.Drawing.Size(91, 13);
            this.forgotPasswordLinkLabel.TabIndex = 4;
            this.forgotPasswordLinkLabel.TabStop = true;
            this.forgotPasswordLinkLabel.Text = "Forgot password?";
            this.forgotPasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLinkLabel_LinkClicked);
            // 
            // signInButton
            // 
            this.signInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signInButton.BackColor = System.Drawing.Color.Transparent;
            this.signInButton.Enabled = false;
            this.signInButton.Location = new System.Drawing.Point(151, 104);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(75, 23);
            this.signInButton.TabIndex = 5;
            this.signInButton.Text = "Sign in";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Location = new System.Drawing.Point(116, 53);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(204, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.emailTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.emailTextBox.Location = new System.Drawing.Point(116, 19);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(204, 20);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.emailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailTextBox_KeyDown);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Location = new System.Drawing.Point(57, 56);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Location = new System.Drawing.Point(57, 22);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            // 
            // loadingPictureBox
            // 
            this.loadingPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.loadingPictureBox.Image = global::ChatApp.Properties.Resources.loading_1;
            this.loadingPictureBox.Location = new System.Drawing.Point(143, 110);
            this.loadingPictureBox.Name = "loadingPictureBox";
            this.loadingPictureBox.Size = new System.Drawing.Size(90, 10);
            this.loadingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loadingPictureBox.TabIndex = 0;
            this.loadingPictureBox.TabStop = false;
            this.loadingPictureBox.Visible = false;
            // 
            // SignInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.titlePictureBox);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.newUserGroupBox);
            this.Controls.Add(this.signInGroupBox);
            this.Name = "SignInPage";
            this.Size = new System.Drawing.Size(400, 350);
            this.Load += new System.EventHandler(this.SignInPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.newUserGroupBox.ResumeLayout(false);
            this.signInGroupBox.ResumeLayout(false);
            this.signInGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox titlePictureBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.GroupBox newUserGroupBox;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.GroupBox signInGroupBox;
        private System.Windows.Forms.LinkLabel forgotPasswordLinkLabel;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private LoadingPictureBox loadingPictureBox;
        private System.Windows.Forms.CheckBox keepMeSignedInCheckBox;

    }
}
