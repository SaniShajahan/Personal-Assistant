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

namespace MP3_PLAYER
{
    public partial class StartUP : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        public StartUP()
        {
            InitializeComponent();
        }
        public void Transparent(Button B1)
        {
            B1.FlatStyle = FlatStyle.Flat;
            B1.BackColor = Color.Transparent;
            B1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            B1.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }



        private void StartUP_Load(object sender, EventArgs e)
        {
            Transparent(button1);
            Transparent(button2);
            Transparent(button3);
            Transparent(button4);
            Transparent(button5);
            Transparent(button6);
            Transparent(button7);
            Transparent(button8);
            Transparent(button9);
            Transparent(btnEnable);
            Transparent(btnDisable);

            btnDisable.Enabled = false;

            Choices commands = new Choices();
            commands.Add(new String[] { "i am on aggressive mode", "i am on quite mode", "i am on angry mode", "i am on calming mode", "i am on funky mode", "i am on depressed mode", "i am on cheerfull mode", "i am on jolly mode", "i am on romantic mode" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;

        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //throw new NotImplementedException();

            switch (e.Result.Text)
            {
                case "i am on aggressive mode":
                    String S4 = "E:\\MP3 PLAYER(Project)\\Songs\\Aggressive";
                    MusicPlayer F = new MusicPlayer(S4);
                    F.Show();
                    this.Hide();
                    recEngine.RecognizeAsyncStop();
                    break;
                case "i am on quite mode":
                    String S1 = "E:\\MP3 PLAYER(Project)\\Songs\\Quite";
                    MusicPlayer F1 = new MusicPlayer(S1);
                    F1.Show();
                    this.Hide();
                    recEngine.RecognizeAsyncStop();
                    break;
                case "i am on angry mode":
                    String S2 = "E:\\MP3 PLAYER(Project)\\Songs\\Angry";
                    MusicPlayer F2 = new MusicPlayer(S2);
                    F2.Show();
                    this.Hide();
                    recEngine.RecognizeAsyncStop();
                    break;
                case "i am on calming mode":
                    String S3 = "E:\\MP3 PLAYER(Project)\\Songs\\Calming";
                    MusicPlayer F3 = new MusicPlayer(S3);
                    F3.Show();
                    this.Hide();
                    recEngine.RecognizeAsyncStop();
                    break;
                case "i am on funky mode":
                    String S5 = "E:\\MP3 PLAYER(Project)\\Songs\\Funky";
                    MusicPlayer F5 = new MusicPlayer(S5);
                    F5.Show();
                    this.Hide();
                    recEngine.RecognizeAsyncStop();
                    break;
                case "i am on depressed mode":
                    String S6 = "E:\\MP3 PLAYER(Project)\\Songs\\Depressed";
                    MusicPlayer F6 = new MusicPlayer(S6);
                    F6.Show();
                    this.Hide();
                    recEngine.RecognizeAsyncStop();
                    break;
                case "i am on cheerfull mode":
                    String S7 = "E:\\MP3 PLAYER(Project)\\Songs\\Cheerfull";
                    MusicPlayer F7 = new MusicPlayer(S7);
                    F7.Show();
                    this.Hide();
                    recEngine.RecognizeAsyncStop();
                    break;
                case "i am on jolly mode":
                    String S8 = "E:\\MP3 PLAYER(Project)\\Songs\\Jolly";
                    MusicPlayer F8 = new MusicPlayer(S8);
                    F8.Show();
                    this.Hide();
                    recEngine.RecognizeAsyncStop();
                    break;
                case "i am on romantic mode":
                    String S9 = "E:\\MP3 PLAYER(Project)\\Songs\\Romantic";
                    MusicPlayer F9 = new MusicPlayer(S9);
                    F9.Show();
                    this.Hide();
                    recEngine.RecognizeAsyncStop();
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String S = "E:\\MP3 PLAYER(Project)\\Songs\\Aggressive";
            MusicPlayer F = new MusicPlayer(S);
            F.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String S = "E:\\MP3 PLAYER(Project)\\Songs\\Quite";
            MusicPlayer F = new MusicPlayer(S);
            F.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String S = "E:\\MP3 PLAYER(Project)\\Songs\\Angry";
            MusicPlayer F = new MusicPlayer(S);
            F.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String S = "E:\\MP3 PLAYER(Project)\\Songs\\Calming";
            MusicPlayer F = new MusicPlayer(S);
            F.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String S = "E:\\MP3 PLAYER(Project)\\Songs\\Funky";
            MusicPlayer F = new MusicPlayer(S);
            F.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String S = "E:\\MP3 PLAYER(Project)\\Songs\\Depressed";
            MusicPlayer F = new MusicPlayer(S);
            F.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String S = "E:\\MP3 PLAYER(Project)\\Songs\\Cheerfull";
            MusicPlayer F = new MusicPlayer(S);
            F.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String S = "E:\\MP3 PLAYER(Project)\\Songs\\Jolly";
            MusicPlayer F = new MusicPlayer(S);
            F.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String S = "E:\\MP3 PLAYER(Project)\\Songs\\Romantic";
            MusicPlayer F = new MusicPlayer(S);
            F.Show();
            this.Hide();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            btnDisable.Enabled = true;
            btnEnable.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btnDisable.Enabled = false;
            btnEnable.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
    }
}
