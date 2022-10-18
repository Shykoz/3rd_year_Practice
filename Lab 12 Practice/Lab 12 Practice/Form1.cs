using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;

        async private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (int.TryParse(textBox2.Text, out a) == true && int.TryParse(textBox3.Text, out a) == true)
                {
                    textBox4.Text = (Convert.ToInt32(textBox2.Text) / Convert.ToInt32(textBox3.Text)).ToString();
                    textBox4.ReadOnly = true;
                    textBox2.Text = "";
                    textBox3.Text = "";

                }

            }

            if (textBox2.Text == "" && int.TryParse(textBox3.Text, out a) == true && int.TryParse(textBox4.Text, out a) == true)
            {

                textBox2.Text = (Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox4.Text)).ToString(); 
                textBox2.ReadOnly = true;
                textBox3.Text = "";
                textBox4.Text = "";


            }
            if (textBox3.Text == "" && int.TryParse(textBox2.Text, out a) == true && int.TryParse(textBox4.Text, out a) == true)
            {

                textBox3.Text = (Convert.ToInt32(textBox2.Text) / Convert.ToInt32(textBox4.Text)).ToString();
                textBox3.ReadOnly = true;
                textBox2.Text = "";
                textBox4.Text = "";

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Select();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }
    }
}
