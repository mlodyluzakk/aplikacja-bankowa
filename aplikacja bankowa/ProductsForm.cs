using System;
using System.Windows.Forms;

namespace aplikacja_bankowa
{
    public class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            using (var cardForm = new CardForm())
            {
                cardForm.ShowDialog();
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            using (var accountForm = new AccountForm())
            {
                accountForm.ShowDialog();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ProductsForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.ResumeLayout(false);

        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
