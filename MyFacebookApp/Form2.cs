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
    public partial class Form2 : Form
    {
        SpeechRecognitionEngine sSpeech;
        //SpeechSynthesizer sSynth;
        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder pBuilder;
        RecognitionResult result;
        TimeSpan ts;
        Random rnd;
        string QEvent;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            rnd = new Random();
            sSpeech = new SpeechRecognitionEngine();
            //sSynth = new SpeechSynthesizer();
            //sSynth = new SpeechSynthesizer();
            pBuilder = new PromptBuilder();
            sSpeech.SetInputToDefaultAudioDevice();
            sSpeech.LoadGrammar(new DictationGrammar());
            ts = new TimeSpan(0, 0, 5);
            sSpeech.SpeechRecognized += (s, args) =>
            {
                foreach (RecognizedWordUnit word in args.Result.Words)
                {
                    if (word.Confidence > 0.2f)
                        freeTextBox.Text += word.Text + " ";
                }
                //freeTextBox.Text += Environment.NewLine;
            };
        }

        public void destroy()
        {
            try
            {
                sSpeech.RecognizeAsyncStop();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
                
            sSpeech.Dispose();
            //sSynth.Dispose();
            
        }
        public void doFB()
        {
            FBVoice fbvoice = new FBVoice();
            fbvoice.FbRec();

        }

        private Grammar CreateSampleGrammar()
        {
            Choices commandChoices = new Choices("Calculator", "Notepad", "Internet Explorer", "Paint","hi");
            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Append(commandChoices);
            Grammar g = new Grammar(grammarBuilder);
            //g.Name = "Available programs";
            return g;
        }

        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //MessageBox.Show("Speech recognized: " +e.Result.Text+"...");
            if (e != null)
            {
                //freeTextBox.Text = e.Result.Text;
                int ranNum = rnd.Next(1, 10);
                string speech = e.Result.Text;
                switch (speech)
                {

                    case "Hello":
                    case "Hello ":
                        sSynth.Speak("Hi sir"); 
                        break;
                    
                    case "Goodbye":
                    case "Goodbye ":
                    case "Close":
                    case "Close ":
                        sSynth.Speak("Until next time");
                        //Close();
                        break;
                    
                    case "Stop talking":
                    //case "Stop talking ":
                        sSynth.Speak("Sorry, Mahendra");
                        break;

                    case "What's my name?":
                        sSynth.Speak("Your name is Mahendra..");

                        break;

                    case "Facebook":
                    case "FB":
                        frmMain myForm = new frmMain();
                        myForm.Show();
                        destroy();
                        doFB();


                        break;

                    case "What's your name?":
                        sSynth.Speak("My name is Speech engine...");
                        break;

                    case "Open website":
                        System.Diagnostics.Process.Start("http://www.google.com");
                            break;

                    case "What's the time now?":
                            DateTime now = DateTime.Now;
                            string time = now.GetDateTimeFormats('t')[0];
                            sSynth.Speak(time);
                            break;
                    case "What day is it":
                            sSynth.Speak(DateTime.Today.ToString("dddd"));
                            break;
                    case "Whats the date":
                    case "Whats todays date":
                            sSynth.Speak(DateTime.Today.ToString("dd-MM-yyyy"));
                            break;

                    



                    
                    default:
                            sSynth.Speak("I didnt Understand you");
                        break;
                }
            }
            else
            {
                sSynth.Speak("I didnt Understand you");
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMain myForm = new frmMain();
            myForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;
            Initialize();
            try
            {
                sSpeech.UnloadAllGrammars();
                //Grammar cg = CreateSampleGrammar();
                sSpeech.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"C:\Users\Mons\Documents\Visual Studio 2012\Projects\MyFacebookApp\Database.txt")))));
                sSpeech.RecognizeAsync(RecognizeMode.Multiple);
                sSpeech.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
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

        
        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button2.Enabled = true;
            destroy();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sSynth.Speak("Welcome to Speech engine");
            button3.Enabled = false;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            frmMain myForm = new frmMain();
            myForm.Show();
        }        

    }
}
