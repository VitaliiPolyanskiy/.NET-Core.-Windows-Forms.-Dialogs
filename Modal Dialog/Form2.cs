namespace Modal_Dialog
{
    public partial class Form2 : Form
    {
        public Form MainForm { get; set; }
        public string Info
        {
            get { return textBox1.Text; }
            set { label1.Text = value; }
        }
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm.Text = "Привет от дочернего окна";
        }
    }
}
