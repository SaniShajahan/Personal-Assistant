using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace MP3_PLAYER
{
    public partial class MusicPlayer : Form
    {
        public String S;
        public int PlaySong;

        SpeechRecognitionEngine recEngineMusicPlayer = new SpeechRecognitionEngine();

        public MusicPlayer(String S)
        {
            InitializeComponent();
            this.S = S;
        }
        string[] files, paths;

        public void nextSong()
        {
            int count=listBox1.Items.Count;
            if (PlaySong < (count - 1))
            {
                PlaySong++;
                WindowsMediaPlayer.URL = paths[PlaySong];
            }
            else
                MessageBox.Show("You are playing your last song");
            //MessageBox.Show(Convert.ToString(PlaySong));
        }
        public void previousSong()
        {
            int count = listBox1.Items.Count;
            if(PlaySong <= 0)
            {
                MessageBox.Show("You are playing your first song");
            }
            else
            {
                PlaySong--;
                WindowsMediaPlayer.URL = paths[PlaySong];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
            WindowsMediaPlayer.URL = paths[listBox1.SelectedIndex];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            files = Directory.GetFiles(@S);
            paths = Directory.GetFiles(@S);
                for (int i = 0; i < files.Length; i++)
                {
                    listBox1.Items.Add(files[i]);
                }
                listBox1.SelectedIndex = 0;
                PlaySong = listBox1.SelectedIndex;
                WindowsMediaPlayer.URL = paths[listBox1.SelectedIndex];

                Choices commandsMusicPlayer = new Choices();
                commandsMusicPlayer.Add(new String[] { "Next Song","Previous Song","Stop","Exit","Back" });
                GrammarBuilder gBuilderMusicPlayer = new GrammarBuilder();
                gBuilderMusicPlayer.Append(commandsMusicPlayer);
                Grammar grammar = new Grammar(gBuilderMusicPlayer);

                recEngineMusicPlayer.LoadGrammarAsync(grammar);
                recEngineMusicPlayer.SetInputToDefaultAudioDevice();
                recEngineMusicPlayer.SpeechRecognized += recEngine_SpeechRecognized;

                //recEngineMusicPlayer.RecognizeAsync(RecognizeMode.Multiple);
                
        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //throw new NotImplementedException();
            switch (e.Result.Text)
            {
                case "Next Song":                    
                    nextSong();
                    break;
                case "Previous Song":
                    previousSong();
                    break;
                case "Stop":
                    WindowsMediaPlayer.close();
                    break;
                case "Play":
                    WindowsMediaPlayer.URL = paths[PlaySong];
                    break;
                case "Exit":
                    this.Dispose();
                    break;
                case "Back":
                    recEngineMusicPlayer.RecognizeAsyncStop();
                    StartUP S1 = new StartUP();
                    S1.Show();
                    this.Hide();
                    WindowsMediaPlayer.close();
                    break;
            }
                   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            recEngineMusicPlayer.RecognizeAsyncStop();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recEngineMusicPlayer.RecognizeAsyncStop();
            StartUP S1 = new StartUP();
            S1.Show();
            this.Hide();
            WindowsMediaPlayer.close();
        }
    }
}
