namespace MyFacebookApp
{
    partial class frmLogin
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
            this.WebFacebook = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WebFacebook
            // 
            this.WebFacebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebFacebook.Location = new System.Drawing.Point(0, 0);
            this.WebFacebook.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebFacebook.Name = "WebFacebook";
            this.WebFacebook.ScriptErrorsSuppressed = true;
            this.WebFacebook.Size = new System.Drawing.Size(861, 519);
            this.WebFacebook.TabIndex = 0;
            this.WebFacebook.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebFacebook_DocumentCompleted);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 519);
            this.Controls.Add(this.WebFacebook);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebFacebook;
    }
}