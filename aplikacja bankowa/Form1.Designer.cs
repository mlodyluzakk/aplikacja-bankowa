namespace aplikacja_bankowa
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAccountDetails;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTransferHistory;
        private System.Windows.Forms.Button btnProducts; // <--- Dodano tutaj

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAccountDetails = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTransferHistory = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button(); // <--- Dodano

            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(50, 30);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 0;
            // 
            // lblAccountDetails
            // 
            this.lblAccountDetails.Location = new System.Drawing.Point(50, 70);
            this.lblAccountDetails.Name = "lblAccountDetails";
            this.lblAccountDetails.Size = new System.Drawing.Size(500, 40);
            this.lblAccountDetails.TabIndex = 1;
            this.lblAccountDetails.Click += new System.EventHandler(this.lblAccountDetails_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(50, 130);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 30);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Wpłać";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(150, 130);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 30);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Przelej";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnTransferHistory
            // 
            this.btnTransferHistory.Location = new System.Drawing.Point(241, 130);
            this.btnTransferHistory.Name = "btnTransferHistory";
            this.btnTransferHistory.Size = new System.Drawing.Size(120, 30);
            this.btnTransferHistory.TabIndex = 4;
            this.btnTransferHistory.Text = "Historia przelewów";
            this.btnTransferHistory.UseVisualStyleBackColor = true;
            this.btnTransferHistory.Click += new System.EventHandler(this.btnTransferHistory_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(367, 130);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(120, 30);
            this.btnViewDetails.TabIndex = 5;
            this.btnViewDetails.Text = "Szczegóły konta";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(505, 130);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Wyjście";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(50, 180); // Dodajemy poniżej reszty
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(100, 30);
            this.btnProducts.TabIndex = 7;
            this.btnProducts.Text = "Produkty";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(640, 250);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAccountDetails);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnTransferHistory);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProducts); // <--- Dodano
            this.Name = "Form1";
            this.Text = "Aplikacja Bankowa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
