using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Control_LED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.PortName = "COM" + 7;
            label2.Hide();
            numericUpDown1.Hide();
            button4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("1");
            serialPort1.Close();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("0");
            serialPort1.Close();
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("2");
            label2.Show();
            button4.Enabled = true;
            button4.Show();
            numericUpDown1.Show();
            serialPort1.Close();
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write(numericUpDown1.Value.ToString());
            serialPort1.Close();
            button4.Enabled = false;
            numericUpDown1.Hide();
            label2.Hide();
            button4.Hide();

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("3");//Pin choose mode
            serialPort1.Close();
        }

        private void ledSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("300");//Pin choose mode & selection
            serialPort1.Close();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("301");//Pin choose mode & selection
            serialPort1.Close();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("302");//Pin choose mode & selection
            serialPort1.Close();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("303");//Pin choose mode & selection
            serialPort1.Close();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("304");//Pin choose mode & selection
            serialPort1.Close();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("305");//Pin choose mode & selection
            serialPort1.Close();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("306");//Pin choose mode & selection
            serialPort1.Close();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("307");//Pin choose mode & selection
            serialPort1.Close();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("308");//Pin choose mode & selection
            serialPort1.Close();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("309");//Pin choose mode & selection
            serialPort1.Close();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("310");//Pin choose mode & selection
            serialPort1.Close();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("311");//Pin choose mode & selection
            serialPort1.Close();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("312");//Pin choose mode & selection
            serialPort1.Close();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("313");//Pin choose mode & selection
            serialPort1.Close();
            button1.Enabled = false;
            button2.Enabled = true;
        }
    }
}
