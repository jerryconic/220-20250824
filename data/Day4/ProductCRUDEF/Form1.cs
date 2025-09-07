namespace ProductCRUDEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int price;
            Product p = new Product();
            p.ProductID = txtID.Text;
            p.ProductName = txtName.Text;
            int.TryParse(txtPrice.Text, out price);
            p.Price = price;
            using (Db01Context context = new Db01Context())
            {
                context.Products.Add(p);
                context.SaveChanges();
            }
            MessageBox.Show("Insert OK", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int price;
            Product p = new Product();
            p.ProductID = txtID.Text;
            p.ProductName = txtName.Text;
            int.TryParse(txtPrice.Text, out price);
            p.Price = price;
            using (Db01Context context = new Db01Context())
            {
                context.Products.Update(p);
                context.SaveChanges();
            }
            MessageBox.Show("Update OK", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductID = txtID.Text;
            using (Db01Context context = new Db01Context())
            {
                context.Products.Remove(p);
                context.SaveChanges();
            }
            MessageBox.Show("Delete OK", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (Db01Context context = new Db01Context())
            {
                Product? p = context.Products.Find(txtID.Text);
                if(p!=null)
                {
                    txtID.Text = p.ProductID.ToString();
                    txtName.Text = p.ProductName.ToString();    
                    txtPrice.Text = p.Price.ToString();
                }
                else
                {
                    txtName.Clear();
                    txtPrice.Clear();
                }

            }


        }
    }
}
