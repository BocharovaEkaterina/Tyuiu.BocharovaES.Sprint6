namespace Tyuiu.BocharovaES.Sprint6.Task6.V6
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
            labelInfo_BES = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonOK_BES = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_BES
            // 
            labelInfo_BES.AutoSize = true;
            labelInfo_BES.Location = new Point(349, 9);
            labelInfo_BES.Name = "labelInfo_BES";
            labelInfo_BES.Size = new Size(0, 20);
            labelInfo_BES.TabIndex = 0;
            labelInfo_BES.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 223);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 29);
            label1.Name = "label1";
            label1.Size = new Size(387, 180);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            label1.UseWaitCursor = true;
            // 
            // buttonOK_BES
            // 
            buttonOK_BES.Location = new Point(515, 223);
            buttonOK_BES.Name = "buttonOK_BES";
            buttonOK_BES.Size = new Size(133, 39);
            buttonOK_BES.TabIndex = 3;
            buttonOK_BES.Text = "Ok";
            buttonOK_BES.UseVisualStyleBackColor = true;
            buttonOK_BES.UseWaitCursor = true;
            buttonOK_BES.Click += buttonOK_BES_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 269);
            Controls.Add(buttonOK_BES);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(labelInfo_BES);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo_BES;
        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonOK_BES;
    }
}