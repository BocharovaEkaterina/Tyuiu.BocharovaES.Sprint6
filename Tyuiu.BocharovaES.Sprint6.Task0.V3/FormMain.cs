using Tyuiu.BocharovaES.Sprint6.Task0.V3.Lib;
namespace Tyuiu.BocharovaES.Sprint6.Task0.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonDone_BES_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_BES.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_BES.Text)));
            }
            catch
            {
                MessageBox.Show("Введины неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_BES_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИИПб-25-1 Бочарова Екатерина Сергеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox_BES_Click(object sender, EventArgs e)
        {

        }
    }
}
