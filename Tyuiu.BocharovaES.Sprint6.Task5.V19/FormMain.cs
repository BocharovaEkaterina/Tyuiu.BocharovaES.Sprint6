using Tyuiu.BocharovaES.Sprint6.Task5.V19.Lib;
namespace Tyuiu.BocharovaES.Sprint6.Task5.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutDataFileTask5V19.txt";

        private void buttonDone_BES_Click(object sender, EventArgs e)
        {
            dataGridViewResult_BES.ColumnCount = 2;
            dataGridViewResult_BES.Columns[0].Width = 20;
            dataGridViewResult_BES.Columns[1].Width = 50;

            this.chartFunction_BES.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_BES.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_BES.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult_BES.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartFunction_BES.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonOpenFile_BES_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_BES_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб-25-1 Бочарова Екатерина Сергеевна", "Сообщение", MessageBoxButtons.OK);
        }

        private void chartFunction_BES_Click(object sender, EventArgs e)
        {

        }
    }
}
