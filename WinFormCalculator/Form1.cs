using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (display_box.Text.Equals(""))
            {
                display_box.Text = button1.Text;
            }
            else
            {
                display_box.Text = display_box.Text + button1.Text;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (display_box.Text.Equals(""))
            {
                display_box.Text = button2.Text;
            }
            else
            {
                display_box.Text = display_box.Text + button2.Text;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (display_box.Text.Equals(""))
            {
                display_box.Text = button3.Text;
            }
            else
            {
                display_box.Text = display_box.Text + button3.Text;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (display_box.Text.Equals(""))
            {
                display_box.Text = button4.Text;
            }
            else
            {
                display_box.Text = display_box.Text + button4.Text;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (display_box.Text.Equals(""))
            {
                display_box.Text = button5.Text;
            }
            else
            {
                display_box.Text = display_box.Text + button5.Text;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (display_box.Text.Equals(""))
            {
                display_box.Text = button6.Text;
            }
            else
            {
                display_box.Text = display_box.Text + button6.Text;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (display_box.Text.Equals(""))
            {
                display_box.Text = button7.Text;
            }
            else
            {
                display_box.Text = display_box.Text + button7.Text;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (display_box.Text.Equals(""))
            {
                display_box.Text = button8.Text;
            }
            else
            {
                display_box.Text = display_box.Text + button8.Text;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (display_box.Text.Equals(""))
            {
                display_box.Text = button9.Text;
            }
            else
            {
                display_box.Text = display_box.Text + button9.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (display_box.Text.Equals(""))
            {
                display_box.Text = button10.Text;
            }
            else
            {
                display_box.Text = display_box.Text + button10.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (display_box.Text.Equals(""))
            {
                display_box.Text = button11.Text;
            }
            else
            {
                display_box.Text = display_box.Text + button11.Text;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (display_box.Text.Equals(""))
            {
                display_box.Text = button12.Text;
            }
            else
            {
                display_box.Text = display_box.Text + button12.Text;
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (display_box.Text.Equals(""))
            {
                display_box.Text = button13.Text;
            }
            else
            {
                display_box.Text = display_box.Text + button13.Text;
            }
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            if (display_box.Text.Equals(""))
            {
                display_box.Text = button14.Text;
            }
            else
            {
                display_box.Text = display_box.Text + button14.Text;
            }
        }
        
        // Clear button clicked
        private void button15_Click(object sender, EventArgs e)
        {
            display_box.Clear();
        }
        //Compute Button
        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void display_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
