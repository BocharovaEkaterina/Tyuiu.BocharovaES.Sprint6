namespace Tyuiu.BocharovaES.Sprint6.Task6.V6
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
            panelTop_BES = new Panel();
            buttonHelp_BES = new Button();
            buttonDone_BES = new Button();
            buttonOpenFile_BES = new Button();
            groupBoxTask_BES = new GroupBox();
            textBoxTask_BES = new TextBox();
            panelLeft_BES = new Panel();
            groupBoxInput_BES = new GroupBox();
            textBoxIn_BES = new TextBox();
            panelFill_BES = new Panel();
            groupBoxOutput_BES = new GroupBox();
            textBoxResult_BES = new TextBox();
            splitterTask_BES = new Splitter();
            openFileDialogTask_BES = new OpenFileDialog();
            toolTipTask_BES = new ToolTip(components);
            panelTop_BES.SuspendLayout();
            groupBoxTask_BES.SuspendLayout();
            panelLeft_BES.SuspendLayout();
            groupBoxInput_BES.SuspendLayout();
            panelFill_BES.SuspendLayout();
            groupBoxOutput_BES.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_BES
            // 
            panelTop_BES.Controls.Add(buttonHelp_BES);
            panelTop_BES.Controls.Add(buttonDone_BES);
            panelTop_BES.Controls.Add(buttonOpenFile_BES);
            panelTop_BES.Controls.Add(groupBoxTask_BES);
            panelTop_BES.Dock = DockStyle.Top;
            panelTop_BES.Location = new Point(0, 0);
            panelTop_BES.Name = "panelTop_BES";
            panelTop_BES.Size = new Size(1117, 209);
            panelTop_BES.TabIndex = 0;
            // 
            // buttonHelp_BES
            // 
            buttonHelp_BES.Image = Properties.Resources.help;
            buttonHelp_BES.Location = new Point(987, 12);
            buttonHelp_BES.Name = "buttonHelp_BES";
            buttonHelp_BES.Size = new Size(118, 83);
            buttonHelp_BES.TabIndex = 3;
            toolTipTask_BES.SetToolTip(buttonHelp_BES, "Сведения о программе");
            buttonHelp_BES.UseVisualStyleBackColor = true;
            buttonHelp_BES.Click += buttonHelp_BES_Click;
            // 
            // buttonDone_BES
            // 
            buttonDone_BES.Enabled = false;
            buttonDone_BES.FlatStyle = FlatStyle.Flat;
            buttonDone_BES.Image = Properties.Resources.application_go;
            buttonDone_BES.Location = new Point(127, 12);
            buttonDone_BES.Name = "buttonDone_BES";
            buttonDone_BES.Size = new Size(111, 83);
            buttonDone_BES.TabIndex = 2;
            toolTipTask_BES.SetToolTip(buttonDone_BES, "Производит поиск в файле слов, \r\nв которых встречается буквы \r\nвыводит их в результирующую строку");
            buttonDone_BES.UseVisualStyleBackColor = true;
            buttonDone_BES.Click += buttonDone_BES_Click;
            // 
            // buttonOpenFile_BES
            // 
            buttonOpenFile_BES.Image = Properties.Resources.folder_page_white;
            buttonOpenFile_BES.Location = new Point(12, 12);
            buttonOpenFile_BES.Name = "buttonOpenFile_BES";
            buttonOpenFile_BES.Size = new Size(109, 83);
            buttonOpenFile_BES.TabIndex = 1;
            toolTipTask_BES.SetToolTip(buttonOpenFile_BES, "Открыть файл\r\nВыберите нужный файл для обработки.\r\n");
            buttonOpenFile_BES.UseVisualStyleBackColor = true;
            buttonOpenFile_BES.Click += buttonOpenFile_BES_Click;
            // 
            // groupBoxTask_BES
            // 
            groupBoxTask_BES.Controls.Add(textBoxTask_BES);
            groupBoxTask_BES.Location = new Point(3, 101);
            groupBoxTask_BES.Name = "groupBoxTask_BES";
            groupBoxTask_BES.Size = new Size(763, 102);
            groupBoxTask_BES.TabIndex = 0;
            groupBoxTask_BES.TabStop = false;
            groupBoxTask_BES.Text = "Условие:";
            // 
            // textBoxTask_BES
            // 
            textBoxTask_BES.BackColor = Color.White;
            textBoxTask_BES.Location = new Point(6, 18);
            textBoxTask_BES.Multiline = true;
            textBoxTask_BES.Name = "textBoxTask_BES";
            textBoxTask_BES.ReadOnly = true;
            textBoxTask_BES.Size = new Size(751, 78);
            textBoxTask_BES.TabIndex = 0;
            textBoxTask_BES.Text = resources.GetString("textBoxTask_BES.Text");
            // 
            // panelLeft_BES
            // 
            panelLeft_BES.Controls.Add(groupBoxInput_BES);
            panelLeft_BES.Dock = DockStyle.Left;
            panelLeft_BES.Location = new Point(0, 209);
            panelLeft_BES.Name = "panelLeft_BES";
            panelLeft_BES.Size = new Size(244, 384);
            panelLeft_BES.TabIndex = 1;
            // 
            // groupBoxInput_BES
            // 
            groupBoxInput_BES.Controls.Add(textBoxIn_BES);
            groupBoxInput_BES.Dock = DockStyle.Fill;
            groupBoxInput_BES.Location = new Point(0, 0);
            groupBoxInput_BES.Name = "groupBoxInput_BES";
            groupBoxInput_BES.Size = new Size(244, 384);
            groupBoxInput_BES.TabIndex = 1;
            groupBoxInput_BES.TabStop = false;
            groupBoxInput_BES.Text = "Ввод:";
            // 
            // textBoxIn_BES
            // 
            textBoxIn_BES.BackColor = Color.White;
            textBoxIn_BES.Location = new Point(9, 26);
            textBoxIn_BES.Multiline = true;
            textBoxIn_BES.Name = "textBoxIn_BES";
            textBoxIn_BES.ReadOnly = true;
            textBoxIn_BES.ScrollBars = ScrollBars.Vertical;
            textBoxIn_BES.Size = new Size(229, 352);
            textBoxIn_BES.TabIndex = 1;
            // 
            // panelFill_BES
            // 
            panelFill_BES.Controls.Add(groupBoxOutput_BES);
            panelFill_BES.Dock = DockStyle.Fill;
            panelFill_BES.Location = new Point(244, 209);
            panelFill_BES.Name = "panelFill_BES";
            panelFill_BES.Size = new Size(873, 384);
            panelFill_BES.TabIndex = 1;
            // 
            // groupBoxOutput_BES
            // 
            groupBoxOutput_BES.Controls.Add(textBoxResult_BES);
            groupBoxOutput_BES.Dock = DockStyle.Fill;
            groupBoxOutput_BES.Location = new Point(0, 0);
            groupBoxOutput_BES.Name = "groupBoxOutput_BES";
            groupBoxOutput_BES.Size = new Size(873, 384);
            groupBoxOutput_BES.TabIndex = 1;
            groupBoxOutput_BES.TabStop = false;
            groupBoxOutput_BES.Text = "Вывод данных:";
            // 
            // textBoxResult_BES
            // 
            textBoxResult_BES.BackColor = Color.White;
            textBoxResult_BES.Location = new Point(16, 26);
            textBoxResult_BES.Multiline = true;
            textBoxResult_BES.Name = "textBoxResult_BES";
            textBoxResult_BES.ReadOnly = true;
            textBoxResult_BES.Size = new Size(851, 352);
            textBoxResult_BES.TabIndex = 2;
            // 
            // splitterTask_BES
            // 
            splitterTask_BES.Location = new Point(244, 209);
            splitterTask_BES.Name = "splitterTask_BES";
            splitterTask_BES.Size = new Size(4, 384);
            splitterTask_BES.TabIndex = 2;
            splitterTask_BES.TabStop = false;
            // 
            // openFileDialogTask_BES
            // 
            openFileDialogTask_BES.FileName = "InPutDataFileTask6V6.txt";
            // 
            // toolTipTask_BES
            // 
            toolTipTask_BES.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask_BES.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 593);
            Controls.Add(splitterTask_BES);
            Controls.Add(panelFill_BES);
            Controls.Add(panelLeft_BES);
            Controls.Add(panelTop_BES);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 6 | Бочарова Е.С.";
            panelTop_BES.ResumeLayout(false);
            groupBoxTask_BES.ResumeLayout(false);
            groupBoxTask_BES.PerformLayout();
            panelLeft_BES.ResumeLayout(false);
            groupBoxInput_BES.ResumeLayout(false);
            groupBoxInput_BES.PerformLayout();
            panelFill_BES.ResumeLayout(false);
            groupBoxOutput_BES.ResumeLayout(false);
            groupBoxOutput_BES.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BES;
        private Panel panelLeft_BES;
        private Panel panelFill_BES;
        private Splitter splitterTask_BES;
        private GroupBox groupBoxTask_BES;
        private GroupBox groupBoxInput_BES;
        private GroupBox groupBoxOutput_BES;
        private TextBox textBoxTask_BES;
        private TextBox textBoxIn_BES;
        private TextBox textBoxResult_BES;
        private Button buttonOpenFile_BES;
        private Button buttonHelp_BES;
        private Button buttonDone_BES;
        private OpenFileDialog openFileDialogTask_BES;
        private ToolTip toolTipTask_BES;
    }
}
