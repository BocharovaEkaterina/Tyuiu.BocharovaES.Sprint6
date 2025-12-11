using Tyuiu.BocharovaES.Sprint6.Task7.V26.Lib;
namespace Tyuiu.BocharovaES.Sprint6.Task7.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_BES.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_BES.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_BES_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BES.ShowDialog();
            openFilePath = openFileDialogTask_BES.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_BES.ColumnCount = columns;
            dataGridViewIn_BES.RowCount = rows;
            dataGridViewOut_BES.ColumnCount = columns;
            dataGridViewOut_BES.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_BES.Columns[i].Width = 40;
                dataGridViewOut_BES.Columns[i].Width = 40;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_BES.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_BES.Enabled = true;
        }

        private void buttonDone_BES_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_BES.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_BES.Enabled = true;
        }

        private void buttonSave_BES_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_BES.FileName = "OutPutFileTask7V26.csv";
            saveFileDialogMatrix_BES.InitialDirectory = @"C:\DataSprint6";
            saveFileDialogMatrix_BES.ShowDialog();

            string path = saveFileDialogMatrix_BES.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_BES.RowCount;
            int columns = dataGridViewOut_BES.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_BES.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_BES.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_BES.ColumnCount = 50;
            dataGridViewOut_BES.ColumnCount = 50;

            dataGridViewOut_BES.RowCount = 50;
            dataGridViewIn_BES.RowCount = 50;

            panelInput_BES.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_BES.Columns[i].Width = 25;
                dataGridViewOut_BES.Columns[i].Width = 25;
            }
        }
        private void buttonOpenFile_VVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BES.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_VVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BES.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_VVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BES.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_VVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BES.ToolTipTitle = "Справка";
        }

        private void buttonHelp_BES_Click(object sender, EventArgs e)
        {
            FormAbout FormAbout = new FormAbout();
            FormAbout.ShowDialog();
        }
    }
}
