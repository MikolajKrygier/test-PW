using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test
{
    public partial class Form2 : Form
    {
        public static Form2 form2Instance;
        public Form2()
        {
            InitializeComponent();
            form2Instance = this;
            string Text;
            string ostatnie;
            label7.Text = Form1.form1Instance.data;
            label8.Text = Form1.form1Instance.login;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Size = new Size (Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
