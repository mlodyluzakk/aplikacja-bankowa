using System;
using System.Windows.Forms;

namespace aplikacja_bankowa
{
    public class CardForm : Form
    {
        private Button btnOrderCard;
        private Label lblCardInfo;
        private int cardCount = 0;

        public CardForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnOrderCard = new Button();
            this.lblCardInfo = new Label();

            // btnOrderCard
            this.btnOrderCard.Location = new System.Drawing.Point(50, 30);
            this.btnOrderCard.Size = new System.Drawing.Size(200, 40);
            this.btnOrderCard.Text = "Zamów kartę";
            this.btnOrderCard.Click += new EventHandler(this.btnOrderCard_Click);

            // lblCardInfo
            this.lblCardInfo.Location = new System.Drawing.Point(50, 90);
            this.lblCardInfo.Size = new System.Drawing.Size(200, 30);
            this.lblCardInfo.Text = "Liczba zamówionych kart: 0";

            // CardForm
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.btnOrderCard);
            this.Controls.Add(this.lblCardInfo);
            this.Text = "Zamów kartę";
        }

        private void btnOrderCard_Click(object sender, EventArgs e)
        {
            cardCount++;
            lblCardInfo.Text = $"Liczba zamówionych kart: {cardCount}";
        }
    }
}
