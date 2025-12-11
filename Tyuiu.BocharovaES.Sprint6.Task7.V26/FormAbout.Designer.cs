namespace Tyuiu.BocharovaES.Sprint6.Task7.V26
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            groupBoxAbout_BES = new GroupBox();
            textBoxAbout_BES = new TextBox();
            pictureBoxAbout_BES = new PictureBox();
            buttonOk_BES = new Button();
            groupBoxAbout_BES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_BES).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAbout_BES
            // 
            groupBoxAbout_BES.Controls.Add(textBoxAbout_BES);
            groupBoxAbout_BES.Location = new Point(290, 12);
            groupBoxAbout_BES.Name = "groupBoxAbout_BES";
            groupBoxAbout_BES.Size = new Size(335, 307);
            groupBoxAbout_BES.TabIndex = 0;
            groupBoxAbout_BES.TabStop = false;
            // 
            // textBoxAbout_BES
            // 
            textBoxAbout_BES.Location = new Point(6, 15);
            textBoxAbout_BES.Multiline = true;
            textBoxAbout_BES.Name = "textBoxAbout_BES";
            textBoxAbout_BES.Size = new Size(321, 286);
            textBoxAbout_BES.TabIndex = 0;
            textBoxAbout_BES.Text = resources.GetString("textBoxAbout_BES.Text");
            // 
            // pictureBoxAbout_BES
            // 
            pictureBoxAbout_BES.Image = Properties.Resources.IMG_20240712_202711__1_;
            pictureBoxAbout_BES.Location = new Point(12, 12);
            pictureBoxAbout_BES.Name = "pictureBoxAbout_BES";
            pictureBoxAbout_BES.Size = new Size(243, 342);
            pictureBoxAbout_BES.TabIndex = 1;
            pictureBoxAbout_BES.TabStop = false;
            // 
            // buttonOk_BES
            // 
            buttonOk_BES.Location = new Point(531, 325);
            buttonOk_BES.Name = "buttonOk_BES";
            buttonOk_BES.Size = new Size(94, 29);
            buttonOk_BES.TabIndex = 2;
            buttonOk_BES.Text = "Ok";
            buttonOk_BES.UseVisualStyleBackColor = true;
            buttonOk_BES.Click += buttonOk_BES_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 366);
            Controls.Add(buttonOk_BES);
            Controls.Add(pictureBoxAbout_BES);
            Controls.Add(groupBoxAbout_BES);
            Name = "FormAbout";
            Text = "FormAbout";
            groupBoxAbout_BES.ResumeLayout(false);
            groupBoxAbout_BES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_BES).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAbout_BES;
        private TextBox textBoxAbout_BES;
        private PictureBox pictureBoxAbout_BES;
        private Button buttonOk_BES;
    }
}