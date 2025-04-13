using System.Windows.Forms;

namespace aplikacja_bankowa
{
    public class AccountView
    {
        private Label displayLabel;

        public AccountView(Label label)
        {
            displayLabel = label;
        }

        public void ShowMessage(string message)
        {
            displayLabel.Text = message;
        }
    }
}
