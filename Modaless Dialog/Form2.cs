namespace Modaless_Dialog
{
    public partial class Form2 : Form
    {
        public Form1 MainForm { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
           MainForm.ChildForm = null;
        }
    }
}
