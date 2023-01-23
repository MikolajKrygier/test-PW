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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            richTextBox1.Text = Form2.form2Instance.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.form2Instance.Text = richTextBox1.Text;
        }
    }
}
