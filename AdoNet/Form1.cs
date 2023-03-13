namespace AdoNet
{
    public partial class Form1 : Form
    {
        ProductDal _productDal = new ProductDal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text)
            });
            LoadProducts();
            MessageBox.Show("Product Added!");
        }

        public void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }


        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = Convert.ToString(dgwProducts.CurrentRow.Cells[1].Value);
            tbxUnitPriceUpdate.Text = Convert.ToString(dgwProducts.CurrentRow.Cells[3].Value);
            tbxStockAmountUpdate.Text = Convert.ToString(dgwProducts.CurrentRow.Cells[2].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text),
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text)
            };

            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Product Updated!");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProducts();
            MessageBox.Show("Product Deleted!");
        }
    }
}