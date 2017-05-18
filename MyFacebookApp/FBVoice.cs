using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Xml;

namespace MyFacebookApp
{
  
    class FBVoice
    {
            SpeechRecognitionEngine fbSpeech,postSpeech;
            public static String[] ListFriend = new String[1000];
            public static String[] ListNotification = new String[10];
            public static String title;
            public static int CountMsg;
            //SpeechSynthesizer sSynth;
            SpeechSynthesizer fbSynth = new SpeechSynthesizer();
            RecognitionResult result;
            TimeSpan ts;
            Random rnd;
            string QEvent;
            int count = 0;
            frmMain fbMain = new frmMain();

            public FBVoice()
            {
                Initialize();
            }
        private void Initialize()
            {
                rnd = new Random();
                fbSpeech = new SpeechRecognitionEngine();
                //pBuilder = new PromptBuilder();
                fbSpeech.SetInputToDefaultAudioDevice();
                fbSpeech.LoadGrammar(new DictationGrammar());
                ts = new TimeSpan(0, 0, 10);
                
            }

            public void destroy()
            {
                try
                {
                    fbSpeech.RecognizeAsyncStop();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                fbSpeech.Dispose();
                //sSynth.Dispose();

            }
            public void doPost()
            {
                postSpeech = new SpeechRecognitionEngine();
            }


            void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
            {
                //MessageBox.Show("Speech recognized: " +e.Result.Text+"...");
                if (e != null)
                {
                    int ranNum = rnd.Next(1, 10);
                    string speech = e.Result.Text;
                    int NotifcationCount;


                    switch (speech)
                    {
                        case "Login":
                            fbSynth.Speak("Loging in to facebook...");
                            count++;
                            fbMain.voiceLogin();
                            break;
                        case "Options":
                            if(count > 0)
                            fbSynth.Speak("Notifications , Messages , Post to your wall , Friends list");
                            else
                                fbSynth.Speak("First you have to login...");
                            break;
                        

                        case "Post to your wall":
                            if (count > 0)
                            {
                                fbSynth.Speak("Say hi to your friends...");
                                count++;
                            }
                            else
                                fbSynth.Speak("First you have to login...");
                            
                            break;
                        case "hi friends":
                            if (count > 1)
                                fbMain.voiceBtnPost_Click("hi friends");
                            else
                                fbSynth.Speak("come through proper order...");
                            break;
                        case "hi how are you all":
                            if (count > 1)    
                                fbMain.voiceBtnPost_Click("hi how are you all?");
                            else    
                                fbSynth.Speak("come through proper order...");
                            break;
                        case "Friend list":
                            fbSynth.Speak("Getting Friends list");
                            int i = 0;
                            ListFriend = FBClass.voiceGetFrndList(AppSettings.Default.AccessToken);
                            while (ListFriend[i] != "###")
                            {
                                i++;
                            }
                            fbSynth.Speak("You have "+i+" Friends");
                            break;
                        case "Notifications":                           
                            fbSynth.Speak("Getting Notification");
                            NotifcationCount = FBClass.CountNotifications(AppSettings.Default.AccessToken);
                            title = FBClass.GetNotifications(AppSettings.Default.AccessToken);
                            fbSynth.Speak("Currently you have " + ",,,, "+NotifcationCount +",,,,   "+ " Notifications");
                            fbSynth.Speak(" "+title+" ");
                            break;
                        case "Messages":
                            CountMsg = FBClass.CountMessages(AppSettings.Default.AccessToken);
                            fbSynth.Speak("You have "+ CountMsg +" messages");
                            break;
                    }
                
                }
                else
                {
                    fbSynth.Speak("I didnt Understand you");
                }
            }

            public void FbRec()
            {

                try
                {
                    fbSpeech.UnloadAllGrammars();
                    //Grammar cg = CreateSampleGrammar();
                    fbSpeech.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"C:\Users\Mons\Documents\Visual Studio 2012\Projects\MyFacebookApp\FBDatabase.txt")))));
                    fbSpeech.RecognizeAsync(RecognizeMode.Multiple);
                    fbSpeech.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                /*  try
                  {
                      result = sSpeech.Recognize(ts);
                      if (result != null)
                      {
                          foreach (RecognizedWordUnit word in result.Words)
                          {

                              freeTextBox.Text += word.Text + " ";
                          }
                      }
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message);
                  }*/



            }


        }
        
    }

