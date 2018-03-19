using System;
using System.IO;
using System.Windows.Forms;

namespace reflexTrainer
{
    public partial class Form4 : Form
    {
        public String pathD = "./default.txt", doc = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "Reflex Trainer", "yourT.txt");

        public Form4(string path)
        {
            InitializeComponent();

            if (!Directory.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "Reflex Trainer")))
            {
                Directory.CreateDirectory(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "Reflex Trainer"));
            }

            if (!File.Exists(doc))
            {
                File.Create(doc).Close();
            }

            if (path == pathD)
                button2.Text = "Użyj zapisanych";
            else
                button2.Text = "Użyj domyślnych";

            pathD = path;
        }

        private void add_Click(object sender, EventArgs e)
        {
            string t1 = string.Empty, t2 = string.Empty;

            foreach (char c in engWord.Text)
            {
                if (t1 != "" && c == ' ')
                    break;

                if (c != ' ' && c != '\t' && c != '\n')
                    t1 += c;
            }

            engWord.Text = String.Empty;

            foreach (char c in polWord.Text)
            {
                if (t2 != "" && c == ' ')
                    break;

                if (c != ' ' && c != '\t' && c != '\n' && c != '\r')
                    t2 += c;
            }

            if (t1 != String.Empty && t2 != String.Empty)
            { 
                t1 = t1 + ' ' + t2 + '\r';

                File.AppendAllText(doc, t1);

                polWord.Text = String.Empty;           
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            File.WriteAllText(doc, String.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pathD != "./default.txt")
            {
                pathD = "./default.txt";

                button2.Text = "Użyj zapisanych";
                this.Close();
            }
            else
            {
                pathD = doc;
                button2.Text = "Użyj domyślnych";

                if (new FileInfo(doc).Length == 0)
                {
                    MessageBox.Show("Brak zapisanych słów!", "Błąd!");

                    pathD = "./default.txt";
                    button2.Text = "Użyj zapisanych";
                }
                else
                    this.Close();
            }
        }
    }
}
