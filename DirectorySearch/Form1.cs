using System;
using System.Windows.Forms;
using System.IO;

namespace DirectorySearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] strEntries = Directory.GetFiles(textBox1.Text, "*.*", SearchOption.AllDirectories);

            foreach (string item in strEntries)
                listBox1.Items.Add(item);
        }
    }
}
