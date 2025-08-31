namespace Ap13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Return:
                    e.SuppressKeyPress = true;
                    SendKeys.Send("{Tab}");
                    break;
                case Keys.Up:
                    SendKeys.Send("+{Tab}");
                    break;
                default:
                    break;

            }
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.SelectAll();
        }
    }
}
