namespace ChatApp.Controls.SignUp
{
    partial class SignUpPage
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
            pictureImage.Dispose();
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
            this.components = new System.ComponentModel.Container();
            this.cancelButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.signUpGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureFramePictureBox = new System.Windows.Forms.PictureBox();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordlabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureLabel = new System.Windows.Forms.Label();
            this.loadingPictureBox = new ChatApp.Controls.LoadingPictureBox();
            this.errorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.signUpGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFramePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.Location = new System.Drawing.Point(215, 315);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpButton.BackColor = System.Drawing.Color.Transparent;
            this.signUpButton.Enabled = false;
            this.signUpButton.Location = new System.Drawing.Point(110, 315);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpButton.TabIndex = 6;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // signUpGroupBox
            // 
            this.signUpGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.signUpGroupBox.Controls.Add(this.pictureFramePictureBox);
            this.signUpGroupBox.Controls.Add(this.picturePictureBox);
            this.signUpGroupBox.Controls.Add(this.confirmPasswordTextBox);
            this.signUpGroupBox.Controls.Add(this.confirmPasswordlabel);
            this.signUpGroupBox.Controls.Add(this.passwordTextBox);
            this.signUpGroupBox.Controls.Add(this.passwordLabel);
            this.signUpGroupBox.Controls.Add(this.emailTextBox);
            this.signUpGroupBox.Controls.Add(this.emailLabel);
            this.signUpGroupBox.Controls.Add(this.nameTextBox);
            this.signUpGroupBox.Controls.Add(this.selectButton);
            this.signUpGroupBox.Controls.Add(this.nameLabel);
            this.signUpGroupBox.Controls.Add(this.pictureLabel);
            this.signUpGroupBox.Location = new System.Drawing.Point(12, 12);
            this.signUpGroupBox.Name = "signUpGroupBox";
            this.signUpGroupBox.Size = new System.Drawing.Size(376, 291);
            this.signUpGroupBox.TabIndex = 0;
            this.signUpGroupBox.TabStop = false;
            this.signUpGroupBox.Text = "Sign up";
            // 
            // pictureFramePictureBox
            // 
            this.pictureFramePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureFramePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureFramePictureBox.Enabled = false;
            this.pictureFramePictureBox.Image = global::ChatApp.Properties.Resources.picture_frame;
            this.pictureFramePictureBox.Location = new System.Drawing.Point(205, 19);
            this.pictureFramePictureBox.Name = "pictureFramePictureBox";
            this.pictureFramePictureBox.Size = new System.Drawing.Size(60, 60);
            this.pictureFramePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureFramePictureBox.TabIndex = 0;
            this.pictureFramePictureBox.TabStop = false;
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picturePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.picturePictureBox.Location = new System.Drawing.Point(205, 19);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(60, 60);
            this.picturePictureBox.TabIndex = 0;
            this.picturePictureBox.TabStop = false;
            this.picturePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.picturePictureBox_Paint);
            this.picturePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturePictureBox_MouseDown);
            this.picturePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturePictureBox_MouseMove);
            this.picturePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturePictureBox_MouseUp);
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(110, 225);
            this.confirmPasswordTextBox.MaxLength = 50;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(251, 20);
            this.confirmPasswordTextBox.TabIndex = 5;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            this.confirmPasswordTextBox.TextChanged += new System.EventHandler(this.confirmPasswordTextBox_TextChanged);
            // 
            // confirmPasswordlabel
            // 
            this.confirmPasswordlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPasswordlabel.AutoSize = true;
            this.confirmPasswordlabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordlabel.Location = new System.Drawing.Point(14, 228);
            this.confirmPasswordlabel.Name = "confirmPasswordlabel";
            this.confirmPasswordlabel.Size = new System.Drawing.Size(90, 13);
            this.confirmPasswordlabel.TabIndex = 0;
            this.confirmPasswordlabel.Text = "Confirm password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Location = new System.Drawing.Point(110, 191);
            this.passwordTextBox.MaxLength = 50;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(251, 20);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Location = new System.Drawing.Point(14, 194);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.Location = new System.Drawing.Point(110, 157);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(251, 20);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Location = new System.Drawing.Point(14, 160);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Location = new System.Drawing.Point(110, 123);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(251, 20);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // selectButton
            // 
            this.selectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectButton.BackColor = System.Drawing.Color.Transparent;
            this.selectButton.Location = new System.Drawing.Point(198, 86);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Location = new System.Drawing.Point(14, 126);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // pictureLabel
            // 
            this.pictureLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureLabel.AutoSize = true;
            this.pictureLabel.BackColor = System.Drawing.Color.Transparent;
            this.pictureLabel.Location = new System.Drawing.Point(14, 43);
            this.pictureLabel.Name = "pictureLabel";
            this.pictureLabel.Size = new System.Drawing.Size(40, 13);
            this.pictureLabel.TabIndex = 0;
            this.pictureLabel.Text = "Picture";
            // 
            // loadingPictureBox
            // 
            this.loadingPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.loadingPictureBox.Image = global::ChatApp.Properties.Resources.loading_1;
            this.loadingPictureBox.Location = new System.Drawing.Point(155, 321);
            this.loadingPictureBox.Name = "loadingPictureBox";
            this.loadingPictureBox.Size = new System.Drawing.Size(90, 10);
            this.loadingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loadingPictureBox.TabIndex = 0;
            this.loadingPictureBox.TabStop = false;
            this.loadingPictureBox.Visible = false;
            // 
            // errorToolTip
            // 
            this.errorToolTip.AutomaticDelay = 1;
            this.errorToolTip.AutoPopDelay = 999999999;
            this.errorToolTip.InitialDelay = 1;
            this.errorToolTip.ReshowDelay = 1;
            // 
            // SignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.signUpGroupBox);
            this.Controls.Add(this.loadingPictureBox);
            this.Name = "SignUpPage";
            this.Size = new System.Drawing.Size(400, 350);
            this.Load += new System.EventHandler(this.SignUpPage_Load);
            this.signUpGroupBox.ResumeLayout(false);
            this.signUpGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFramePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox signUpGroupBox;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label pictureLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label confirmPasswordlabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private System.Windows.Forms.PictureBox pictureFramePictureBox;
        private LoadingPictureBox loadingPictureBox;
        private System.Windows.Forms.ToolTip errorToolTip;
    }
}
