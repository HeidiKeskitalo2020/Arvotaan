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
using System.Diagnostics;

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

            if (radioButton3.Checked)
            {
                string list = textBox1.Text;
                string[] vinName = list.Trim().Split(new string[] { "\r\n\r\n" },
                    StringSplitOptions.RemoveEmptyEntries);
                textBox3.Text = vinName[new Random().Next(0, vinName.Length)];
            }

            if (radioButton1.Checked)
            {
                string list = textBox1.Text;
                string[] vinName = list.Trim().Split('\n');
                textBox3.Text = vinName[new Random().Next(0, vinName.Length)];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ofd.Filter = "*TXT|*.txt";
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = System.IO.File.ReadAllText(Ofd.FileName);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/HeidiKeskitalo2020/Arvotaan/blob/master/Assets/Osallistuminen%20nimien%20mukaan.txt");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/HeidiKeskitalo2020/Arvotaan/blob/master/Assets/FB%20Kommenteista%20poimittu%20ryhmittelyt.txt");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/HeidiKeskitalo2020/Arvotaan/blob/master/Assets/Ig%20nimiryhmittely.txt");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/HeidiKeskitalo2020/Arvotaan/blob/master/README.md");
        }
    }
}


