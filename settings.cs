using System;
using System.Windows.Forms;

namespace reflexTrainer
{
    public partial class settings : Form
    {
        public bool men, ton, red;

        

        public settings(bool t2, bool t3)
        {
            InitializeComponent();

            if (t2)
                tone.Checked = true;
            if (t3)
                reading.Checked = true;
        }

        private void reading_CheckedChanged(object sender, EventArgs e)
        {
            red = reading.Checked;
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unmute_Click(object sender, EventArgs e)
        {         
            tone.Checked = false;

            reading.Checked = false;
        }

        private void mute_Click(object sender, EventArgs e)
        {         
            tone.Checked = true;

            reading.Checked = true;
        }

        private void tone_CheckedChanged(object sender, EventArgs e)
        {
            ton = tone.Checked;
        }


    }
}
