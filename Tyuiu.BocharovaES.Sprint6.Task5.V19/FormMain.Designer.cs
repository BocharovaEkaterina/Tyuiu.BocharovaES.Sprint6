namespace Tyuiu.BocharovaES.Sprint6.Task5.V19
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_BES = new Panel();
            buttonHelp_BES = new Button();
            buttonOpenFile_BES = new Button();
            buttonDone_BES = new Button();
            groupBoxTask_BES = new GroupBox();
            textBoxTask_BES = new TextBox();
            panelLeft_BES = new Panel();
            groupBoxOutput_BES = new GroupBox();
            dataGridViewResult_BES = new DataGridView();
            panelFill_BES = new Panel();
            chartFunction_BES = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelTop_BES.SuspendLayout();
            groupBoxTask_BES.SuspendLayout();
            panelLeft_BES.SuspendLayout();
            groupBoxOutput_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BES).BeginInit();
            panelFill_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BES).BeginInit();
            SuspendLayout();
            // 
            // panelTop_BES
            // 
            panelTop_BES.Controls.Add(buttonHelp_BES);
            panelTop_BES.Controls.Add(buttonOpenFile_BES);
            panelTop_BES.Controls.Add(buttonDone_BES);
            panelTop_BES.Controls.Add(groupBoxTask_BES);
            panelTop_BES.Dock = DockStyle.Top;
            panelTop_BES.Location = new Point(0, 0);
            panelTop_BES.Name = "panelTop_BES";
            panelTop_BES.Size = new Size(1112, 125);
            panelTop_BES.TabIndex = 0;
            // 
            // buttonHelp_BES
            // 
            buttonHelp_BES.BackColor = SystemColors.GradientInactiveCaption;
            buttonHelp_BES.Location = new Point(968, 28);
            buttonHelp_BES.Name = "buttonHelp_BES";
            buttonHelp_BES.Size = new Size(127, 87);
            buttonHelp_BES.TabIndex = 2;
            buttonHelp_BES.Text = "Справка";
            buttonHelp_BES.UseVisualStyleBackColor = false;
            buttonHelp_BES.Click += buttonHelp_BES_Click;
            // 
            // buttonOpenFile_BES
            // 
            buttonOpenFile_BES.BackColor = SystemColors.GradientInactiveCaption;
            buttonOpenFile_BES.Location = new Point(835, 29);
            buttonOpenFile_BES.Name = "buttonOpenFile_BES";
            buttonOpenFile_BES.Size = new Size(127, 86);
            buttonOpenFile_BES.TabIndex = 1;
            buttonOpenFile_BES.Text = "Открыть файл ";
            buttonOpenFile_BES.UseVisualStyleBackColor = false;
            buttonOpenFile_BES.Click += buttonOpenFile_BES_Click;
            // 
            // buttonDone_BES
            // 
            buttonDone_BES.BackColor = Color.PaleGreen;
            buttonDone_BES.Location = new Point(702, 28);
            buttonDone_BES.Name = "buttonDone_BES";
            buttonDone_BES.Size = new Size(127, 87);
            buttonDone_BES.TabIndex = 0;
            buttonDone_BES.Text = "Выполнить ";
            buttonDone_BES.UseVisualStyleBackColor = false;
            buttonDone_BES.Click += buttonDone_BES_Click;
            // 
            // groupBoxTask_BES
            // 
            groupBoxTask_BES.Controls.Add(textBoxTask_BES);
            groupBoxTask_BES.Location = new Point(3, 3);
            groupBoxTask_BES.Name = "groupBoxTask_BES";
            groupBoxTask_BES.Size = new Size(693, 119);
            groupBoxTask_BES.TabIndex = 0;
            groupBoxTask_BES.TabStop = false;
            groupBoxTask_BES.Text = "Условие:";
            // 
            // textBoxTask_BES
            // 
            textBoxTask_BES.Location = new Point(9, 26);
            textBoxTask_BES.Multiline = true;
            textBoxTask_BES.Name = "textBoxTask_BES";
            textBoxTask_BES.Size = new Size(678, 87);
            textBoxTask_BES.TabIndex = 0;
            textBoxTask_BES.Text = "Прочитать данные из файла InPutFileTask5V19.txt. \r\nВывести в dataGridView все элементы равные нулю.\\r\\nПостроить диаграмму по этим значениям.";
            // 
            // panelLeft_BES
            // 
            panelLeft_BES.Controls.Add(groupBoxOutput_BES);
            panelLeft_BES.Dock = DockStyle.Left;
            panelLeft_BES.Location = new Point(0, 125);
            panelLeft_BES.Name = "panelLeft_BES";
            panelLeft_BES.Size = new Size(250, 466);
            panelLeft_BES.TabIndex = 1;
            // 
            // groupBoxOutput_BES
            // 
            groupBoxOutput_BES.Controls.Add(dataGridViewResult_BES);
            groupBoxOutput_BES.Dock = DockStyle.Fill;
            groupBoxOutput_BES.Location = new Point(0, 0);
            groupBoxOutput_BES.Name = "groupBoxOutput_BES";
            groupBoxOutput_BES.Size = new Size(250, 466);
            groupBoxOutput_BES.TabIndex = 0;
            groupBoxOutput_BES.TabStop = false;
            groupBoxOutput_BES.Text = "groupBox1";
            // 
            // dataGridViewResult_BES
            // 
            dataGridViewResult_BES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_BES.Location = new Point(6, 26);
            dataGridViewResult_BES.Name = "dataGridViewResult_BES";
            dataGridViewResult_BES.RowHeadersVisible = false;
            dataGridViewResult_BES.RowHeadersWidth = 51;
            dataGridViewResult_BES.Size = new Size(238, 434);
            dataGridViewResult_BES.TabIndex = 0;
            // 
            // panelFill_BES
            // 
            panelFill_BES.Controls.Add(chartFunction_BES);
            panelFill_BES.Dock = DockStyle.Fill;
            panelFill_BES.Location = new Point(250, 125);
            panelFill_BES.Name = "panelFill_BES";
            panelFill_BES.Size = new Size(862, 466);
            panelFill_BES.TabIndex = 1;
            // 
            // chartFunction_BES
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_BES.ChartAreas.Add(chartArea1);
            chartFunction_BES.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_BES.Legends.Add(legend1);
            chartFunction_BES.Location = new Point(0, 0);
            chartFunction_BES.Name = "chartFunction_BES";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_BES.Series.Add(series1);
            chartFunction_BES.Size = new Size(862, 466);
            chartFunction_BES.TabIndex = 0;
            chartFunction_BES.Text = "chart1";
            chartFunction_BES.Click += chartFunction_BES_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(250, 125);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 466);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 591);
            Controls.Add(splitter1);
            Controls.Add(panelFill_BES);
            Controls.Add(panelLeft_BES);
            Controls.Add(panelTop_BES);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 19 | Бочарова Е.С.";
            panelTop_BES.ResumeLayout(false);
            groupBoxTask_BES.ResumeLayout(false);
            groupBoxTask_BES.PerformLayout();
            panelLeft_BES.ResumeLayout(false);
            groupBoxOutput_BES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BES).EndInit();
            panelFill_BES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_BES).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BES;
        private Panel panelLeft_BES;
        private Panel panelFill_BES;
        private Splitter splitter1;
        private GroupBox groupBoxTask_BES;
        private TextBox textBoxTask_BES;
        private GroupBox groupBoxOutput_BES;
        private DataGridView dataGridViewResult_BES;
        private Button buttonHelp_BES;
        private Button buttonOpenFile_BES;
        private Button buttonDone_BES;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BES;
    }
}
