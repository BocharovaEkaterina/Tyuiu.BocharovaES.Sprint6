using Tyuiu.BocharovaES.Sprint6.Task1.V19.Lib;
namespace Tyuiu.BocharovaES.Sprint6.Task1.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_BES_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BES.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_BES.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_BES.Text = "";
                textBoxResult_BES.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_BES.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_BES.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0, 5:d}     |  {1, 5:f2}   | ", startStep, valueArray[i]);
                    textBoxResult_BES.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_BES.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_BES_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИИПб-25-1 Бочарова Екатерина Сергеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
