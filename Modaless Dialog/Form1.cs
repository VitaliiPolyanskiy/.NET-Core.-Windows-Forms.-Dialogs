namespace Modaless_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form2 ChildForm { get; set; }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (ChildForm != null)
            {
                ChildForm.Activate();
                return;
            }
            ChildForm = new Form2();
            ChildForm.MainForm = this;
            ChildForm.Show();
        }
    }
}