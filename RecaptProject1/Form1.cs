using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecaptProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategories();
        }

        private void ListProducts()
        {
            using (var context = new NordwindContext())
            {
                dataGridView1.DataSource = context.Products.ToList();
            }
        }

        private void ListProductsByCategory(int categoryId)
        {
            using (var context = new NordwindContext())
            {
                dataGridView1.DataSource = context.Products.Where(p => p.CategoryID == categoryId).ToList();
            }
        }

        private void ListProductsByProductName(string key)
        {
            using (var context = new NordwindContext())
            {
                dataGridView1.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();
            }
        }

        private void ListCategories()
        {
            using (var context = new NordwindContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryID";
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = tbxSearch.Text;
            if (string.IsNullOrEmpty(search))
            {
                ListProducts();
            }
            else
            {
                ListProductsByProductName(search);
            }
        }

    }

}
