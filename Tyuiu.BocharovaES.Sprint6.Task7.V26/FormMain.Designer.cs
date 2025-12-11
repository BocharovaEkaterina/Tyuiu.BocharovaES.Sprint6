namespace Tyuiu.BocharovaES.Sprint6.Task7.V26
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButton_BES = new Panel();
            buttonHelp_BES = new Button();
            buttonDone_BES = new Button();
            buttonSave_BES = new Button();
            buttonOpenFile_BES = new Button();
            panelTask_BES = new Panel();
            groupBoxTask_BES = new GroupBox();
            textBox1 = new TextBox();
            panelInput_BES = new Panel();
            groupBoxInput_BES = new GroupBox();
            dataGridViewIn_BES = new DataGridView();
            splitter_BES = new Splitter();
            openFileDialogTask_BES = new OpenFileDialog();
            toolTipButton_BES = new ToolTip(components);
            saveFileDialogMatrix_BES = new SaveFileDialog();
            panelResult_BES = new Panel();
            groupBoxResult_BES = new GroupBox();
            dataGridViewOut_BES = new DataGridView();
            panelButton_BES.SuspendLayout();
            panelTask_BES.SuspendLayout();
            groupBoxTask_BES.SuspendLayout();
            panelInput_BES.SuspendLayout();
            groupBoxInput_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_BES).BeginInit();
            panelResult_BES.SuspendLayout();
            groupBoxResult_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_BES).BeginInit();
            SuspendLayout();
            // 
            // panelButton_BES
            // 
            panelButton_BES.Controls.Add(buttonHelp_BES);
            panelButton_BES.Controls.Add(buttonDone_BES);
            panelButton_BES.Controls.Add(buttonSave_BES);
            panelButton_BES.Controls.Add(buttonOpenFile_BES);
            panelButton_BES.Dock = DockStyle.Top;
            panelButton_BES.Location = new Point(0, 0);
            panelButton_BES.Name = "panelButton_BES";
            panelButton_BES.Size = new Size(1000, 91);
            panelButton_BES.TabIndex = 0;
            // 
            // buttonHelp_BES
            // 
            buttonHelp_BES.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BES.FlatStyle = FlatStyle.Flat;
            buttonHelp_BES.Image = Properties.Resources.help;
            buttonHelp_BES.Location = new Point(891, 12);
            buttonHelp_BES.Name = "buttonHelp_BES";
            buttonHelp_BES.Size = new Size(97, 73);
            buttonHelp_BES.TabIndex = 3;
            toolTipButton_BES.SetToolTip(buttonHelp_BES, "О программе");
            buttonHelp_BES.UseVisualStyleBackColor = true;
            buttonHelp_BES.Click += buttonHelp_BES_Click;
            buttonHelp_BES.MouseEnter += buttonHelp_VVV_MouseEnter;
            // 
            // buttonDone_BES
            // 
            buttonDone_BES.Enabled = false;
            buttonDone_BES.FlatStyle = FlatStyle.Flat;
            buttonDone_BES.Image = Properties.Resources.application_go;
            buttonDone_BES.Location = new Point(115, 12);
            buttonDone_BES.Name = "buttonDone_BES";
            buttonDone_BES.Size = new Size(97, 73);
            buttonDone_BES.TabIndex = 1;
            toolTipButton_BES.SetToolTip(buttonDone_BES, "Выполнить обработку данных");
            buttonDone_BES.UseVisualStyleBackColor = true;
            buttonDone_BES.Click += buttonDone_BES_Click;
            buttonDone_BES.MouseEnter += buttonDone_VVV_MouseEnter;
            // 
            // buttonSave_BES
            // 
            buttonSave_BES.Enabled = false;
            buttonSave_BES.FlatStyle = FlatStyle.Flat;
            buttonSave_BES.Image = Properties.Resources.page_save;
            buttonSave_BES.Location = new Point(218, 12);
            buttonSave_BES.Name = "buttonSave_BES";
            buttonSave_BES.Size = new Size(97, 73);
            buttonSave_BES.TabIndex = 2;
            toolTipButton_BES.SetToolTip(buttonSave_BES, "Сохранить обработанные данные в файл в формате CSV");
            buttonSave_BES.UseVisualStyleBackColor = true;
            buttonSave_BES.Click += buttonSave_BES_Click;
            buttonSave_BES.MouseEnter += buttonSaveFile_VVV_MouseEnter;
            // 
            // buttonOpenFile_BES
            // 
            buttonOpenFile_BES.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_BES.Image = Properties.Resources.folder_page_white;
            buttonOpenFile_BES.Location = new Point(12, 12);
            buttonOpenFile_BES.Name = "buttonOpenFile_BES";
            buttonOpenFile_BES.Size = new Size(97, 73);
            buttonOpenFile_BES.TabIndex = 0;
            toolTipButton_BES.SetToolTip(buttonOpenFile_BES, "Открыть файл для обработки данных в формате");
            buttonOpenFile_BES.UseVisualStyleBackColor = true;
            buttonOpenFile_BES.Click += buttonOpenFile_BES_Click;
            buttonOpenFile_BES.MouseEnter += buttonOpenFile_VVV_MouseEnter;
            // 
            // panelTask_BES
            // 
            panelTask_BES.Controls.Add(groupBoxTask_BES);
            panelTask_BES.Dock = DockStyle.Top;
            panelTask_BES.Location = new Point(0, 91);
            panelTask_BES.Name = "panelTask_BES";
            panelTask_BES.Size = new Size(1000, 115);
            panelTask_BES.TabIndex = 1;
            // 
            // groupBoxTask_BES
            // 
            groupBoxTask_BES.Controls.Add(textBox1);
            groupBoxTask_BES.Dock = DockStyle.Fill;
            groupBoxTask_BES.Location = new Point(0, 0);
            groupBoxTask_BES.Name = "groupBoxTask_BES";
            groupBoxTask_BES.Size = new Size(1000, 115);
            groupBoxTask_BES.TabIndex = 0;
            groupBoxTask_BES.TabStop = false;
            groupBoxTask_BES.Text = "Условие: ";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(994, 89);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelInput_BES
            // 
            panelInput_BES.Controls.Add(groupBoxInput_BES);
            panelInput_BES.Dock = DockStyle.Left;
            panelInput_BES.Location = new Point(0, 206);
            panelInput_BES.Name = "panelInput_BES";
            panelInput_BES.Size = new Size(454, 293);
            panelInput_BES.TabIndex = 3;
            // 
            // groupBoxInput_BES
            // 
            groupBoxInput_BES.Controls.Add(dataGridViewIn_BES);
            groupBoxInput_BES.Dock = DockStyle.Fill;
            groupBoxInput_BES.Location = new Point(0, 0);
            groupBoxInput_BES.Name = "groupBoxInput_BES";
            groupBoxInput_BES.Size = new Size(454, 293);
            groupBoxInput_BES.TabIndex = 0;
            groupBoxInput_BES.TabStop = false;
            groupBoxInput_BES.Text = "Ввод данных:";
            // 
            // dataGridViewIn_BES
            // 
            dataGridViewIn_BES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_BES.Dock = DockStyle.Fill;
            dataGridViewIn_BES.Location = new Point(3, 23);
            dataGridViewIn_BES.Name = "dataGridViewIn_BES";
            dataGridViewIn_BES.ReadOnly = true;
            dataGridViewIn_BES.RowHeadersVisible = false;
            dataGridViewIn_BES.RowHeadersWidth = 51;
            dataGridViewIn_BES.Size = new Size(448, 267);
            dataGridViewIn_BES.TabIndex = 0;
            // 
            // splitter_BES
            // 
            splitter_BES.Location = new Point(454, 206);
            splitter_BES.Name = "splitter_BES";
            splitter_BES.Size = new Size(4, 293);
            splitter_BES.TabIndex = 4;
            splitter_BES.TabStop = false;
            // 
            // openFileDialogTask_BES
            // 
            openFileDialogTask_BES.FileName = "InPutDataFileTask7V26.csv";
            // 
            // toolTipButton_BES
            // 
            toolTipButton_BES.IsBalloon = true;
            toolTipButton_BES.ToolTipIcon = ToolTipIcon.Info;
            // 
            // panelResult_BES
            // 
            panelResult_BES.Controls.Add(groupBoxResult_BES);
            panelResult_BES.Dock = DockStyle.Fill;
            panelResult_BES.Location = new Point(458, 206);
            panelResult_BES.Name = "panelResult_BES";
            panelResult_BES.Size = new Size(542, 293);
            panelResult_BES.TabIndex = 5;
            // 
            // groupBoxResult_BES
            // 
            groupBoxResult_BES.Controls.Add(dataGridViewOut_BES);
            groupBoxResult_BES.Dock = DockStyle.Fill;
            groupBoxResult_BES.Location = new Point(0, 0);
            groupBoxResult_BES.Name = "groupBoxResult_BES";
            groupBoxResult_BES.Size = new Size(542, 293);
            groupBoxResult_BES.TabIndex = 0;
            groupBoxResult_BES.TabStop = false;
            groupBoxResult_BES.Text = "Вывод данных:";
            // 
            // dataGridViewOut_BES
            // 
            dataGridViewOut_BES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_BES.Dock = DockStyle.Fill;
            dataGridViewOut_BES.Location = new Point(3, 23);
            dataGridViewOut_BES.Name = "dataGridViewOut_BES";
            dataGridViewOut_BES.ReadOnly = true;
            dataGridViewOut_BES.RowHeadersVisible = false;
            dataGridViewOut_BES.RowHeadersWidth = 51;
            dataGridViewOut_BES.Size = new Size(536, 267);
            dataGridViewOut_BES.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 499);
            Controls.Add(panelResult_BES);
            Controls.Add(splitter_BES);
            Controls.Add(panelInput_BES);
            Controls.Add(panelTask_BES);
            Controls.Add(panelButton_BES);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 26 | Бочарова Е.С.";
            Load += FormMain_Load;
            panelButton_BES.ResumeLayout(false);
            panelTask_BES.ResumeLayout(false);
            groupBoxTask_BES.ResumeLayout(false);
            groupBoxTask_BES.PerformLayout();
            panelInput_BES.ResumeLayout(false);
            groupBoxInput_BES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_BES).EndInit();
            panelResult_BES.ResumeLayout(false);
            groupBoxResult_BES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_BES).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButton_BES;
        private Panel panelTask_BES;
        private Panel panelResult_RES;
        private Panel panelInput_BES;
        private Splitter splitter_BES;
        private GroupBox groupBoxTask_BES;
        private TextBox textBox1;
        private GroupBox groupBoxInput_BES;
        private Button buttonSave_BES;
        private Button buttonDone_BES;
        private Button buttonOpenFile_BES;
        private Button buttonHelp_BES;
        private DataGridView dataGridViewOut_BES;
        private DataGridView dataGridViewIn_BES;
        private GroupBox groupBoxOut_BES;
        private OpenFileDialog openFileDialogTask_BES;
        private ToolTip toolTipButton_BES;
        private SaveFileDialog saveFileDialogMatrix_BES;
        private Panel panelResult_BES;
        private GroupBox groupBoxResult_BES;
    }
}
