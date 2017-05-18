using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using System.Windows.Forms;

namespace MyFacebookApp
{
    class FBClass
    {
        public static String[] ListFriend = new String[1000];
        public static String[] ListNotification = new String[10];
        public static String title;
        public static int NotifyCount = 0;
        public static string GetUserID(string AccessToken)
        {
            FacebookClient fb = new FacebookClient(AccessToken);
            dynamic MyData = fb.Get("/me");
            return MyData.id;
        }

        public static string GetUserName(string AccessToken)
        {
            FacebookClient fb = new FacebookClient(AccessToken);
            dynamic MyData = fb.Get("/me");
            return MyData.name;
        }
        public static string[] voiceGetFrndList(string AccessToken)
        {
            int i;
            FacebookClient fb = new FacebookClient(AccessToken);
            dynamic FriendList = fb.Get("/me/friends");
            int frndcount = (int)FriendList.data.Count;
            for (i = 0; i < frndcount; i++)
            {
                ListFriend[i] = FriendList.data[i].name;
            }
            ListFriend[i + 1] = "###";
            return ListFriend;
        }

        public static String GetNotifications(string AccessToken)
        {
            FacebookClient fb = new FacebookClient(AccessToken);
            dynamic Notifications = fb.Get("/me/notifications");
            int NotificationCount = (int)Notifications.data.Count;
            try
            {
                for (int i = 0; i < NotificationCount; i++)
                {
                    //ListNotification[i+1] = Notifications.data[i].title;
                    if (i > 0)
                    {
                        title = title + ",          ,,,,,,,,,,,,,,,,,  ,,    ,   ,  , ,    ,   ,  ,";
                    }
                    title = title + (i+1) + " " + Notifications.data[i].title;
                }
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }

            return title;
        }

        public static int CountNotifications(string AccessToken)
        {
            FacebookClient fb = new FacebookClient(AccessToken);
            dynamic Notifications = fb.Get("/me/notifications");
            int NotificationCount = (int)Notifications.data.Count;
                
            return NotificationCount;
        }

        public static int CountMessages(string AccessToken)
        {
            FacebookClient fb = new FacebookClient(AccessToken);
            dynamic Message = fb.Get("/me/inbox");
            int MessageCount = (int)Message.data.Count;

            return MessageCount;
        }

        public static bool Post(string AccessToken, string Status)
        { 
            try
            {
                FacebookClient fb = new FacebookClient(AccessToken);
                Dictionary<string, object> PostArgs = new Dictionary<string, object>();
                PostArgs["message"] = Status+" -By Desktop Application(Speech Recognition)TEST";

                fb.Post("/me/feed", PostArgs);
                return true;
            }
            catch ( Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
