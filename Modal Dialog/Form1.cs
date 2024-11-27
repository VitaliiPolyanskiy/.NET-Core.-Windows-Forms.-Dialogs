namespace Modal_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new();
            frm.MainForm = this;
            frm.Info = textBox1.Text;
            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                Text = frm.Info;
            }

        }
    }
}