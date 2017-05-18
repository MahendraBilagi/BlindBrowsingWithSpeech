using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFacebookApp
{
    public partial class frmMain : Form
    {
        public static String[] ListFriend = new String[1000];
        public static int NotificationCount;
        public frmMain()
        {
            InitializeComponent();
        }
        public static bool IsLogin = false;
        public static bool IsBackFromLogin = false;
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        public void voiceLogin()
        {
            if (IsLogin != true)
            {
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
            }
            else
            {
                //lblAccountName.Text = FBClass.GetUserName(AppSettings.Default.AccessToken);
                String imgURL = String.Format("http://graph.facebook.com/{0}/picture", FBClass.GetUserID(AppSettings.Default.AccessToken));
                imgAccount.ImageLocation = imgURL;

            }
        }

         private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsLogin != true)
            {
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
            }
            else
            {
                lblAccountName.Text = FBClass.GetUserName(AppSettings.Default.AccessToken);
                String imgURL = String.Format("http://graph.facebook.com/{0}/picture",FBClass.GetUserID(AppSettings.Default.AccessToken));
                imgAccount.ImageLocation = imgURL;

            }

        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (IsBackFromLogin == true)
            {
                btnLogin_Click(null,null);
                IsBackFromLogin = false;
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if(FBClass.Post(AppSettings.Default.AccessToken,txtStatus.Text)==true)
            {
                MessageBox.Show("Posted to your wall");
            }
        }

        public void voiceBtnPost_Click(string message)
        {
            if (FBClass.Post(AppSettings.Default.AccessToken, message) == true)
            {
                MessageBox.Show("Posted to your wall");
            }
        }

       /* public void getFriendList()
        {
            int i = 0;
            ListFriend = FBClass.voiceGetFrndList(AppSettings.Default.AccessToken);
            while (ListFriend[i] != "###")
            {
                //String elem = ListFriend[i];
                //viewFriendList.Items.Add(new ListViewItem(elem,i));
                
                i++;
            }
            MessageBox.Show(i.ToString());
        }*/

        

        private void btnGetFrndList_Click(object sender, EventArgs e)
        {
            ListFriend = FBClass.voiceGetFrndList(AppSettings.Default.AccessToken);

            viewFriendList.Items.Clear();
            foreach (String elem in ListFriend)
            {
                viewFriendList.Items.Add(new ListViewItem(elem));
            }

        }


    }
}
