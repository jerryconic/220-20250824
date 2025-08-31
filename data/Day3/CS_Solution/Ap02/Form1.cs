namespace Ap02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            string[] files = { "dices/d1.png", "dices/d2.png", "dices/d3.png",
                               "dices/d4.png", "dices/d5.png", "dices/d6.png" };
            int[] dices = new int[4];

            Random rnd = new Random();
            for(int i = 0; i<4; i++)
                dices[i] = rnd.Next(0, 6);

            Array.Sort(dices);

            pct1.Image = Image.FromFile(files[dices[0]]);
            pct2.Image = Image.FromFile(files[dices[1]]);
            pct3.Image = Image.FromFile(files[dices[2]]);
            pct4.Image = Image.FromFile(files[dices[3]]);

            if (dices[0] == dices[3])
                lblPoints.Text = "�I��:�@��";
            else if (dices[0] == dices[2] || dices[1] == dices[3])
                lblPoints.Text = "�I��:�S�I���Y(3)";
            else if (dices[0] == dices[1])
                lblPoints.Text = $"�I��:{dices[2] + dices[3] + 2}�I";
            else if (dices[1] == dices[2])
                lblPoints.Text = $"�I��:{dices[0] + dices[3] + 2}�I";
            else if (dices[2] == dices[3])
                lblPoints.Text = $"�I��:{dices[0] + dices[1] + 2}�I";
            else
                lblPoints.Text = "�I��:�S�I���Y(1)";

        }
    }
}
