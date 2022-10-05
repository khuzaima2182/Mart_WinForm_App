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
        int price,quantity;
        int q1, q2, q3, q4, q5, q6;
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
                numericUpDown1.Value = 1;
            }
            if (checkBox6.Checked == true)
            {
                numericUpDown2.Enabled = false;
                comboBox4.Enabled = false;
                checkBox6.Checked = false;
                numericUpDown2.Value = 1;
            }
            if (checkBox5.Checked == true)
            {
                numericUpDown7.Enabled = false;
                comboBox6.Enabled = false;
                checkBox5.Checked = false;
                numericUpDown7.Value = 1;
            }
            if (checkBox3.Checked == true)
            {
                numericUpDown4.Enabled = false;
                comboBox2.Enabled = false;
                checkBox3.Checked = false;
                numericUpDown4.Value = 1;
            }
            if (checkBox2.Checked == true)
            {
                numericUpDown3.Enabled = false;
                comboBox3.Enabled = false;
                checkBox2.Checked = false;
                numericUpDown3.Value = 1;
            }
            if (checkBox4.Checked == true)
            {
                numericUpDown5.Enabled = false;
                comboBox5.Enabled = false;
                checkBox4.Checked = false;
                numericUpDown5.Value = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bil,total_bill;
            
            if (checkBox1.Checked == true)
            {
                label21.Text = "Apple";
                if (comboBox1.Text.Equals("High"))
                {
                    price = 200;
                    label31.Text = comboBox1.Text;
                    label25.Text = numericUpDown1.Value.ToString();
                    q1 = (int)(numericUpDown1.Value * price);
                    label37.Text = q1.ToString();
                }
                else
                {
                    price = 150;
                    label31.Text = comboBox1.Text;
                    label25.Text = numericUpDown1.Value.ToString();
                    q1 = (int)(numericUpDown1.Value * price);
                    label37.Text = q1.ToString();
                }
            }
            if (checkBox5.Checked == true)
            {
                label20.Text = "Orange";
                if (comboBox6.Text.Equals("High"))
                {
                    price = 200;
                    label32.Text = comboBox6.Text;
                    label26.Text = numericUpDown7.Value.ToString();
                    q2 = (int)(numericUpDown7.Value * price);
                    label38.Text = q2.ToString();
                }
                else
                {
                    price = 150;
                    label32.Text = comboBox6.Text;
                    label26.Text = numericUpDown7.Value.ToString();
                    q2 = (int)(numericUpDown7.Value * price);
                    label38.Text = q2.ToString();
                }
            }
            if (checkBox4.Checked == true)
            {
                label19.Text = "Mango";
                if (comboBox5.Text.Equals("High"))
                {
                    price = 200;
                    label33.Text = comboBox5.Text;
                    label27.Text = numericUpDown5.Value.ToString();
                    q3 = (int)(numericUpDown5.Value * price);
                    label39.Text = q3.ToString();
                }
                else
                {
                    price = 150;
                    label33.Text = comboBox5.Text;
                    label27.Text = numericUpDown5.Value.ToString();
                    q3 = (int)(numericUpDown5.Value * price);
                    label39.Text = q3.ToString();
                }
            }
            if (checkBox3.Checked == true)
            {
                label16.Text = "Peach";
                if (comboBox2.Text.Equals("High"))
                {
                    price = 200;
                    label28.Text = comboBox2.Text;
                    label22.Text = numericUpDown4.Value.ToString();
                    q4 = (int)(numericUpDown4.Value * price);
                    label34.Text = q4.ToString();
                }
                else
                {
                    price = 150;
                    label28.Text = comboBox2.Text;
                    label22.Text = numericUpDown4.Value.ToString();
                    q4 = (int)(numericUpDown4.Value * price);
                    label34.Text = q4.ToString();
                }
            }
            if (checkBox2.Checked == true)
            {
                label17.Text = "Pineapple";
                if (comboBox3.Text.Equals("High"))
                {
                    price = 200;
                    label29.Text = comboBox3.Text;
                    label23.Text = numericUpDown3.Value.ToString();
                    q5 = (int)(numericUpDown3.Value * price);
                    label35.Text = q5.ToString();
                }
                else
                {
                    price = 150;
                    label29.Text = comboBox3.Text;
                    label23.Text = numericUpDown3.Value.ToString();
                    q5 = (int)(numericUpDown3.Value * price);
                    label35.Text = q5.ToString();
                }
            }
            if (checkBox6.Checked == true)
            {
                label18.Text = "Strawberry";
                if (comboBox4.Text.Equals("High"))
                {
                    price = 200;
                    label30.Text = comboBox4.Text;
                    label24.Text = numericUpDown2.Value.ToString();
                    q6 = (int)(numericUpDown2.Value * price);
                    label36.Text = q6.ToString();
                }
                else
                {
                    price = 150;
                    label30.Text = comboBox4.Text;
                    label24.Text = numericUpDown2.Value.ToString();
                    q6 = (int)(numericUpDown2.Value * price);
                    label36.Text = q6.ToString();
                }
            }
            if (radioButton1.Checked == true)
            {
                total_bill = (q1 + q2 + q3 + q4 + q5 + q6+10);
                label15.Text = total_bill.ToString();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
