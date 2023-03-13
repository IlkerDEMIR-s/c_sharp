using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dataGridView.DataSource = _productDal.GetAll();
        }

        private void SearchProducts(string key)
        {
            //var result = _productDal.GetAll().Where(p => p.Name.ToLower().Contains(key.ToLower())).ToList();
            var result = _productDal.GetByName(key); // More efficient and performant
            dataGridView.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productDal.Add(new Product
                {
                    Name = tbxName.Text,
                    StockAmount = Convert.ToInt32(tbxStock.Text),
                    UnitPrice = Convert.ToDecimal(tbxUnit.Text)
                });
                LoadProducts();
                MessageBox.Show("Product added!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                _productDal.Update(new Product
                {
                    Id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value),
                    Name = tbxNameUpdate.Text,
                    StockAmount = Convert.ToInt32(tbxStockUpdate.Text),
                    UnitPrice = Convert.ToDecimal(tbxUnitUpdate.Text)
                });
                LoadProducts();
                MessageBox.Show("Product updated!");

            }
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //MessageBox.Show("Process completed!");
            }

         }        

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            tbxStockUpdate.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            tbxUnitUpdate.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Product deleted!");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
             SearchProducts(tbxSearch.Text);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            var result = _productDal.GetById(3);
            dataGridView.DataSource = result;
        }
    }
}
