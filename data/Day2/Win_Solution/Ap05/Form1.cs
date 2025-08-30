namespace Ap05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            pct1.Image = Image.FromFile("animals/dog.jpg");
            //pct1.Image = Image.FromFile("animals\\dog.jpg");
            //pct1.Image = Image.FromFile(@"animals\dog.jpg");
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            pct1.Image = Image.FromFile("animals/cat.jpg");
        }

        private void btnLion_Click(object sender, EventArgs e)
        {
            pct1.Image = Image.FromFile("animals/lion.jpg");
        }
    }
}
