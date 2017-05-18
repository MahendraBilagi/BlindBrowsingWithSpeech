namespace MyFacebookApp
{
    partial class frmMain
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.imgAccount = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetFrndList = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.groupFriendsList = new System.Windows.Forms.GroupBox();
            this.viewFriendList = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAccount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupFriendsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.lblAccountName);
            this.groupBox1.Controls.Add(this.imgAccount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Info";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(261, 23);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(71, 33);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(77, 13);
            this.lblAccountName.TabIndex = 1;
            this.lblAccountName.Text = "Please Login...";
            // 
            // imgAccount
            // 
            this.imgAccount.Location = new System.Drawing.Point(7, 19);
            this.imgAccount.Name = "imgAccount";
            this.imgAccount.Size = new System.Drawing.Size(58, 54);
            this.imgAccount.TabIndex = 0;
            this.imgAccount.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetFrndList);
            this.groupBox2.Controls.Add(this.btnPost);
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // btnGetFrndList
            // 
            this.btnGetFrndList.Location = new System.Drawing.Point(7, 132);
            this.btnGetFrndList.Name = "btnGetFrndList";
            this.btnGetFrndList.Size = new System.Drawing.Size(102, 23);
            this.btnGetFrndList.TabIndex = 2;
            this.btnGetFrndList.Text = "Get Friends List";
            this.btnGetFrndList.UseVisualStyleBackColor = true;
            this.btnGetFrndList.Click += new System.EventHandler(this.btnGetFrndList_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(261, 132);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 1;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(6, 19);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(329, 98);
            this.txtStatus.TabIndex = 0;
            // 
            // groupFriendsList
            // 
            this.groupFriendsList.Controls.Add(this.viewFriendList);
            this.groupFriendsList.Location = new System.Drawing.Point(360, 12);
            this.groupFriendsList.Name = "groupFriendsList";
            this.groupFriendsList.Size = new System.Drawing.Size(171, 280);
            this.groupFriendsList.TabIndex = 2;
            this.groupFriendsList.TabStop = false;
            this.groupFriendsList.Text = "Friends List";
            // 
            // viewFriendList
            // 
            this.viewFriendList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.viewFriendList.Location = new System.Drawing.Point(6, 23);
            this.viewFriendList.Name = "viewFriendList";
            this.viewFriendList.Size = new System.Drawing.Size(159, 242);
            this.viewFriendList.TabIndex = 0;
            this.viewFriendList.UseCompatibleStateImageBehavior = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 360);
            this.Controls.Add(this.groupFriendsList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Facebook Application";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAccount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupFriendsList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.PictureBox imgAccount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.GroupBox groupFriendsList;
        private System.Windows.Forms.ListView viewFriendList;
        private System.Windows.Forms.Button btnGetFrndList;
    }
}

