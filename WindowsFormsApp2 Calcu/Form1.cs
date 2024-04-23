using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp2_Calcu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c;
            if (radioButton1.Checked)
            {
                c = a + b;
                label4.Text = "Total: " + c.ToString();
            }
            if (radioButton2.Checked)
            {
                c = a - b;
                label4.Text = "Different: " + c.ToString();
            }
            if (radioButton3.Checked)
            { 
                c = a * b;
                label4.Text = "Multiply: " + c.ToString();
            }
            if (radioButton4.Checked)
            {
                c = a / b;
                label4.Text = "Divide:" + c.ToString();
            }
            if (radioButton5.Checked)
            {
                c = a % b;
                label4.Text = "Mod:" + c.ToString();
            }
        }  
private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lime;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lime;
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
