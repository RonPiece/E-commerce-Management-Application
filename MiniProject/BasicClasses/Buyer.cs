using System;
using System.Collections.Generic;

namespace MiniProject
{
    // Buyer class, with properties Username, Password, Address, and Products.
    public partial class Buyer
    {
        // Fields of the Buyer class.
        private string userName;
        private string password;
        private Address address;
        private List<Product> products;

        // Constructor for the Buyer class. Takes in a username, password, and address.
        public Buyer(string userName, string password, Address address, List<Product> products)
        {
            this.userName = userName;
            this.password = password;
            this.address = address;
            this.products = products ?? new List<Product>();
        }

        // Getters and setters for the fields of the Buyer class.
        public string GetUserName()
        {
            return this.userName;
        }

        public bool SetUserName(string userName)
        {
            try
            {
                if (string.IsNullOrEmpty(userName))
                {
                    throw new ArgumentException("UserName cannot be null or empty.", nameof(userName));
                }

                this.userName = userName;
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public string GetPassword()
        {
            return this.password;
        }

        public bool SetPassword(string password)
        {
            try
            {
                if (string.IsNullOrEmpty(password))
                {
                    throw new ArgumentException("Password cannot be null or empty.", nameof(password));
                }

                this.password = password;
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Address GetAddress()
        {
            return this.address;
        }

        public bool SetAddress(Address address)
        {
            try
            {
                if (address == null)
                {
                    throw new ArgumentNullException(nameof(address), "Address cannot be null.");
                }

                this.address = address;
                return true;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Product> GetProducts()
        {
            return this.products;
        }

        public bool SetProducts(List<Product> products)
        {
            try
            {
                if (products == null)
                {
                    throw new ArgumentNullException(nameof(products), "Products cannot be null.");
                }

                this.products = products;
                return true;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // ToString method to display the Buyer's username, address, and products.
        public override string ToString()
        {
            string str = $"Username: {this.userName}, {this.address.ToString()}";

            // If the products list is not null and has at least one product
            if (this.products != null && this.products.Count > 0)
            {
                // Format counter to display the products in the shopping cart
                int counter = 0;
                foreach (Product product in this.products)
                {
                    if (product != null)
                    {
                        if (counter == 0)
                        {
                            str += "\n\nProducts in the shopping cart:\n";
                        }
                        str += product.ToString().Trim();
                        counter++;
                        if (counter < this.products.Count)
                            str += "\n";
                    }
                }
            }
            return str;
        }

        // Equals method to compare two Buyer objects.
        public override bool Equals(object other)
        {
            Buyer temp = other as Buyer;
            if (temp == null)
                return false;

            if (!userName.Equals(temp.userName) || !password.Equals(temp.password) || !address.Equals(temp.address))
                return false;

            if (this.products.Count != temp.products.Count)
                return false;

            for (int i = 0; i < this.products.Count; i++)
            {
                if (!this.products[i].Equals(temp.products[i]))
                    return false;
            }

            return true;
        }
    }
}