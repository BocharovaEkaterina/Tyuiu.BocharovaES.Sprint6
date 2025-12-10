using Tyuiu.BocharovaES.Sprint6.Task6.V6.Lib;
namespace Tyuiu.BocharovaES.Sprint6.Task6.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_BES_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BES.ShowDialog();
            openFilePath = openFileDialogTask_BES.FileName;
            textBoxIn_BES.Text = File.ReadAllText(openFilePath);
            groupBoxInput_BES.Text = groupBoxInput_BES.Text + " " + openFileDialogTask_BES.FileName;
            buttonDone_BES.Enabled = true;
        }

        private void buttonDone_BES_Click(object sender, EventArgs e)
        {
            textBoxResult_BES.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_BES_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
