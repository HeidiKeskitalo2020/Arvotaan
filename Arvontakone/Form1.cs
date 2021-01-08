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
using System.Net;

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
                string n = textBox2.Text;
                int numerot = Convert.ToInt32(n);

                for (int i = 0; i < pick.Length; i++)
                {
                    number = num.Next(1, numerot);
                    while (!(pick.Contains(number)))
                    {
                        pick[i] = number;
                    }
                    textBox3.Text = (number.ToString());
                }
            }

            else if (radioButton1.Checked)
            {
                //var vinName = new WebClient().DownloadString("https://pastebin.com/raw/abWpS6yJ").Split('\n');
                //textBox3.Text = vinName[new Random().Next(0, vinName.Length)];
                //StreamReader sr = new StreamReader(@"C:\Arvonta\Arvonta.txt");
                ////StreamWriter writer = new StreamWriter(@"C:\Arvonta\Arvonta.txt");
                ////string name = sr.ReadLine();


                //string filePath = @"C:\Arvonta\Arvonta.txt";
                string list = textBox1.Text;
                string[] vinName = list.Trim().Split('\n');
                textBox3.Text = vinName[new Random().Next(0, vinName.Length)];

                //List<string> lines = File.ReadAllLines(filePath).ToList();

                ////var line_number = 0;

                ////foreach (var line in lines)
                ////{
                ////    line_number++;

                ////    string[] entries = line.Trim().Split('\n');

                ////    if (entries.Length == 1 && entries[0] == "")
                ////    {
                ////        continue;
                ////    }

                //Random vinName = new Random();


                //{
                //    string indexOpenfile = vinName.Next(textBox1.Length);
                //    this.textBox1.Text = textBox1[indexOpenfile];
                //}
            }
        }
        }
    }


