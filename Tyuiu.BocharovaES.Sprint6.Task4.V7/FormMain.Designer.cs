namespace Tyuiu.BocharovaES.Sprint6.Task4.V7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_BES = new Panel();
            buttonSave_BES = new Button();
            buttonHelp_BES = new Button();
            buttonDone_BES = new Button();
            groupBoxInput_BES = new GroupBox();
            textBoxStopStep_BES = new TextBox();
            textBoxStartStep_BES = new TextBox();
            labelStopStep_BES = new TextBox();
            labelStartStep_BES = new TextBox();
            groupBoxTask_BES = new GroupBox();
            textBoxTask_BES = new TextBox();
            panelRigth_BES = new Panel();
            groupBoxOutput_BES = new GroupBox();
            textBoxResult_BES = new TextBox();
            panelLeft_BES = new Panel();
            chartFunction_BES = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button4 = new Button();
            splitterPanel_BES = new Splitter();
            panelTop_BES.SuspendLayout();
            groupBoxInput_BES.SuspendLayout();
            groupBoxTask_BES.SuspendLayout();
            panelRigth_BES.SuspendLayout();
            groupBoxOutput_BES.SuspendLayout();
            panelLeft_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BES).BeginInit();
            SuspendLayout();
            // 
            // panelTop_BES
            // 
            panelTop_BES.Controls.Add(buttonSave_BES);
            panelTop_BES.Controls.Add(buttonHelp_BES);
            panelTop_BES.Controls.Add(buttonDone_BES);
            panelTop_BES.Controls.Add(groupBoxInput_BES);
            panelTop_BES.Controls.Add(groupBoxTask_BES);
            panelTop_BES.Dock = DockStyle.Top;
            panelTop_BES.Location = new Point(0, 0);
            panelTop_BES.Name = "panelTop_BES";
            panelTop_BES.Size = new Size(1207, 141);
            panelTop_BES.TabIndex = 0;
            // 
            // buttonSave_BES
            // 
            buttonSave_BES.BackColor = SystemColors.GradientInactiveCaption;
            buttonSave_BES.Location = new Point(1008, 38);
            buttonSave_BES.Name = "buttonSave_BES";
            buttonSave_BES.Size = new Size(94, 91);
            buttonSave_BES.TabIndex = 3;
            buttonSave_BES.Text = "Сохранить ";
            buttonSave_BES.UseVisualStyleBackColor = false;
            buttonSave_BES.Click += buttonSave_BES_Click;
            // 
            // buttonHelp_BES
            // 
            buttonHelp_BES.BackColor = SystemColors.GradientInactiveCaption;
            buttonHelp_BES.Location = new Point(1106, 38);
            buttonHelp_BES.Name = "buttonHelp_BES";
            buttonHelp_BES.Size = new Size(94, 91);
            buttonHelp_BES.TabIndex = 4;
            buttonHelp_BES.Text = "Справка";
            buttonHelp_BES.UseVisualStyleBackColor = false;
            buttonHelp_BES.Click += buttonHelp_BES_Click;
            // 
            // buttonDone_BES
            // 
            buttonDone_BES.BackColor = Color.PaleGreen;
            buttonDone_BES.Location = new Point(904, 38);
            buttonDone_BES.Name = "buttonDone_BES";
            buttonDone_BES.Size = new Size(100, 91);
            buttonDone_BES.TabIndex = 2;
            buttonDone_BES.Text = "Выполнить";
            buttonDone_BES.UseVisualStyleBackColor = false;
            buttonDone_BES.Click += buttonDone_BES_Click;
            // 
            // groupBoxInput_BES
            // 
            groupBoxInput_BES.Controls.Add(textBoxStopStep_BES);
            groupBoxInput_BES.Controls.Add(textBoxStartStep_BES);
            groupBoxInput_BES.Controls.Add(labelStopStep_BES);
            groupBoxInput_BES.Controls.Add(labelStartStep_BES);
            groupBoxInput_BES.Location = new Point(600, 12);
            groupBoxInput_BES.Name = "groupBoxInput_BES";
            groupBoxInput_BES.Size = new Size(298, 123);
            groupBoxInput_BES.TabIndex = 1;
            groupBoxInput_BES.TabStop = false;
            groupBoxInput_BES.Text = "Ввод данных:";
            // 
            // textBoxStopStep_BES
            // 
            textBoxStopStep_BES.Location = new Point(155, 64);
            textBoxStopStep_BES.Multiline = true;
            textBoxStopStep_BES.Name = "textBoxStopStep_BES";
            textBoxStopStep_BES.Size = new Size(125, 34);
            textBoxStopStep_BES.TabIndex = 3;
            // 
            // textBoxStartStep_BES
            // 
            textBoxStartStep_BES.Location = new Point(11, 64);
            textBoxStartStep_BES.Multiline = true;
            textBoxStartStep_BES.Name = "textBoxStartStep_BES";
            textBoxStartStep_BES.Size = new Size(125, 34);
            textBoxStartStep_BES.TabIndex = 2;
            // 
            // labelStopStep_BES
            // 
            labelStopStep_BES.Location = new Point(148, 26);
            labelStopStep_BES.Multiline = true;
            labelStopStep_BES.Name = "labelStopStep_BES";
            labelStopStep_BES.Size = new Size(144, 91);
            labelStopStep_BES.TabIndex = 1;
            labelStopStep_BES.Text = "Конец шага:";
            // 
            // labelStartStep_BES
            // 
            labelStartStep_BES.Location = new Point(6, 26);
            labelStartStep_BES.Multiline = true;
            labelStartStep_BES.Name = "labelStartStep_BES";
            labelStartStep_BES.Size = new Size(136, 91);
            labelStartStep_BES.TabIndex = 0;
            labelStartStep_BES.Text = "Старт шага:";
            // 
            // groupBoxTask_BES
            // 
            groupBoxTask_BES.Controls.Add(textBoxTask_BES);
            groupBoxTask_BES.Location = new Point(6, 3);
            groupBoxTask_BES.Name = "groupBoxTask_BES";
            groupBoxTask_BES.Size = new Size(588, 132);
            groupBoxTask_BES.TabIndex = 0;
            groupBoxTask_BES.TabStop = false;
            groupBoxTask_BES.Text = "Условие:";
            // 
            // textBoxTask_BES
            // 
            textBoxTask_BES.Location = new Point(3, 26);
            textBoxTask_BES.Multiline = true;
            textBoxTask_BES.Name = "textBoxTask_BES";
            textBoxTask_BES.ReadOnly = true;
            textBoxTask_BES.Size = new Size(572, 87);
            textBoxTask_BES.TabIndex = 0;
            textBoxTask_BES.Text = resources.GetString("textBoxTask_BES.Text");
            // 
            // panelRigth_BES
            // 
            panelRigth_BES.Controls.Add(groupBoxOutput_BES);
            panelRigth_BES.Dock = DockStyle.Left;
            panelRigth_BES.Location = new Point(0, 141);
            panelRigth_BES.Name = "panelRigth_BES";
            panelRigth_BES.Size = new Size(194, 472);
            panelRigth_BES.TabIndex = 1;
            // 
            // groupBoxOutput_BES
            // 
            groupBoxOutput_BES.Controls.Add(textBoxResult_BES);
            groupBoxOutput_BES.Dock = DockStyle.Fill;
            groupBoxOutput_BES.Location = new Point(0, 0);
            groupBoxOutput_BES.Name = "groupBoxOutput_BES";
            groupBoxOutput_BES.Size = new Size(194, 472);
            groupBoxOutput_BES.TabIndex = 0;
            groupBoxOutput_BES.TabStop = false;
            groupBoxOutput_BES.Text = "Вывод:";
            // 
            // textBoxResult_BES
            // 
            textBoxResult_BES.Dock = DockStyle.Fill;
            textBoxResult_BES.Location = new Point(3, 23);
            textBoxResult_BES.Multiline = true;
            textBoxResult_BES.Name = "textBoxResult_BES";
            textBoxResult_BES.Size = new Size(188, 446);
            textBoxResult_BES.TabIndex = 0;
            // 
            // panelLeft_BES
            // 
            panelLeft_BES.Controls.Add(chartFunction_BES);
            panelLeft_BES.Controls.Add(button4);
            panelLeft_BES.Dock = DockStyle.Fill;
            panelLeft_BES.Location = new Point(194, 141);
            panelLeft_BES.Name = "panelLeft_BES";
            panelLeft_BES.Size = new Size(1013, 472);
            panelLeft_BES.TabIndex = 1;
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
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_BES.Series.Add(series1);
            chartFunction_BES.Size = new Size(1013, 472);
            chartFunction_BES.TabIndex = 1;
            chartFunction_BES.Text = "chart1";
            // 
            // button4
            // 
            button4.Location = new Point(420, 128);
            button4.Name = "button4";
            button4.Size = new Size(8, 8);
            button4.TabIndex = 0;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // splitterPanel_BES
            // 
            splitterPanel_BES.Location = new Point(194, 141);
            splitterPanel_BES.Name = "splitterPanel_BES";
            splitterPanel_BES.Size = new Size(4, 472);
            splitterPanel_BES.TabIndex = 2;
            splitterPanel_BES.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 613);
            Controls.Add(splitterPanel_BES);
            Controls.Add(panelLeft_BES);
            Controls.Add(panelRigth_BES);
            Controls.Add(panelTop_BES);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 7 | Бочарова Е.С.";
            panelTop_BES.ResumeLayout(false);
            groupBoxInput_BES.ResumeLayout(false);
            groupBoxInput_BES.PerformLayout();
            groupBoxTask_BES.ResumeLayout(false);
            groupBoxTask_BES.PerformLayout();
            panelRigth_BES.ResumeLayout(false);
            groupBoxOutput_BES.ResumeLayout(false);
            groupBoxOutput_BES.PerformLayout();
            panelLeft_BES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_BES).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BES;
        private Panel panelRigth_BES;
        private Panel panelLeft_BES;
        private Splitter splitterPanel_BES;
        private GroupBox groupBoxTask_BES;
        private GroupBox groupBoxOutput_BES;
        private TextBox textBoxTask_BES;
        private GroupBox groupBoxInput_BES;
        private TextBox textBoxResult_BES;
        private TextBox labelStopStep_BES;
        private TextBox labelStartStep_BES;
        private Button buttonSave_BES;
        private Button buttonHelp_BES;
        private Button buttonDone_BES;
        private TextBox textBoxStopStep_BES;
        private TextBox textBoxStartStep_BES;
        private Button button4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BES;
    }
}
