namespace ChatApp.Controls.SignIn.ForgotPassword
{
    partial class ResetCodePage
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.verifyButton = new System.Windows.Forms.Button();
            this.resetCodeTextBox = new System.Windows.Forms.TextBox();
            this.resetCodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.Location = new System.Drawing.Point(12, 12);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(239, 13);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Please check your email inbox for the reset code.";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.Location = new System.Drawing.Point(160, 70);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
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
            // resetCodeTextBox
            // 
            this.resetCodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetCodeTextBox.Location = new System.Drawing.Point(80, 36);
            this.resetCodeTextBox.Name = "resetCodeTextBox";
            this.resetCodeTextBox.Size = new System.Drawing.Size(199, 20);
            this.resetCodeTextBox.TabIndex = 1;
            this.resetCodeTextBox.TextChanged += new System.EventHandler(this.resetCodeTextBox_TextChanged);
            // 
            // resetCodeLabel
            // 
            this.resetCodeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetCodeLabel.AutoSize = true;
            this.resetCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.resetCodeLabel.Location = new System.Drawing.Point(12, 39);
            this.resetCodeLabel.Name = "resetCodeLabel";
            this.resetCodeLabel.Size = new System.Drawing.Size(62, 13);
            this.resetCodeLabel.TabIndex = 0;
            this.resetCodeLabel.Text = "Reset code";
            // 
            // ResetCodePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.verifyButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.resetCodeTextBox);
            this.Controls.Add(this.resetCodeLabel);
            this.Name = "ResetCodePage";
            this.Size = new System.Drawing.Size(291, 105);
            this.Load += new System.EventHandler(this.ResetCodePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resetCodeLabel;
        private System.Windows.Forms.TextBox resetCodeTextBox;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label infoLabel;
    }
}
