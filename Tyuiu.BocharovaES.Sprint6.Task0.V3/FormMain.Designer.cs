namespace Tyuiu.BocharovaES.Sprint6.Task0.V3
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
            groupBoxTask_BES = new GroupBox();
            textBoxTask_BES = new TextBox();
            groupBoxInput_BES = new GroupBox();
            textBoxVarX_BES = new TextBox();
            laberVarX_BES = new TextBox();
            groupBoxOutput_BES = new GroupBox();
            textBoxResult_BES = new TextBox();
            labelResult_BES = new TextBox();
            pictureBox_BES = new PictureBox();
            buttonDone_BES = new Button();
            buttonHelp_BES = new Button();
            groupBoxTask_BES.SuspendLayout();
            groupBoxInput_BES.SuspendLayout();
            groupBoxOutput_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_BES).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_BES
            // 
            groupBoxTask_BES.Controls.Add(textBoxTask_BES);
            groupBoxTask_BES.Location = new Point(12, 12);
            groupBoxTask_BES.Name = "groupBoxTask_BES";
            groupBoxTask_BES.Size = new Size(506, 216);
            groupBoxTask_BES.TabIndex = 0;
            groupBoxTask_BES.TabStop = false;
            groupBoxTask_BES.Text = "Условие:";
            // 
            // textBoxTask_BES
            // 
            textBoxTask_BES.Location = new Point(6, 26);
            textBoxTask_BES.Multiline = true;
            textBoxTask_BES.Name = "textBoxTask_BES";
            textBoxTask_BES.Size = new Size(482, 184);
            textBoxTask_BES.TabIndex = 0;
            textBoxTask_BES.Text = "Вычислить выражение по формуле:";
            // 
            // groupBoxInput_BES
            // 
            groupBoxInput_BES.Controls.Add(textBoxVarX_BES);
            groupBoxInput_BES.Controls.Add(laberVarX_BES);
            groupBoxInput_BES.Location = new Point(18, 290);
            groupBoxInput_BES.Name = "groupBoxInput_BES";
            groupBoxInput_BES.Size = new Size(218, 91);
            groupBoxInput_BES.TabIndex = 0;
            groupBoxInput_BES.TabStop = false;
            groupBoxInput_BES.Text = "Ввод данных";
            // 
            // textBoxVarX_BES
            // 
            textBoxVarX_BES.Location = new Point(6, 47);
            textBoxVarX_BES.Multiline = true;
            textBoxVarX_BES.Name = "textBoxVarX_BES";
            textBoxVarX_BES.Size = new Size(206, 38);
            textBoxVarX_BES.TabIndex = 1;
            textBoxVarX_BES.KeyPress += textBoxVarX_KeyPress;
            // 
            // laberVarX_BES
            // 
            laberVarX_BES.Location = new Point(6, 20);
            laberVarX_BES.Multiline = true;
            laberVarX_BES.Name = "laberVarX_BES";
            laberVarX_BES.Size = new Size(206, 65);
            laberVarX_BES.TabIndex = 1;
            laberVarX_BES.Text = "Переменная X:";
            // 
            // groupBoxOutput_BES
            // 
            groupBoxOutput_BES.Controls.Add(textBoxResult_BES);
            groupBoxOutput_BES.Controls.Add(labelResult_BES);
            groupBoxOutput_BES.Location = new Point(370, 290);
            groupBoxOutput_BES.Name = "groupBoxOutput_BES";
            groupBoxOutput_BES.Size = new Size(230, 91);
            groupBoxOutput_BES.TabIndex = 0;
            groupBoxOutput_BES.TabStop = false;
            groupBoxOutput_BES.Text = "Вывод данных";
            // 
            // textBoxResult_BES
            // 
            textBoxResult_BES.Location = new Point(6, 47);
            textBoxResult_BES.Multiline = true;
            textBoxResult_BES.Name = "textBoxResult_BES";
            textBoxResult_BES.ReadOnly = true;
            textBoxResult_BES.Size = new Size(218, 38);
            textBoxResult_BES.TabIndex = 0;
            // 
            // labelResult_BES
            // 
            labelResult_BES.Location = new Point(6, 20);
            labelResult_BES.Multiline = true;
            labelResult_BES.Name = "labelResult_BES";
            labelResult_BES.Size = new Size(218, 65);
            labelResult_BES.TabIndex = 2;
            labelResult_BES.Text = "Результат:";
            // 
            // pictureBox_BES
            // 
            pictureBox_BES.Image = Properties.Resources.Task0;
            pictureBox_BES.Location = new Point(554, 38);
            pictureBox_BES.Name = "pictureBox_BES";
            pictureBox_BES.Size = new Size(188, 111);
            pictureBox_BES.TabIndex = 1;
            pictureBox_BES.TabStop = false;
            pictureBox_BES.Click += pictureBox_BES_Click;
            // 
            // buttonDone_BES
            // 
            buttonDone_BES.Location = new Point(615, 383);
            buttonDone_BES.Name = "buttonDone_BES";
            buttonDone_BES.Size = new Size(163, 55);
            buttonDone_BES.TabIndex = 2;
            buttonDone_BES.Text = "Выполнить";
            buttonDone_BES.UseVisualStyleBackColor = true;
            buttonDone_BES.Click += buttonDone_BES_Click;
            // 
            // buttonHelp_BES
            // 
            buttonHelp_BES.FlatStyle = FlatStyle.Flat;
            buttonHelp_BES.Location = new Point(554, 389);
            buttonHelp_BES.Name = "buttonHelp_BES";
            buttonHelp_BES.Size = new Size(46, 42);
            buttonHelp_BES.TabIndex = 3;
            buttonHelp_BES.Text = "?";
            buttonHelp_BES.UseVisualStyleBackColor = true;
            buttonHelp_BES.Click += buttonHelp_BES_Click;
            // 
            // FormMain
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 450);
            Controls.Add(buttonHelp_BES);
            Controls.Add(buttonDone_BES);
            Controls.Add(pictureBox_BES);
            Controls.Add(groupBoxOutput_BES);
            Controls.Add(groupBoxInput_BES);
            Controls.Add(groupBoxTask_BES);
            ForeColor = SystemColors.ControlText;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 3 | Бочарова Е.С. ";
            groupBoxTask_BES.ResumeLayout(false);
            groupBoxTask_BES.PerformLayout();
            groupBoxInput_BES.ResumeLayout(false);
            groupBoxInput_BES.PerformLayout();
            groupBoxOutput_BES.ResumeLayout(false);
            groupBoxOutput_BES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_BES).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BES;
        private GroupBox groupBoxInput_BES;
        private GroupBox groupBoxOutput_BES;
        private TextBox textBoxTask_BES;
        private TextBox laberVarX_BES;
        private TextBox textBoxResult_BES;
        private TextBox labelResult_BES;
        private TextBox textBoxVarX_BES;
        private PictureBox pictureBox_BES;
        private Button buttonDone_BES;
        private Button buttonHelp_BES;
    }
}
