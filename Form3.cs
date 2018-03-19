using System;
using System.Windows.Forms;

namespace reflexTrainer
{
    public partial class Form3 : Form
    {
        private double res, il;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Form3(int corr, int all, int time)
        {
            il = 60.00 / (double)time;

            try
            {
                InitializeComponent();

                if (all == 0)
                    throw new Exception();

                res = (Convert.ToDouble(corr) / Convert.ToDouble(all)) * 100.00;

                label3.Text = corr.ToString();
                label5.Text = all.ToString();
                label7.Text = (Math.Round((decimal)res, 0)).ToString();
                label10.Text = (Math.Round((il * Convert.ToDouble(corr)), 0)).ToString();
            }
            catch 
            {
                label3.Text = "0";
                label5.Text = "1";
                label7.Text = "0";
            }
        }        
    }
}
