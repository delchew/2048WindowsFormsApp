using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public class UnfocusedButton : Button
    {
        public UnfocusedButton()
        {
            SetStyle(ControlStyles.Selectable, false);
        }
    }
}
