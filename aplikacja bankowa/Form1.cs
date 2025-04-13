using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace aplikacja_bankowa
{
    public partial class Form1 : Form
    {
        private double balance = 1000;
        private List<string> transferHistory = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAccountDetails.Text = $"Witaj w aplikacji bankowej!\nSaldo: {balance} PLN";
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAmount.Text, out double amount) && amount > 0)
            {
                balance += amount;
                lblAccountDetails.Text = $"Wpłacono: {amount} PLN\nNowe saldo: {balance} PLN";
            }
            else
            {
                MessageBox.Show("Wprowadź poprawną kwotę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            using (var transferForm = new TransferForm())
            {
                if (transferForm.ShowDialog() == DialogResult.OK)
                {
                    double amount = transferForm.TransferAmount;
                    string targetAccount = transferForm.TargetAccount;

                    if (amount <= balance)
                    {
                        balance -= amount;
                        string entry = $"Przelano {amount} PLN na konto {targetAccount} - {DateTime.Now}";
                        transferHistory.Add(entry);
                        lblAccountDetails.Text = $"{entry}\nNowe saldo: {balance} PLN";
                    }
                    else
                    {
                        MessageBox.Show("Niewystarczające środki na koncie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Numer konta: 123456\nSaldo: {balance} PLN", "Szczegóły konta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTransferHistory_Click(object sender, EventArgs e)
        {
            if (transferHistory.Count == 0)
            {
                MessageBox.Show("Brak zapisanych przelewów.", "Historia przelewów", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string history = string.Join(Environment.NewLine, transferHistory);
                MessageBox.Show(history, "Historia przelewów", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblAccountDetails_Click(object sender, EventArgs e)
        {

        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.ShowDialog();
        }

    }
}
