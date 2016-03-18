namespace ChatApp.Controls
{
    partial class ChatAppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatAppForm));
            this.splashPage = new ChatApp.Controls.SplashPage();
            this.SuspendLayout();
            // 
            // splashPage
            // 
            this.splashPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splashPage.BackColor = System.Drawing.Color.Transparent;
            this.splashPage.Location = new System.Drawing.Point(0, 0);
            this.splashPage.Name = "splashPage";
            this.splashPage.Size = new System.Drawing.Size(400, 350);
            this.splashPage.TabIndex = 0;
            // 
            // ChatAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.splashPage);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(416, 389);
            this.Name = "ChatAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat App";
            this.Load += new System.EventHandler(this.ChatAppForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SplashPage splashPage;

    }
}
