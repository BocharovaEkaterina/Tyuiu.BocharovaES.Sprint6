namespace Tyuiu.BocharovaES.Sprint6.Task3.V4
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
            groupBoxData_BES = new GroupBox();
            dataGridViewMatrix_BES = new DataGridView();
            textBoxData_BES = new TextBox();
            groupBoxResult_BES = new GroupBox();
            dataGridViewResult_BES = new DataGridView();
            labelResult_BES = new TextBox();
            buttonHelp_BES = new Button();
            buttonDone_BES = new Button();
            groupBoxData_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_BES).BeginInit();
            groupBoxResult_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BES).BeginInit();
            SuspendLayout();
            // 
            // groupBoxData_BES
            // 
            groupBoxData_BES.Controls.Add(dataGridViewMatrix_BES);
            groupBoxData_BES.Controls.Add(textBoxData_BES);
            groupBoxData_BES.Location = new Point(12, 12);
            groupBoxData_BES.Name = "groupBoxData_BES";
            groupBoxData_BES.Size = new Size(588, 466);
            groupBoxData_BES.TabIndex = 0;
            groupBoxData_BES.TabStop = false;
            groupBoxData_BES.Text = "Условие:";
            // 
            // dataGridViewMatrix_BES
            // 
            dataGridViewMatrix_BES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_BES.Location = new Point(271, 26);
            dataGridViewMatrix_BES.Name = "dataGridViewMatrix_BES";
            dataGridViewMatrix_BES.ReadOnly = true;
            dataGridViewMatrix_BES.RowHeadersVisible = false;
            dataGridViewMatrix_BES.RowHeadersWidth = 51;
            dataGridViewMatrix_BES.Size = new Size(303, 434);
            dataGridViewMatrix_BES.TabIndex = 2;
            // 
            // textBoxData_BES
            // 
            textBoxData_BES.Location = new Point(6, 26);
            textBoxData_BES.Multiline = true;
            textBoxData_BES.Name = "textBoxData_BES";
            textBoxData_BES.ReadOnly = true;
            textBoxData_BES.Size = new Size(259, 434);
            textBoxData_BES.TabIndex = 1;
            textBoxData_BES.Text = resources.GetString("textBoxData_BES.Text");
            // 
            // groupBoxResult_BES
            // 
            groupBoxResult_BES.Controls.Add(dataGridViewResult_BES);
            groupBoxResult_BES.Controls.Add(labelResult_BES);
            groupBoxResult_BES.Location = new Point(606, 22);
            groupBoxResult_BES.Name = "groupBoxResult_BES";
            groupBoxResult_BES.Size = new Size(314, 319);
            groupBoxResult_BES.TabIndex = 0;
            groupBoxResult_BES.TabStop = false;
            groupBoxResult_BES.Text = "Вывод данных";
            // 
            // dataGridViewResult_BES
            // 
            dataGridViewResult_BES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_BES.Location = new Point(6, 53);
            dataGridViewResult_BES.Name = "dataGridViewResult_BES";
            dataGridViewResult_BES.ReadOnly = true;
            dataGridViewResult_BES.RowHeadersVisible = false;
            dataGridViewResult_BES.RowHeadersWidth = 51;
            dataGridViewResult_BES.Size = new Size(302, 260);
            dataGridViewResult_BES.TabIndex = 1;
            // 
            // labelResult_BES
            // 
            labelResult_BES.Location = new Point(6, 26);
            labelResult_BES.Multiline = true;
            labelResult_BES.Name = "labelResult_BES";
            labelResult_BES.Size = new Size(302, 287);
            labelResult_BES.TabIndex = 0;
            labelResult_BES.Text = "Результат:";
            // 
            // buttonHelp_BES
            // 
            buttonHelp_BES.Location = new Point(641, 428);
            buttonHelp_BES.Name = "buttonHelp_BES";
            buttonHelp_BES.Size = new Size(43, 44);
            buttonHelp_BES.TabIndex = 2;
            buttonHelp_BES.Text = "?";
            buttonHelp_BES.UseVisualStyleBackColor = true;
            buttonHelp_BES.Click += buttonHelp_BES_Click;
            // 
            // buttonDone_BES
            // 
            buttonDone_BES.Location = new Point(703, 428);
            buttonDone_BES.Name = "buttonDone_BES";
            buttonDone_BES.Size = new Size(169, 44);
            buttonDone_BES.TabIndex = 3;
            buttonDone_BES.Text = "Выполнить";
            buttonDone_BES.UseVisualStyleBackColor = true;
            buttonDone_BES.Click += buttonDone_BES_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 490);
            Controls.Add(buttonDone_BES);
            Controls.Add(buttonHelp_BES);
            Controls.Add(groupBoxResult_BES);
            Controls.Add(groupBoxData_BES);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 4 | Бочарова Е.С.";
            Load += FormMain_Load;
            groupBoxData_BES.ResumeLayout(false);
            groupBoxData_BES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_BES).EndInit();
            groupBoxResult_BES.ResumeLayout(false);
            groupBoxResult_BES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BES).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxData_BES;
        private TextBox textBoxData_BES;
        private DataGridView dataGridViewMatrix_BES;
        private GroupBox groupBoxResult_BES;
        private TextBox labelResult_BES;
        private Button buttonHelp_BES;
        private Button buttonDone_BES;
        private DataGridView dataGridViewResult_BES;
    }
}
