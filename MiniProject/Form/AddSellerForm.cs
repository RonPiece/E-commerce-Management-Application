using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class AddSellerForm : Form
    {
        // Properties for the seller form, All properties are type string and return the text from the textboxes.
        public string SellerNameForm => SellerNameTextBox.Text;
        public string Street => SellerStreetTextBox.Text;
        public string City => SellerCityTextBox.Text;
        public string State => SellerStateTextBox.Text;
        public string BuildingNum => SellerBuildingNumTextBox.Text;

        public AddSellerForm()
        {
            InitializeComponent();
        }

        // Event handler for the submit button, Validate all inputs and show error message if any input is invalid.
        private void SellerSubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate all inputs
                ValidateSellerName();
                ValidateSellerStreet();
                ValidateSellerCity();
                ValidateSellerState();
                ValidateSellerBuildingNum();
            }
            catch (Exception ex)
            {
                // Show error message and return to allow user to correct input
                MessageBox.Show(ex.Message);
                return;
            }

            // If all validations pass, close the form with OK result
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Validation methods for seller form
        private void ValidateSellerName()
        {
            if (string.IsNullOrEmpty(SellerNameTextBox.Text))
            {
                throw new Exception("Seller name cannot be empty.");
            }
            // Check if product name contains only letters and spaces
            foreach (char c in SellerNameTextBox.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    throw new Exception("Seller name must contain only letters.");
                }
            }
        }

        private void ValidateSellerStreet()
        {
            if (string.IsNullOrEmpty(SellerStreetTextBox.Text))
            {
                throw new Exception("Street cannot be empty.");
            }
            // Check if product name contains only letters and spaces
            foreach (char c in SellerStreetTextBox.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    throw new Exception("Street must contain only letters.");
                }
            }
        }

        private void ValidateSellerCity()
        {
            if (string.IsNullOrEmpty(SellerCityTextBox.Text))
            {
                throw new Exception("City cannot be empty.");
            }
            // Check if product name contains only letters and spaces
            foreach (char c in SellerCityTextBox.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    throw new Exception("City must contain only letters.");
                }
            }
        }

        private void ValidateSellerState()
        {
            if (string.IsNullOrEmpty(SellerStateTextBox.Text))
            {
                throw new Exception("State cannot be empty.");
            }
            // Check if product name contains only letters and spaces
            foreach (char c in SellerStateTextBox.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    throw new Exception("State must contain only letters.");
                }
            }
        }

        private void ValidateSellerBuildingNum()
        {
            if (string.IsNullOrEmpty(SellerBuildingNumTextBox.Text))
            {
                throw new Exception("Building number cannot be empty.");
            }
            foreach (char c in SellerBuildingNumTextBox.Text)
            {
                if (!char.IsDigit(c))
                {
                    throw new Exception("Building number must contain only numbers.");
                }
            }
        }
    }
}