using System;
using System.Windows.Forms;

namespace reflexTrainer
{
    public partial class menu : Form
    {            
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        int amountTime = 60;
        public string defaultStr = "./default.txt";
        public bool ton, read = false;

        public menu()
        {
            InitializeComponent();   
        }

        private void start_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1(amountTime, defaultStr, ton, read);

            try
            {
                game.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Spróbuj ponownie!", "Błąd!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void instrukcja_Click(object sender, EventArgs e)
        {
            Form5 ins = new Form5();

            ins.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacja została stworzona przez Michała Wojsa", "O aplikacji");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 cont = new Form6();

            cont.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 tme = new Form2();

            tme.ShowDialog();

            amountTime = tme.numTime;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 te = new Form4(defaultStr);

            te.ShowDialog();

            defaultStr = te.pathD;

        }

        private void settings_Click(object sender, EventArgs e)
        {
            settings set = new settings(ton, read);

            set.ShowDialog();          

            ton = set.ton;
            read = set.red;
        }
    }
}
