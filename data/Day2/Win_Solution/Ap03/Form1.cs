namespace Ap03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int score;
            int.TryParse(txtScore.Text, out score);
            if(score < 60)
            {
                txtResult.Text = "���ή�";
                txtResult.BackColor = Color.LightYellow;
                txtResult.ForeColor = Color.Red;
            }
            else
            {
                txtResult.Text = "�ή�";
                txtResult.BackColor = Color.Blue;
                txtResult.ForeColor = Color.White;
            }
        }
    }
}
