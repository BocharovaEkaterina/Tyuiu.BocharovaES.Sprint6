using Tyuiu.BocharovaES.Sprint6.Task3.V4.Lib;
namespace Tyuiu.BocharovaES.Sprint6.Task3.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -14, -7, 18, 12, -20 },
                                       { -2, -15, -19, -19, -3 },
                                       { -18, -5, -10, 14, -17 },
                                       { -1, 2, -10, 0, 11 },
                                       { 6, -18, 0, 19, 16 } };
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_BES.ColumnCount = columns;
            dataGridViewMatrix_BES.RowCount = rows;
            dataGridViewResult_BES.ColumnCount = columns;
            dataGridViewResult_BES.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_BES.Columns[i].Width = 50;
                dataGridViewResult_BES.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_BES.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

        }
        private void buttonDone_BES_Click(object sender, EventArgs e)
        {
            int[,] result_matrix = ds.Calculate(mtrx);

            int rows = result_matrix.GetUpperBound(0) + 1;
            int columns = result_matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_BES.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

        }

        private void buttonHelp_BES_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИИПб-25-1 Бочарова Екатерина Сергеевна", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
