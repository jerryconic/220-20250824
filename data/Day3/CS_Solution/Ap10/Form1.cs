namespace Ap10
{
    public partial class Form1 : Form
    {
        int x0, y0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pct1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Graphics g = pct1.CreateGraphics();
                g.DrawLine(new Pen(Color.Black), x0, y0, e.X, e.Y);
                x0 = e.X;
                y0 = e.Y; 

            }

            txtData.Text = $"X={e.X}, Y={e.Y}, Button={e.Button}";
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            Graphics g = pct1.CreateGraphics();
            g.DrawLine(new Pen(Color.Blue), 10, 10, 110, 110);
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Graphics g = pct1.CreateGraphics();
            g.DrawRectangle(new Pen(Color.Green), 10, 10, 100, 100);
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            Graphics g = pct1.CreateGraphics();
            g.DrawEllipse(new Pen(Color.Red), 10, 10, 100, 100);
        }

        private void pct1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
        }
    }
}
