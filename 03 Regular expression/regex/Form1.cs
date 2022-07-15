using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace regex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string exp = null;
            if (comboBox1.Text == "adress@domain.ru")
            {
                exp = @"\w*@\w*.ru";
            }
            else if (comboBox1.Text != "")
            {
                exp = comboBox1.Text;
            }
            else { MessageBox.Show("Не выбран фильтр регулярного выражения");return; }
            textBox2.Clear();
            string str = textBox1.Text;
            Regex regex = new Regex(exp);
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    textBox2.AppendText(match.Value);
                    textBox2.AppendText(Environment.NewLine);
                    textBox2.Focus();
                    label3.Text = "Найдено " + matches.Count + " совпадений.";
                }
            }
            else
            {
                label3.Text = "Совпадений не найдено.";
            }
        }
    }
}
