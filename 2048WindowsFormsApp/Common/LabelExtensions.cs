using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public static class LabelExtensions
    {
        public static void Clear(this Label label)
        {
            label.Text = string.Empty;
        }

        public static bool IsEmpty(this Label label)
        {
            return label.Text == string.Empty;
        }

        public static int GetNumber (this Label label)
        {
            if (int.TryParse(label.Text, out int number))
                return number;
            else return 0;
        }
    }
}
