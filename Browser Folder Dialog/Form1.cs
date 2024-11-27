namespace Browser_Folder_Dialog
{
    public partial class Form1 : Form
    {
        string pathToFolder = "C:\\";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] astrFiles = Directory.GetFiles(pathToFolder);
            listBox1.Items.Add("Всего файлов: " + astrFiles.Length);
            foreach (string file in astrFiles)
                listBox1.Items.Add(file);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pathToFolder = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}