namespace Ap08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show($"You clicked {btn.Text}!");
        }
    }
}
