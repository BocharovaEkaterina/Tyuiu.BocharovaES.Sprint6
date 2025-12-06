namespace Tyuiu.BocharovaES.Sprint6.Task1.V19
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
            groupBoxTask_BSE = new GroupBox();
            textBoxTask_BES = new TextBox();
            groupBoxInput_BES = new GroupBox();
            textBoxStopStep_BES = new TextBox();
            labelStopStep_BES = new TextBox();
            textBoxStartStep_BES = new TextBox();
            labelStartStep_BES = new TextBox();
            groupBoxResult_BES = new GroupBox();
            textBoxResult_BES = new TextBox();
            laberResult_BES = new TextBox();
            buttonHelp_BES = new Button();
            buttonDone_BES = new Button();
            groupBoxTask_BSE.SuspendLayout();
            groupBoxInput_BES.SuspendLayout();
            groupBoxResult_BES.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_BSE
            // 
            groupBoxTask_BSE.Controls.Add(textBoxTask_BES);
            groupBoxTask_BSE.Location = new Point(12, 12);
            groupBoxTask_BSE.Name = "groupBoxTask_BSE";
            groupBoxTask_BSE.Size = new Size(493, 292);
            groupBoxTask_BSE.TabIndex = 0;
            groupBoxTask_BSE.TabStop = false;
            groupBoxTask_BSE.Text = "Условие:";
            // 
            // textBoxTask_BES
            // 
            textBoxTask_BES.Location = new Point(3, 23);
            textBoxTask_BES.Multiline = true;
            textBoxTask_BES.Name = "textBoxTask_BES";
            textBoxTask_BES.Size = new Size(485, 263);
            textBoxTask_BES.TabIndex = 0;
            textBoxTask_BES.Text = "Протабулировать функцию cos(x) + cos(x)/(x+2)-3x на заданном диапазоне.\r\nРезультат вывости в виде таблице.";
            // 
            // groupBoxInput_BES
            // 
            groupBoxInput_BES.Controls.Add(textBoxStopStep_BES);
            groupBoxInput_BES.Controls.Add(labelStopStep_BES);
            groupBoxInput_BES.Controls.Add(textBoxStartStep_BES);
            groupBoxInput_BES.Controls.Add(labelStartStep_BES);
            groupBoxInput_BES.Location = new Point(12, 313);
            groupBoxInput_BES.Name = "groupBoxInput_BES";
            groupBoxInput_BES.Size = new Size(285, 125);
            groupBoxInput_BES.TabIndex = 1;
            groupBoxInput_BES.TabStop = false;
            groupBoxInput_BES.Text = "Ввод данных";
            // 
            // textBoxStopStep_BES
            // 
            textBoxStopStep_BES.Location = new Point(151, 59);
            textBoxStopStep_BES.Multiline = true;
            textBoxStopStep_BES.Name = "textBoxStopStep_BES";
            textBoxStopStep_BES.Size = new Size(110, 34);
            textBoxStopStep_BES.TabIndex = 3;
            // 
            // labelStopStep_BES
            // 
            labelStopStep_BES.Location = new Point(142, 26);
            labelStopStep_BES.Multiline = true;
            labelStopStep_BES.Name = "labelStopStep_BES";
            labelStopStep_BES.Size = new Size(128, 83);
            labelStopStep_BES.TabIndex = 2;
            labelStopStep_BES.Text = "Конец шага:";
            // 
            // textBoxStartStep_BES
            // 
            textBoxStartStep_BES.Location = new Point(17, 59);
            textBoxStartStep_BES.Multiline = true;
            textBoxStartStep_BES.Name = "textBoxStartStep_BES";
            textBoxStartStep_BES.Size = new Size(108, 34);
            textBoxStartStep_BES.TabIndex = 1;
            // 
            // labelStartStep_BES
            // 
            labelStartStep_BES.Location = new Point(6, 26);
            labelStartStep_BES.Multiline = true;
            labelStartStep_BES.Name = "labelStartStep_BES";
            labelStartStep_BES.Size = new Size(130, 83);
            labelStartStep_BES.TabIndex = 0;
            labelStartStep_BES.Text = "Старт шага:";
            // 
            // groupBoxResult_BES
            // 
            groupBoxResult_BES.Controls.Add(textBoxResult_BES);
            groupBoxResult_BES.Controls.Add(laberResult_BES);
            groupBoxResult_BES.Location = new Point(511, 12);
            groupBoxResult_BES.Name = "groupBoxResult_BES";
            groupBoxResult_BES.Size = new Size(277, 426);
            groupBoxResult_BES.TabIndex = 0;
            groupBoxResult_BES.TabStop = false;
            groupBoxResult_BES.Text = "Вывод данных";
            // 
            // textBoxResult_BES
            // 
            textBoxResult_BES.Font = new Font("Consolas", 10F);
            textBoxResult_BES.Location = new Point(6, 52);
            textBoxResult_BES.Multiline = true;
            textBoxResult_BES.Name = "textBoxResult_BES";
            textBoxResult_BES.ReadOnly = true;
            textBoxResult_BES.ScrollBars = ScrollBars.Vertical;
            textBoxResult_BES.Size = new Size(265, 368);
            textBoxResult_BES.TabIndex = 1;
            // 
            // laberResult_BES
            // 
            laberResult_BES.Location = new Point(6, 23);
            laberResult_BES.Multiline = true;
            laberResult_BES.Name = "laberResult_BES";
            laberResult_BES.Size = new Size(265, 397);
            laberResult_BES.TabIndex = 0;
            laberResult_BES.Text = "Результат:";
            // 
            // buttonHelp_BES
            // 
            buttonHelp_BES.BackColor = Color.LemonChiffon;
            buttonHelp_BES.Location = new Point(303, 341);
            buttonHelp_BES.Name = "buttonHelp_BES";
            buttonHelp_BES.Size = new Size(76, 81);
            buttonHelp_BES.TabIndex = 2;
            buttonHelp_BES.Text = "Справка";
            buttonHelp_BES.UseVisualStyleBackColor = false;
            buttonHelp_BES.Click += buttonHelp_BES_Click;
            // 
            // buttonDone_BES
            // 
            buttonDone_BES.BackColor = Color.PaleGreen;
            buttonDone_BES.Location = new Point(385, 339);
            buttonDone_BES.Name = "buttonDone_BES";
            buttonDone_BES.Size = new Size(115, 81);
            buttonDone_BES.TabIndex = 3;
            buttonDone_BES.Text = "Выполнить";
            buttonDone_BES.UseVisualStyleBackColor = false;
            buttonDone_BES.Click += buttonDone_BES_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_BES);
            Controls.Add(buttonHelp_BES);
            Controls.Add(groupBoxResult_BES);
            Controls.Add(groupBoxInput_BES);
            Controls.Add(groupBoxTask_BSE);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 19 | Бочарова Е.С.";
            groupBoxTask_BSE.ResumeLayout(false);
            groupBoxTask_BSE.PerformLayout();
            groupBoxInput_BES.ResumeLayout(false);
            groupBoxInput_BES.PerformLayout();
            groupBoxResult_BES.ResumeLayout(false);
            groupBoxResult_BES.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BSE;
        private GroupBox groupBoxInput_BES;
        private TextBox textBoxTask_BES;
        private GroupBox groupBoxResult_BES;
        private TextBox textBoxStartStep_BES;
        private TextBox labelStartStep_BES;
        private TextBox laberResult_BES;
        private TextBox labelStopStep_BES;
        private TextBox textBoxStopStep_BES;
        private TextBox textBoxResult_BES;
        private Button buttonHelp_BES;
        private Button buttonDone_BES;
    }
}
