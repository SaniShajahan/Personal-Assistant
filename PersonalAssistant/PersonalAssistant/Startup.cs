using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MP3_PLAYER;
using Browser;
using System.Speech.Recognition;


namespace PersonalAssistant
{

    public partial class Startup : Form
    {
        SpeechRecognitionEngine recEngineStartUp = new SpeechRecognitionEngine();
        public Startup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartUP sm = new StartUP();
            sm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator F3 = new Calculator();
            F3.Show();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            Choices commandsStartUp = new Choices();
            commandsStartUp.Add(new String[] { "Calculator", "Browser", "Music Player", "Contact", "Close" });
            GrammarBuilder gBuilderStartUp = new GrammarBuilder();
            gBuilderStartUp.Append(commandsStartUp);
            Grammar grammarStartUp = new Grammar(gBuilderStartUp);

            recEngineStartUp.LoadGrammarAsync(grammarStartUp);
            recEngineStartUp.SetInputToDefaultAudioDevice();
            recEngineStartUp.SpeechRecognized += recEngineStartUp_SpeechRecognized;

            recEngineStartUp.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void recEngineStartUp_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "Browser":
                    Browser.Browser b = new Browser.Browser();
                    b.Show();
                    break;
                case "Calculator":
                    Calculator F3 = new Calculator();
                    F3.Show();                   
                    break;
                case "Contact":
                    MessageBox.Show("Contact");                   
                    break;
                case "Music Player":
                    StartUP sm = new StartUP();
                    sm.Show();
                    break;
                case "Close":
                    this.Dispose();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Browser.Browser b = new Browser.Browser();
            b.Show();
        }
    }
}
