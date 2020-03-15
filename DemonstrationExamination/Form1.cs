using System;
using System.Windows.Forms;

namespace DemonstrationExamination
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new RegistrationForm();
            form.Show();
        }
    }
}