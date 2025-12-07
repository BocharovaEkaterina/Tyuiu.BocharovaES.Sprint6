using Tyuiu.BocharovaES.Sprint6.Task2.V24.Lib;
namespace Tyuiu.BocharovaES.Sprint6.Task2.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();




        private void chartFunction_BES_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_BES_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИИПб-25-1 Бочарова Екатерина Сергеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewFunction_BES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_BES_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_BES.BackColor = Color.Red;
        }

        private void buttonDone_BES_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_BES.BackColor = Color.Green;
        }

        private void buttonDone_BES_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_BES.BackColor = Color.Blue;
        }

        private void buttonDone_BES_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BES.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_BES.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_BES.Titles.Add("График функции (sin(x)-2x)/(3x-1)+sin(x)-3x+2");

                this.chartFunction_BES.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_BES.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_BES.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_BES.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
