namespace Ap04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello\nHello\nHello", "Greeting",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            DialogResult ans;
            ans = MessageBox.Show("Yes or No", "Ask", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ans == DialogResult.Yes)
                txtAns.Text = "Yep!";
            else if (ans == DialogResult.No)
                txtAns.Text = "Noooooooooooo!!!";


        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult ans;
            ans = MessageBox.Show("確定要離開", "離開", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ans == DialogResult.Yes)
                Close();
            
        }
    }
}
