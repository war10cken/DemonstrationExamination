using System;
using System.Windows.Forms;

namespace DemonstrationExamination
{
    public partial class RegistrationForm : Form
    {
        private readonly RightKeyPressForPass _rightKeyPress = new RightKeyPressForPass();
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            _rightKeyPress.CheckRightKeyPress(e);
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            _rightKeyPress.CheckRightKeyPress(e);
        }
        private void textBox3_TextChanged(object sender, EventArgs e) {
            if (textBox3.Text != textBox2.Text)
            {
                MessageBox.Show("Вы ввели неправильный повторные пароль!", "Ошибка!", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}