using System;
using System.Windows.Forms;

namespace aplikacja_bankowa
{
    public class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nowe konto zostało otwarte!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCloseAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Konto zostało zamknięte.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AccountForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.ResumeLayout(false);

        }

        private void AccountForm_Load(object sender, EventArgs e)
        {

        }
    }
}
