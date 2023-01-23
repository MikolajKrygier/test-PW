namespace test
{
    public partial class Form1 : Form
    {
        public static Form1 form1Instance;
        public string data,login;
        public Form1()
        {
            InitializeComponent();
            form1Instance = this;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="jankowalski"&&textBox2.Text=="123")
            {
                Form2 f2=new Form2();
                f2.ShowDialog();
            }
            else
            {

                MessageBox.Show("B³êdne dane logowania","B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                data = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                login=textBox1.Text;
                
            }
        }
    }
}