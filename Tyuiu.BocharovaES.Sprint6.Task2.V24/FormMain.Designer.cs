namespace Tyuiu.BocharovaES.Sprint6.Task2.V24
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
            groupBoxTask_BES = new GroupBox();
            textBoxTask_BES = new TextBox();
            groupBoxInput_BES = new GroupBox();
            textBoxStopStep_BES = new TextBox();
            labelStopStep_BES = new TextBox();
            textBoxStartStep_BES = new TextBox();
            labelStartStep_BES = new TextBox();
            groupBoxResult_BES = new GroupBox();
            dataGridViewFunction_BES = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            chartFunction_BES = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxResult_BES = new TextBox();
            buttonHelp_BES = new Button();
            buttonDone_BES = new Button();
            groupBoxTask_BES.SuspendLayout();
            groupBoxInput_BES.SuspendLayout();
            groupBoxResult_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_BES).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BES).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_BES
            // 
            groupBoxTask_BES.Controls.Add(textBoxTask_BES);
            groupBoxTask_BES.Location = new Point(0, 0);
            groupBoxTask_BES.Name = "groupBoxTask_BES";
            groupBoxTask_BES.Size = new Size(583, 301);
            groupBoxTask_BES.TabIndex = 0;
            groupBoxTask_BES.TabStop = false;
            groupBoxTask_BES.Text = "Условие:";
            // 
            // textBoxTask_BES
            // 
            textBoxTask_BES.Location = new Point(6, 26);
            textBoxTask_BES.Multiline = true;
            textBoxTask_BES.Name = "textBoxTask_BES";
            textBoxTask_BES.Size = new Size(571, 269);
            textBoxTask_BES.TabIndex = 1;
            textBoxTask_BES.Text = "Протабулировать функцию sin(x) + (cos(x)+1)/(2-x) + 2x на заданном диапазоне. Результат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxInput_BES
            // 
            groupBoxInput_BES.Controls.Add(textBoxStopStep_BES);
            groupBoxInput_BES.Controls.Add(labelStopStep_BES);
            groupBoxInput_BES.Controls.Add(textBoxStartStep_BES);
            groupBoxInput_BES.Controls.Add(labelStartStep_BES);
            groupBoxInput_BES.Location = new Point(12, 313);
            groupBoxInput_BES.Name = "groupBoxInput_BES";
            groupBoxInput_BES.Size = new Size(317, 125);
            groupBoxInput_BES.TabIndex = 1;
            groupBoxInput_BES.TabStop = false;
            groupBoxInput_BES.Text = "Ввод данных";
            // 
            // textBoxStopStep_BES
            // 
            textBoxStopStep_BES.Location = new Point(167, 57);
            textBoxStopStep_BES.Multiline = true;
            textBoxStopStep_BES.Name = "textBoxStopStep_BES";
            textBoxStopStep_BES.Size = new Size(125, 46);
            textBoxStopStep_BES.TabIndex = 6;
            // 
            // labelStopStep_BES
            // 
            labelStopStep_BES.Location = new Point(158, 26);
            labelStopStep_BES.Multiline = true;
            labelStopStep_BES.Name = "labelStopStep_BES";
            labelStopStep_BES.Size = new Size(147, 93);
            labelStopStep_BES.TabIndex = 5;
            labelStopStep_BES.Text = "Конец шага:";
            // 
            // textBoxStartStep_BES
            // 
            textBoxStartStep_BES.Location = new Point(15, 57);
            textBoxStartStep_BES.Multiline = true;
            textBoxStartStep_BES.Name = "textBoxStartStep_BES";
            textBoxStartStep_BES.Size = new Size(125, 46);
            textBoxStartStep_BES.TabIndex = 4;
            // 
            // labelStartStep_BES
            // 
            labelStartStep_BES.Location = new Point(6, 26);
            labelStartStep_BES.Multiline = true;
            labelStartStep_BES.Name = "labelStartStep_BES";
            labelStartStep_BES.Size = new Size(146, 93);
            labelStartStep_BES.TabIndex = 3;
            labelStartStep_BES.Text = "Старт шага:";
            // 
            // groupBoxResult_BES
            // 
            groupBoxResult_BES.Controls.Add(dataGridViewFunction_BES);
            groupBoxResult_BES.Controls.Add(chartFunction_BES);
            groupBoxResult_BES.Controls.Add(textBoxResult_BES);
            groupBoxResult_BES.Location = new Point(589, 0);
            groupBoxResult_BES.Name = "groupBoxResult_BES";
            groupBoxResult_BES.Size = new Size(640, 438);
            groupBoxResult_BES.TabIndex = 2;
            groupBoxResult_BES.TabStop = false;
            groupBoxResult_BES.Text = "Выход данных";
            // 
            // dataGridViewFunction_BES
            // 
            dataGridViewFunction_BES.BackgroundColor = Color.White;
            dataGridViewFunction_BES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_BES.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridViewFunction_BES.Location = new Point(6, 58);
            dataGridViewFunction_BES.Name = "dataGridViewFunction_BES";
            dataGridViewFunction_BES.RowHeadersVisible = false;
            dataGridViewFunction_BES.RowHeadersWidth = 51;
            dataGridViewFunction_BES.Size = new Size(217, 374);
            dataGridViewFunction_BES.TabIndex = 3;
            dataGridViewFunction_BES.CellContentClick += dataGridViewFunction_BES_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 70;
            // 
            // F
            // 
            F.HeaderText = "F(X)";
            F.MinimumWidth = 6;
            F.Name = "F";
            F.ReadOnly = true;
            F.Width = 70;
            // 
            // chartFunction_BES
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_BES.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_BES.Legends.Add(legend1);
            chartFunction_BES.Location = new Point(229, 26);
            chartFunction_BES.Name = "chartFunction_BES";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_BES.Series.Add(series1);
            chartFunction_BES.Size = new Size(441, 406);
            chartFunction_BES.TabIndex = 2;
            chartFunction_BES.Click += chartFunction_BES_Click;
            // 
            // textBoxResult_BES
            // 
            textBoxResult_BES.Location = new Point(6, 26);
            textBoxResult_BES.Multiline = true;
            textBoxResult_BES.Name = "textBoxResult_BES";
            textBoxResult_BES.Size = new Size(217, 406);
            textBoxResult_BES.TabIndex = 0;
            textBoxResult_BES.Text = "Результат:";
            // 
            // buttonHelp_BES
            // 
            buttonHelp_BES.BackColor = Color.Blue;
            buttonHelp_BES.Location = new Point(335, 340);
            buttonHelp_BES.Name = "buttonHelp_BES";
            buttonHelp_BES.Size = new Size(85, 76);
            buttonHelp_BES.TabIndex = 3;
            buttonHelp_BES.Text = "Справка";
            buttonHelp_BES.UseVisualStyleBackColor = false;
            buttonHelp_BES.Click += buttonHelp_BES_Click;
            // 
            // buttonDone_BES
            // 
            buttonDone_BES.BackColor = Color.Green;
            buttonDone_BES.Location = new Point(440, 340);
            buttonDone_BES.Name = "buttonDone_BES";
            buttonDone_BES.Size = new Size(119, 76);
            buttonDone_BES.TabIndex = 4;
            buttonDone_BES.Text = "Выполнить ";
            buttonDone_BES.UseVisualStyleBackColor = false;
            buttonDone_BES.Click += buttonDone_BES_Click;
            buttonDone_BES.MouseDown += buttonDone_BES_MouseDown;
            buttonDone_BES.MouseEnter += buttonDone_BES_MouseEnter;
            buttonDone_BES.MouseLeave += buttonDone_BES_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 450);
            Controls.Add(buttonDone_BES);
            Controls.Add(buttonHelp_BES);
            Controls.Add(groupBoxResult_BES);
            Controls.Add(groupBoxInput_BES);
            Controls.Add(groupBoxTask_BES);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 24 | Бочарова Е.С.";
            groupBoxTask_BES.ResumeLayout(false);
            groupBoxTask_BES.PerformLayout();
            groupBoxInput_BES.ResumeLayout(false);
            groupBoxInput_BES.PerformLayout();
            groupBoxResult_BES.ResumeLayout(false);
            groupBoxResult_BES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_BES).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BES).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BES;
        private TextBox textBoxTask_BES;
        private GroupBox groupBoxInput_BES;
        private GroupBox groupBoxResult_BES;
        private TextBox textBoxStopStep_BES;
        private TextBox labelStopStep_BES;
        private TextBox textBoxStartStep_BES;
        private TextBox labelStartStep_BES;
        private TextBox textBoxResult_BES;
        private Button buttonHelp_BES;
        private Button buttonDone_BES;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BES;
        private DataGridView dataGridViewFunction_BES;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
    }
}
