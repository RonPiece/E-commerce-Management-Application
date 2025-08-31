using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class AddProductToSellerForm : Form
    {
        // Field for the seller
        private Seller seller;
         
        // Constructor for the AddProductToSellerForm
        public AddProductToSellerForm(Seller seller)
        {
            InitializeComponent();
            this.seller = seller;
            ExtraPriceTextBox.Enabled = false; // Initially disable the extra price text box
            SpecialPackageCheckBox.CheckedChanged += SpecialPackageCheckBox_CheckedChanged; // Add event handler if the special package check box is checked
        }

        // Event handler for the special package check box
        private void SpecialPackageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Enable the extra price text box if the special package check box is checked
            ExtraPriceTextBox.Enabled = SpecialPackageCheckBox.Checked;
            ExtraPriceSpecialPackageLabel.Visible = SpecialPackageCheckBox.Checked;
            ExtraPriceTextBox.Visible = SpecialPackageCheckBox.Checked;
        }

        // Get the selected category
        private Product.eCategory GetSelectedCategory()
        {
            if (CategoryRadioButton1.Checked) return Product.eCategory.kids;
            if (CategoryRadioButton2.Checked) return Product.eCategory.electronics;
            if (CategoryRadioButton3.Checked) return Product.eCategory.office;
            if (CategoryRadioButton4.Checked) return Product.eCategory.clothing;
            throw new ArgumentException("Product category must be selected.");
        }

        // Validation methods for the product name, product price, and extra price
        private void ValidateProductName()
        {
            if (string.IsNullOrWhiteSpace(ProductNameTextBox.Text))
            {
                throw new ArgumentException("Product name cannot be empty.");
            }
            // Check if product name contains only letters and spaces
            foreach (char c in ProductNameTextBox.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    throw new ArgumentException("Product name must contain only letters and spaces.");
                }
            }
        }

        private void ValidateProductPrice()
        {
            if (string.IsNullOrWhiteSpace(ProductPriceTextBox.Text))
            {
                throw new ArgumentException("Price cannot be empty.");
            }
            if (!double.TryParse(ProductPriceTextBox.Text, out _))
            {
                throw new ArgumentException("Invalid format for product price. Please enter a valid number.");
            }
        }

        private void ValidateExtraPrice()
        {
            if (SpecialPackageCheckBox.Checked)
            {
                if (string.IsNullOrWhiteSpace(ExtraPriceTextBox.Text))
                {
                    throw new ArgumentException("Extra price cannot be empty.");
                }
                if (!double.TryParse(ExtraPriceTextBox.Text, out double extraPrice) || extraPrice < 0)
                {
                    throw new ArgumentException("Invalid format for extra price. Please enter a valid non-negative number.");
                }
            }
        }

        // Event handler for the submit button, Validate inputs and create product.
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                ValidateProductName();
                ValidateProductPrice();
                ValidateExtraPrice();

                // Get form inputs
                string productName = ProductNameTextBox.Text;
                double productPrice = double.Parse(ProductPriceTextBox.Text);
                Product.eCategory category = GetSelectedCategory();
                bool specialPackage = SpecialPackageCheckBox.Checked;
                double extraPrice = specialPackage ? double.Parse(ExtraPriceTextBox.Text) : 0;

                // Create product
                Product sellerProduct;
                string message = $"Product details:\n--------------\nName: {productName}\nPrice: {productPrice}";

                // Check if special package
                if (specialPackage)
                {
                    double totalPrice = productPrice + extraPrice;
                    sellerProduct = new SpecialProduct(productName, productPrice, category, extraPrice, totalPrice);
                    message += $"\nExtra Price: {extraPrice}\nTotal Price: {totalPrice}";
                }
                else
                {
                    sellerProduct = new Product(productName, productPrice, category);
                }

                // Add product to seller
                seller.AddProduct(sellerProduct);
                message += "\n\nProduct added to the seller successfully.";
                MessageBox.Show(message);

                // Set DialogResult to OK to close the form
                this.DialogResult = DialogResult.OK;

                // Clear text boxes
                ClearTextBoxes();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please try again.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Method to clear text boxes
        private void ClearTextBoxes()
        {
            ProductNameTextBox.Clear();
            ProductPriceTextBox.Clear();
            ExtraPriceTextBox.Clear();
            CategoryRadioButton1.Checked = false;
            CategoryRadioButton2.Checked = false;
            CategoryRadioButton3.Checked = false;
            CategoryRadioButton4.Checked = false;
            SpecialPackageCheckBox.Checked = false;
        }
    }
}