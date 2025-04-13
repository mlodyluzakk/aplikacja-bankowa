using System;
using System.Windows.Forms;
using System.Linq;

namespace aplikacja_bankowa
{
    public partial class TransferForm : Form
    {
        public string TargetAccount { get; private set; }
        public double TransferAmount { get; private set; }

        public TransferForm()
        {
            InitializeComponent();
            txtAccountNumber.MaxLength = 26;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber.Text;

            if (accountNumber.Length != 26 || !accountNumber.All(char.IsDigit))
            {
                MessageBox.Show("Numer konta musi zawierać dokładnie 26 cyfr.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtAmount.Text, out double amount) || amount <= 0)
            {
                MessageBox.Show("Wprowadź poprawną kwotę do przelewu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TargetAccount = accountNumber;
            TransferAmount = amount;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
    }
