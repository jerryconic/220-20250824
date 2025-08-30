namespace Ap04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            int nt;
            decimal amount;
            int.TryParse(txtNT.Text, out nt);
            switch(cmbCurr.Text)
            {
                case "美金":
                    amount = nt / 30.59M;
                    break;
                case "日圓":
                    amount = nt / 0.2079M;
                    break;
                case "歐元":
                    amount = nt / 35.73M;
                    break;
                default:
                    amount = 0;
                    break;
            }
            txtAmount.Text = amount.ToString("#,##0.00");


        }
    }
}
