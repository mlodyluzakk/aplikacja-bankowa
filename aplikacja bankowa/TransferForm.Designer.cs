namespace aplikacja_bankowa
{
    partial class TransferForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnConfirm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(20, 20);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(125, 17);
            this.lblAccount.Text = "Numer konta (26 cyfr):";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(20, 40);
            this.txtAccountNumber.Size = new System.Drawing.Size(250, 22);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(20, 80);
            this.lblAmount.Text = "Kwota:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(20, 100);
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(20, 140);
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.Text = "Przelej";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // TransferForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnConfirm);
            this.Text = "Nowy przelew";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
