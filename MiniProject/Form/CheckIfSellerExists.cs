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
    public partial class CheckIfSellerExists : Form
    {
        // Fields of the CheckIfSellerExists class.
        private Dictionary<string, Seller> sellers;
        private string sellerName;

        // Constructor for the CheckIfSellerExists form.
        public CheckIfSellerExists(Dictionary<string, Seller> sellers)
        {
            InitializeComponent();
            this.sellers = sellers;
        }

        // Getter for sellerName
        public string GetSellerName()
        {
            return this.sellerName;
        }

        // Setter for sellerName
        public bool SetSellerName(string sellerName)
        {
            if (string.IsNullOrEmpty(sellerName))
            {
                throw new ArgumentException("Seller name cannot be null or empty.");
            }
            this.sellerName = sellerName;
            return true;
        }

        // Event handler for the CheckButton click event.
        private void CheckButton_Click(object sender, EventArgs e)
        {
            SetSellerName(SellerNameTextBox.Text); // Set the seller name to the text in the textbox
            if (sellers.ContainsKey(GetSellerName()))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Seller does not exist.");
            }
        }
    }
}
