using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form4 : Form
    { 
        float num1,num2,ans,num3,num4,ans2;
        public Form4()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(textBox1.Text);
            num2 = Int32.Parse(textBox2.Text);
            ans = num1 - num2;
            

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text = ans2.ToString();
            textBox4.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num3 = Int32.Parse(textBox3.Text);
            num4 = Int32.Parse(textBox4.Text);
            ans2 = num3 - num4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num3 = Int32.Parse(textBox3.Text);
            num4 = Int32.Parse(textBox4.Text);
            ans2 = num3 * num4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num3 = Int32.Parse(textBox3.Text);
            num4 = Int32.Parse(textBox4.Text);
            ans2 = num3 / num4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num3= Int32.Parse(textBox3.Text);
            ans2 = num3 * num3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num3 = Int32.Parse(textBox3.Text);
            num4 = Int32.Parse(textBox4.Text);

            ans2 = num3;
            for(int i=1;i<num4;i++)
            {
                ans2 = ans2 * num3;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(textBox1.Text);
            num2 = Int32.Parse(textBox2.Text);
            ans = num1 * num2;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(textBox1.Text);
            num2 = Int32.Parse(textBox2.Text);
            ans = num1 / num2;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num3 = Int32.Parse(textBox3.Text);
            num4 = Int32.Parse(textBox4.Text);
            ans2 = num3 + num4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(textBox1.Text);
            num2 = Int32.Parse(textBox2.Text);
            ans = num1 + num2;
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = ans.ToString();
            textBox2.Text = "";
        }
    }
}
