using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class MainForm : Form
    {
        // Dictionary to store buyers and sellers
        private Dictionary<string, (List<Product> products, Address address)> buyers = new Dictionary<string, (List<Product>, Address)>();
        private Dictionary<string, (List<Product> products, Address address)> sellers = new Dictionary<string, (List<Product>, Address)>();
        private administrativeDivision adminDivision;

        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
            this.Load += MainForm_Load;
            this.Text = "R&E-commerce";
        }

        // Load data from file when form is loaded
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load sellers from file
            LoadDataFromFile("Sellers");

            // Initialize administrativeDivision with buyers and sellers
            UpdateAdminDivision();
        }

        // Add seller
        private void AddSeller_Click(object sender, EventArgs e)
        {
            // Open AddSellerForm and add the seller to the sellers dictionary
            using (var addSellerForm = new AddSellerForm())
            {
                if (addSellerForm.ShowDialog() == DialogResult.OK)
                {
                    // Get the seller details from the form
                    string sellerName = addSellerForm.SellerNameForm;
                    string street = addSellerForm.Street;
                    string city = addSellerForm.City;
                    string state = addSellerForm.State;
                    string buildingNum = addSellerForm.BuildingNum;

                    if (!sellers.ContainsKey(sellerName))
                    {
                        // Create a new Address object with the seller details
                        Address address = new Address(street, city, state, buildingNum);
                        sellers[sellerName] = (new List<Product>(), address);
                        MessageBox.Show($"Seller '{sellerName}' added with address: {address}");

                        // Update adminDivision with the new seller
                        UpdateAdminDivision();
                    }
                    else
                    {
                        MessageBox.Show("Seller already exists.");
                    }
                }
            }
        }

        // Add buyer
        private void AddBuyer_Click(object sender, EventArgs e)
        {
            // Open AddBuyerForm and add the buyer to the buyers dictionary
            using (var addBuyerForm = new AddBuyerForm())
            {
                if (addBuyerForm.ShowDialog() == DialogResult.OK)
                {
                    // Get the buyer details from the form
                    string buyerName = addBuyerForm.BuyerNameForm;
                    string street = addBuyerForm.Street;
                    string city = addBuyerForm.City;
                    string state = addBuyerForm.State;
                    string buildingNum = addBuyerForm.BuildingNum;

                    if (!buyers.ContainsKey(buyerName))
                    {
                        // Create a new Address object with the buyer details
                        Address address = new Address(street, city, state, buildingNum);
                        buyers[buyerName] = (new List<Product>(), address);
                        MessageBox.Show($"Buyer '{buyerName}' added with address: {address}");

                        // Update adminDivision with the new buyer
                        UpdateAdminDivision();
                    }
                    else
                    {
                        MessageBox.Show("Buyer already exists.");
                    }
                }
            }
        }
        
        // Add product to seller
        private void AddProdouctToSeller_Click(object sender, EventArgs e)
        {
            // Convert the dictionary to the expected type
            // kvp => kvp.Value is a tuple with the products list and address
            // Create a new Seller object with the products list and address
            var sellerDictionary = sellers.ToDictionary(
                kvp => kvp.Key,
                kvp => new Seller(kvp.Key, "defaultPassword", kvp.Value.address, kvp.Value.products)
            );

            // Open CheckIfSellerExistsForm to check if the seller exists
            using (var checkIfSellerExistsForm = new CheckIfSellerExists(sellerDictionary))
            {
                if (checkIfSellerExistsForm.ShowDialog() == DialogResult.OK)
                {
                    // Get the seller name from the form
                    string sellerName = checkIfSellerExistsForm.GetSellerName();
                    
                    // Check if the seller exists in the dictionary
                    if (sellers.ContainsKey(sellerName))
                    {
                        MessageBox.Show($"Seller '{sellerName}' exists.");

                        // Convert the specific seller entry to a Seller object
                        var sellerEntry = sellers[sellerName];
                        Seller seller = new Seller(sellerName, "defaultPassword", sellerEntry.address, sellerEntry.products);

                        // Open AddProductToSellerForm and pass the specific seller
                        using (var addProductToSellerForm = new AddProductToSellerForm(seller))
                        {
                            if (addProductToSellerForm.ShowDialog() == DialogResult.OK)
                            {
                                // Update the seller's product list in the dictionary with actual Product objects
                                sellers[sellerName] = (seller.GetProducts(), sellerEntry.address);
                                MessageBox.Show($"Product added to seller '{sellerName}'.");

                                // Debug message to verify product addition
                                Console.WriteLine($"Updated products for seller '{sellerName}': {string.Join(", ", seller.GetProducts().Select(p => p.ToString()))}");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seller does not exist.");
                    }
                }
            }
        }

        // Add product to buyer
        private void AddProductToBuyer_Click(object sender, EventArgs e)
        {
            // Convert the dictionaries to the expected types
            // kvp(Key value pair) => kvp.Key is the seller/buyer name
            // kvp => kvp.Value is a tuple with the products list and address
            // Create a new Buyer object with the products list and address
            var buyerDictionary = buyers.ToDictionary(
            kvp => kvp.Key,
            kvp => new Buyer(kvp.Key, "defaultPassword", kvp.Value.address, kvp.Value.products)
            );

            var sellerDictionary = sellers.ToDictionary(
                kvp => kvp.Key,
                kvp => new Seller(kvp.Key, "defaultPassword", kvp.Value.address, kvp.Value.products)
            );

            // Open AddProductToBuyerForm and add the product to the buyer
            using (var addProductToBuyerForm = new AddProductToBuyerForm(buyerDictionary, sellerDictionary))
            {
                if (addProductToBuyerForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the buyers dictionary with the modified buyer objects
                    foreach (var buyer in buyerDictionary)
                    {
                        buyers[buyer.Key] = (buyer.Value.GetProducts(), buyer.Value.GetAddress());
                    }

                    MessageBox.Show("Product added to buyer successfully.");

                    // Update adminDivision with the updated buyers
                    UpdateAdminDivision();
                }
            }
        }

        // Show all data
        private void ShowAllData_Click(object sender, EventArgs e)
        {
            // Create a string with all the sellers and buyers data
            StringBuilder dataBuilder = new StringBuilder();

            // Add sellers and buyers data to the string
            dataBuilder.AppendLine("Sellers:");
            foreach (var seller in adminDivision.GetSellers())
            {
                // Add seller data to the string
                dataBuilder.AppendLine(seller.ToString());
                dataBuilder.AppendLine("---------------------------");
            }

            dataBuilder.AppendLine();
            dataBuilder.AppendLine("Buyers:");
            foreach (var buyer in adminDivision.GetBuyers())
            {
                // Add buyer data to the string
                dataBuilder.AppendLine(buyer.ToString());
                dataBuilder.AppendLine("---------------------------");
            }

            // Show the data in a new form
            string data = dataBuilder.ToString();

            using (var showAllDataForm = new ShowAllData(data))
            {
                showAllDataForm.ShowDialog();
            }
        }

        // Save data to file when form is closing
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDataToFile("Sellers");
        }

        // Save Seller and his products data to file
        public void SaveDataToFile(string fileName)
        {
            // txtFilePath is the path to the file in the current directory
            string txtFilePath = Path.Combine(Directory.GetCurrentDirectory(), fileName + ".txt");

            try
            {
                using (StreamWriter sw = new StreamWriter(txtFilePath)) // Open the file for writing
                {
                    foreach (var seller in sellers) // Iterate over the sellers dictionary
                    {
                        string sellerName = seller.Key; // Get the seller name
                        var sellerDetails = seller.Value; // Get the seller details

                        // Write seller details
                        sw.WriteLine($"Name:{sellerName}");
                        sw.WriteLine($"Address:{sellerDetails.address.GetStreet()},{sellerDetails.address.GetCity()},{sellerDetails.address.GetState()},{sellerDetails.address.GetBuildingNum()}");

                        // Write products
                        foreach (var product in sellerDetails.products)
                        {
                            if (product is SpecialProduct specialProduct) // Check if the product is a SpecialProduct and write the extra fields
                            {
                                sw.WriteLine($"SpecialProduct:{specialProduct.GetProductName()},{specialProduct.GetProductPrice()},{specialProduct.GetCategory()},{specialProduct.GetExtraPrice()},{specialProduct.GetTotalPrice()}");
                            }
                            else // Write the product normally
                            {
                                sw.WriteLine($"Product:{product.GetProductName()},{product.GetProductPrice()},{product.GetCategory()}");
                            }
                        }
                    }
                }

                MessageBox.Show($"Data successfully saved to {txtFilePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}");
            }
        }

        // Load data from file when form is loaded
        public void LoadDataFromFile(string fileName)
        {
            // txtFilePath is the path to the file in the current directory
            string txtFilePath = Path.Combine(Directory.GetCurrentDirectory(), fileName + ".txt");

            if (!File.Exists(txtFilePath))
            {
                MessageBox.Show($"File not found: {txtFilePath}");
                return;
            }

            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(txtFilePath);
                string currentSellerName = null;
                List<Product> currentProducts = null;
                Address currentAddress = null;

                foreach (var line in lines) // Iterate over the lines in the file
                {
                    if (line.StartsWith("Name:"))
                    {
                        // If currentSellerName is not null, add the current seller to the sellers dictionary
                        // This ensures that the data for the previous seller is not lost when processing the next seller
                        if (currentSellerName != null) 
                        {
                            sellers[currentSellerName] = (currentProducts, currentAddress);
                        }

                        currentSellerName = line.Substring(5).Trim(); // Trim seller name from the line and set it to currentSellerName.
                        currentProducts = new List<Product>(); // Create a new list for the current seller's products
                    }
                    else if (line.StartsWith("Address:"))
                    {
                        // Split the address parts and create a new Address object
                        var addressParts = line.Substring(8).Trim().Split(',');
                        currentAddress = new Address(addressParts[0], addressParts[1], addressParts[2], addressParts[3]);
                    }
                    else if (line.StartsWith("Product:"))
                    {
                        // Split the product parts and create a new Product object
                        var productParts = line.Substring(8).Trim().Split(','); // Extract the product details from the line, starting after "Product:", trim any extra spaces, and split by commas.
                        string productName = productParts[0]; // The first part is the product name.
                        double productPrice = double.Parse(productParts[1]); // The second part is the product price, parsed as a double.
                        Product.eCategory category = (Product.eCategory)Enum.Parse(typeof(Product.eCategory), productParts[2]); // The third part is the product category, parsed as an enum value.
                        Product product = new Product(productName, productPrice, category); // Create a new Product object using the extracted details.
                        currentProducts.Add(product); // Add the newly created Product object to the currentProducts list.
                    }
                    else if (line.StartsWith("SpecialProduct:"))
                    {
                        // Split the special product parts and create a new SpecialProduct object
                        var productParts = line.Substring(15).Trim().Split(','); // Extract the special product details from the line, starting after "SpecialProduct:", trim any extra spaces, and split by commas.
                        string productName = productParts[0]; // The first part is the product name.
                        double productPrice = double.Parse(productParts[1]); // The second part is the product price, parsed as a double.
                        Product.eCategory category = (Product.eCategory)Enum.Parse(typeof(Product.eCategory), productParts[2]); // The third part is the product category, parsed as an enum value.
                        double extraPrice = double.Parse(productParts[3]); // The fourth part is the extra price, parsed as a double.
                        double totalPrice = double.Parse(productParts[4]); // The fifth part is the total price, parsed as a double.
                        SpecialProduct specialProduct = new SpecialProduct(productName, productPrice, category, extraPrice, totalPrice); // Create a new SpecialProduct object using the extracted details.
                        currentProducts.Add(specialProduct); // Add the newly created SpecialProduct object to the currentProducts list.
                    }
                }
                // Save the last seller's data after the loop has finished
                // This ensures the last seller's data is saved after all lines have been processed
                if (currentSellerName != null)
                {
                    sellers[currentSellerName] = (currentProducts, currentAddress);
                }

                MessageBox.Show("Data loaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        // Update the adminDivision with the current buyers and sellers
        private void UpdateAdminDivision()
        {
            // Convert the dictionaries to lists of Buyer and Seller objects
            List<Buyer> buyerList = buyers.Select(b => new Buyer(b.Key, "defaultPassword", b.Value.address, b.Value.products)).ToList();
            List<Seller> sellerList = sellers.Select(s => new Seller(s.Key, "defaultPassword", s.Value.address, s.Value.products)).ToList();

            adminDivision = new administrativeDivision("Main Division", buyerList, sellerList);
        }
    }
}