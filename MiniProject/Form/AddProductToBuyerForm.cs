using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class AddProductToBuyerForm : Form
    {
        // Dictionary to store buyers and sellers
        private Dictionary<string, Buyer> buyers;
        private Dictionary<string, Seller> sellers;

        // Constructor to initialize the form
        public AddProductToBuyerForm(Dictionary<string, Buyer> buyers, Dictionary<string, Seller> sellers)
        {
            InitializeComponent();
            this.buyers = buyers;
            this.sellers = sellers;
        }

        // Event handler for Add Product button click.
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Get buyer name, seller name, and product name from textboxes
            string buyerName = txtBuyerName.Text;
            string sellerName = txtSellerName.Text;
            string productName = txtProductName.Text;

            // Check if buyer exists
            if (!buyers.ContainsKey(buyerName))
            {
                MessageBox.Show($"Buyer '{buyerName}' does not exist.");
                return;
            }

            // Check if seller exists
            if (!sellers.ContainsKey(sellerName))
            {
                MessageBox.Show($"Seller '{sellerName}' does not exist.");
                return;
            }

            // Get the product from the seller
            var sellerProducts = sellers[sellerName].GetProducts();
            var product = sellerProducts.FirstOrDefault(p => p.GetProductName() == productName);

            // Check if product exists
            if (product == null)
            {
                MessageBox.Show($"Product '{productName}' does not exist for seller '{sellerName}'.");
                return;
            }

            // Product exists, add it to the buyer's products
            buyers[buyerName].GetProducts().Add(product);
            MessageBox.Show($"Product '{productName}' added to buyer '{buyerName}' from seller '{sellerName}'.");
        }
    }
}