namespace Ap06
{
    public partial class Form1 : Form
    {
        int ans, guess;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ans = rnd.Next(1, 100);
            Text = ans.ToString();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int.TryParse(txtGuess.Text, out guess);
            if (guess < ans)
                MessageBox.Show("高一點");
            else if(guess> ans)
                MessageBox.Show("低一點");
            else
                MessageBox.Show("猜對了");

        }
    }
}
