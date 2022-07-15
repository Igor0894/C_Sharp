using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                cp.BackColor = cd.Color;
                panel.BackColor = cd.Color;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int x = new int();
                try
                {
                    x = Convert.ToInt32(textBox1.Text);
                    if (x < 5) { x = 5; }
                    else if (x + panel.Width > panel2.Width - 5)
                    {
                        x = panel2.Width - panel.Width - 5;
                    }
                    panel.Left = x;
                }
                catch
                {
                    MessageBox.Show("Вы ввели некорректное значение");
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int y = new int();
                try
                {
                    y = Convert.ToInt32(textBox2.Text);
                    if (y < 5) { y = 5; }
                    else if (y + panel.Height > panel2.Height - 5)
                    {
                        y = panel2.Height - panel.Height - 5;
                    }
                    panel.Top = y;
                }
                catch
                {
                    MessageBox.Show("Вы ввели некорректное значение");
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int w = new int();
                try
                {
                    w = Convert.ToInt32(textBox3.Text);
                    if (w < 5) { w = 5; }
                    else if (w > panel2.Width - 10)
                    {
                        w = panel2.Width - 10;
                    }
                    panel.Width = w;
                }
                catch
                {
                    MessageBox.Show("Вы ввели некорректное значение");
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int h = new int();
                try
                {
                    h = Convert.ToInt32(textBox4.Text);
                    if (h < 5) { h = 5; }
                    else if (h > panel2.Height - 10)
                    {
                        h = panel2.Height - 10;
                    }
                    panel.Height = h;
                }
                catch
                {
                    MessageBox.Show("Вы ввели некорректное значение");
                }
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string str;
                try
                {
                    str = textBox5.Text;
                    label7.Text = str;
                }
                catch
                {
                    MessageBox.Show("Вы ввели некорректное значение");
                }
            }
        }
    }
}
