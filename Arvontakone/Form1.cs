using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Arvontakone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog Ofd = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            Ofd.Filter = "*TXT|*.txt";
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(ofd.SafeFileName);
                //OpenFile.Text = Ofd.SafeFileName;
                textBox1.Text = System.IO.File.ReadAllText(Ofd.FileName);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                int number = 0;
                Random num = new Random();
                int[] pick = new int[3];
                //string n = OsallistujaMäärä.Text;
                //int numerot = Convert.ToInt32(n);

                for (int i = 0; i < pick.Length; i++)
                {
                    number = num.Next(1, 10);
                    while (!(pick.Contains(number)))
                    {
                        pick[i] = number;
                    }
                    textBox3.Text = (number.ToString());
                    //Tulos.Text = OsallistujaMäärä.Text;
                }
            }

            if (radioButton1.Checked)
            {
                StreamReader sr = new StreamReader(@"C:\Arvonta\Arvonta.txt");
                //StreamWriter writer = new StreamWriter(@"C:\Arvonta\Arvonta.txt");
                //string name = sr.ReadLine();

                string filePath = @"C:\Arvonta\Arvonta.txt";

                List<string> lines = File.ReadAllLines(filePath).ToList();

                var line_number = 0;

                foreach (var line in lines)
                {
                    line_number++;

                    string[] entries = line.Trim().Split('\n');

                    if (entries.Length == 1 && entries[0] == "")
                    {
                        continue;
                    }

                    Random vinName = new Random();


                    //{
                    //    string indexOpenfile = vinName.Next(OpenFile.Length);
                    //    this.TextBox1.Text = OpenFile[indexOpenfile];
                    //}
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
