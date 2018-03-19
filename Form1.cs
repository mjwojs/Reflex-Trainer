using SpeechLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace reflexTrainer
{
    public partial class Form1 : Form
    {
        List<string> chars = new List<string>();
        string lett;
        Random random = new Random();
        private int score = 0, all = 0, _time;
        private bool play, speak;
        private int _ticks;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        SpVoice voice = new SpVoice();

        public Form1(int tme, string path, bool pl, bool spe)
        {
            InitializeComponent();
            button1.Select();
            textBox1.Enabled = false;
            _time = tme;
            _ticks = tme;
            label4.Text = _ticks.ToString();
            play = pl;
            speak = spe;

            string line;

            try
            {

                using (StreamReader sr = new StreamReader(path))
                {
                    line = sr.ReadToEnd();
                }

                var lines = line.Split('\r');

                foreach (string i in lines)
                {
                    chars.Add(i);
                }
            }
            catch
            {
                this.Close();
            }
        }

        private void label1Change()
        {
            lett = chars[random.Next(chars.Count()-1)];

            var t1 = lett.Split();

            all++;

            if (!speak)
                voice.Speak(t1[0], SpeechVoiceSpeakFlags.SVSFlagsAsync);

            label1.Text = t1[0];
            pol.Text = "(" + t1[1] + ")";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Wzór";
            pol.Text = "(tłumaczenie)";
            textBox1.Text = "";

            timer1.Stop();
            _ticks = _time;
            label4.Text = _ticks.ToString();

            score = 0;
            label3.Text = score.ToString();
            textBox1.Enabled = false;
            all = 0;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space || e.KeyData == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                label1.Text = Regex.Replace(label1.Text, @"\s+", ""); //usuniecie "smieciowych" znakow

                if (textBox1.Text == label1.Text)
                {   
                    score++;

                    label3.Text = score.ToString();

                    if (!play)
                    {
                        wplayer.URL = "beep1.mp3";

                        wplayer.controls.play();
                    }
                }
                else
                {
                    if (!play)
                    {
                        wplayer.URL = "beep2.mp3";
                    }
                }

                textBox1.Text = "";                

                label1Change();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks--;
            label4.Text = _ticks.ToString();

            if (_ticks == 0)
            {
                timer1.Stop();
                
                textBox1.Enabled = false;

                all--;

                Form3 res = new Form3(score, all, _time);

                if (!play)
                {
                    wplayer.URL = "win.mp3";

                    wplayer.controls.play();
                }

                res.ShowDialog();

                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Select();
            timer1.Start();
            label1Change();
        }
    }
}
