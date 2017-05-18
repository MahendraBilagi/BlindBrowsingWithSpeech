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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void WebFacebook_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string access_token;
            if (WebFacebook.Url.AbsoluteUri.Contains("access_token"))
            {
                string url1 = WebFacebook.Url.AbsoluteUri;
                string url2 = url1.Substring(url1.IndexOf("access_token") + 13);
                access_token = url2.Substring(0,url2.IndexOf("&"));
                AppSettings.Default.AccessToken = access_token;

                frmMain.IsLogin = true;
                frmMain.IsBackFromLogin = true;

                
                this.Close();
                
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            String OAuthURL = @"https://www.facebook.com/dialog/oauth?client id=611254142288368&redirect_uri=https://www.facebook.com/connect/login_success.html&response_type=token&scope=user_status,read_friendlists,publish_stream";
            WebFacebook.Navigate(OAuthURL);
        }
    }
}
