using System.Windows.Forms;

namespace RA
{
    public static class MyMessage
    {
        private const string _titulo = "Search And Replace All Text";

        public static void ShowError(string message)
        {
            MessageBox.Show(message, _titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ShowQuestion(string message)
        {
            return (MessageBox.Show(message, _titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

        public static void ShowInformation(string message)
        {
            MessageBox.Show(message, _titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
