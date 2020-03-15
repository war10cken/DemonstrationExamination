using System.Windows.Forms;

namespace DemonstrationExamination
{
    public class RightKeyPressForPass
    {
        public void CheckRightKeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 58) && e.KeyChar != 8) e.Handled = true;
        }
    }
}