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
    public partial class AddBuyerForm : Form
    {
        // Properties for the buyer form, All properties are type string and return the text from the textboxes.
        public string BuyerNameForm => BuyerNameTextBox.Text;
        public string Street => BuyerStreetTextBox.Text;
        public string City => BuyerCityTextBox.Text;
        public string State => BuyerStateTextBox.Text;
        public string BuildingNum => BuyerBuildingNumTextBox.Text;

        // Constructor for the buyer form
        public AddBuyerForm()
        {
            InitializeComponent();
        }

        // Event handler for the submit button, validates all inputs.
        private void BuyerSubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate all inputs
                ValidateBuyerName();
                ValidateBuyerStreet();
                ValidateBuyerCity();
                ValidateBuyerState();
                ValidateBuyerBuildingNum();
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

        // Validation methods for buyer form
        private void ValidateBuyerName()
        {
            if (string.IsNullOrEmpty(BuyerNameTextBox.Text))
            {
                throw new Exception("Buyer name cannot be empty.");
            }
            // Check if product name contains only letters and spaces
            foreach (char c in BuyerNameTextBox.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    throw new Exception("Buyer name must contain only letters.");
                }
            }
        }

        private void ValidateBuyerStreet()
        {
            if (string.IsNullOrEmpty(BuyerStreetTextBox.Text))
            {
                throw new Exception("Street cannot be empty.");
            }
            // Check if product name contains only letters and spaces
            foreach (char c in BuyerStreetTextBox.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    throw new Exception("Street must contain only letters.");
                }
            }
        }

        private void ValidateBuyerCity()
        {
            if (string.IsNullOrEmpty(BuyerCityTextBox.Text))
            {
                throw new Exception("City cannot be empty.");
            }
            // Check if product name contains only letters and spaces
            foreach (char c in BuyerCityTextBox.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    throw new Exception("City must contain only letters.");
                }
            }
        }

        private void ValidateBuyerState()
        {
            if (string.IsNullOrEmpty(BuyerStateTextBox.Text))
            {
                throw new Exception("State cannot be empty.");
            }
            // Check if product name contains only letters and spaces
            foreach (char c in BuyerStateTextBox.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    throw new Exception("State must contain only letters.");
                }
            }
        }

        private void ValidateBuyerBuildingNum()
        {
            if (string.IsNullOrEmpty(BuyerBuildingNumTextBox.Text))
            {
                throw new Exception("Building number cannot be empty.");
            }
            foreach (char c in BuyerBuildingNumTextBox.Text)
            {
                if (!char.IsDigit(c))
                {
                    throw new Exception("Building number must contain only numbers.");
                }
            }
        }
    }
}