namespace ChatApp.Controls.SignUp
{
    partial class EmailVerificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailVerificationForm));
            this.infoLabel = new System.Windows.Forms.Label();
            this.verificationCodeLabel = new System.Windows.Forms.Label();
            this.verificationCodeTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.verifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.Location = new System.Drawing.Point(12, 12);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(267, 13);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Please check your email inbox for the verification code.";
            // 
            // verificationCodeLabel
            // 
            this.verificationCodeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.verificationCodeLabel.AutoSize = true;
            this.verificationCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.verificationCodeLabel.Location = new System.Drawing.Point(12, 39);
            this.verificationCodeLabel.Name = "verificationCodeLabel";
            this.verificationCodeLabel.Size = new System.Drawing.Size(86, 13);
            this.verificationCodeLabel.TabIndex = 0;
            this.verificationCodeLabel.Text = "Verification code";
            // 
            // verificationCodeTextBox
            // 
            this.verificationCodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.verificationCodeTextBox.Location = new System.Drawing.Point(104, 36);
            this.verificationCodeTextBox.MaxLength = 6;
            this.verificationCodeTextBox.Name = "verificationCodeTextBox";
            this.verificationCodeTextBox.Size = new System.Drawing.Size(175, 20);
            this.verificationCodeTextBox.TabIndex = 1;
            this.verificationCodeTextBox.TextChanged += new System.EventHandler(this.verificationCodeTextBox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(160, 70);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // verifyButton
            // 
            this.verifyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.verifyButton.BackColor = System.Drawing.Color.Transparent;
            this.verifyButton.Enabled = false;
            this.verifyButton.Location = new System.Drawing.Point(55, 70);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(75, 23);
            this.verifyButton.TabIndex = 2;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = false;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // EmailVerificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(291, 105);
            this.Controls.Add(this.verificationCodeTextBox);
            this.Controls.Add(this.verificationCodeLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.verifyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(307, 141);
            this.Name = "EmailVerificationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Email Verification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label verificationCodeLabel;
        private System.Windows.Forms.TextBox verificationCodeTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button verifyButton;
    }
}