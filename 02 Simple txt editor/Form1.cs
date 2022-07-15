using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Simple_txt_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Clear();
            openFileDialog1.FileName = @"data\Text2.txt";
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == String.Empty) return;
            // Чтение текстового файла
            try
            {
                var file = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.GetEncoding(1251));
                textBox2.Text = file.ReadToEnd();
                file.Close();
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message + "\nНет такого файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var file = new System.IO.StreamWriter(saveFileDialog1.FileName, false,System.Text.Encoding.GetEncoding(1251));
                    file.Write(textBox2.Text);
                    file.Close();
                }
                catch (Exception ex)
                { // отчет о других ошибках
                    MessageBox.Show(ex.Message,"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=0;i<textBox2.Lines.Length;i++)
            {
                if (!textBox2.Lines[i].Contains(textBox1.Text))
                {
                    string remove = textBox2.Lines[i];
                    string[] lines = textBox2.Lines;
                    textBox2.Lines = lines.Where(val => val != remove).ToArray();
                }
            }
        }
    }
}
