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
                string list = textBox1.Text;
                string[] vinName = list.Trim().Split('\n');
                textBox3.Text = vinName[new Random().Next(0, vinName.Length)];
            }
        }   
    }
}


