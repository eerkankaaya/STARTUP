using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {

           

            dgwProducts.DataSource = _productDal.GelAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
            });
            MessageBox.Show("Product Added!");
        }

        private void tbxStockAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblUnitPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblStockAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
