using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mart_WinForm_App
{
    public partial class Form1 : Form
    {
        int price;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                numericUpDown1.Enabled = true;
                comboBox1.Enabled = true;
            }
            else
            {
                numericUpDown1.Enabled = false;
                comboBox1.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox5.Checked == true)
            {
                numericUpDown7.Enabled = true;
                comboBox6.Enabled = true;
            }
            else
            {
                numericUpDown7.Enabled = false;
                comboBox6.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                numericUpDown5.Enabled = true;
                comboBox5.Enabled = true;
            }
            else
            {
                numericUpDown5.Enabled = false;
                comboBox5.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                numericUpDown4.Enabled = true;
                comboBox2.Enabled = true;
            }
            else
            {
                numericUpDown4.Enabled = false;
                comboBox2.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                numericUpDown3.Enabled = true;
                comboBox3.Enabled = true;
            }
            else
            {
                numericUpDown3.Enabled = false;
                comboBox3.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                numericUpDown2.Enabled = true;
                comboBox4.Enabled = true;
            }
            else
            {
                numericUpDown2.Enabled = false;
                comboBox4.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            if(radioButton1.Checked == true)
            {
                price = 10;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                price = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                numericUpDown1.Enabled = false;
                comboBox1.Enabled = false;
                checkBox1.Checked = false;
            }
            if (checkBox6.Checked == true)
            {
                numericUpDown2.Enabled = false;
                comboBox4.Enabled = false;
                checkBox6.Checked = false;
            }
            if (checkBox5.Checked == true)
            {
                numericUpDown7.Enabled = false;
                comboBox6.Enabled = false;
                checkBox5.Checked = false;
            }
            if (checkBox3.Checked == true)
            {
                numericUpDown4.Enabled = false;
                comboBox2.Enabled = false;
                checkBox3.Checked = false;
            }
            if (checkBox2.Checked == true)
            {
                numericUpDown3.Enabled = false;
                comboBox3.Enabled = false;
                checkBox2.Checked = false;
            }
            if (checkBox4.Checked == true)
            {
                numericUpDown5.Enabled = false;
                comboBox5.Enabled = false;
                checkBox4.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text.Equals("High"))
            {
                
            }
            
            if (comboBox6.Text.Equals("High"))
            {
                
            }
            if (comboBox5.Text.Equals("High"))
            {
                
            }
            if (comboBox2.Text.Equals("High"))
            {
                
            }
            if (comboBox3.Text.Equals("High"))
            {
               
            }
            if (comboBox4.Text.Equals("High"))
            {
                
            }
        }
    }
}
