using System;
using System.Collections.Generic;

namespace MiniProject
{
    // Seller class.
    public class Seller
    {
        // Fields of the Seller class.
        private string name;
        private string password;
        private Address address;
        private List<Product> products;
        
        // Constructor for the Seller class.
        public Seller(string name, string password, Address address, List<Product> products)
        {
            this.name = name;
            this.password = password;
            this.address = address;
            this.products = products ?? new List<Product>();
        }
        // Getters and setters for the fields of the Seller class.
        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            }

            this.name = name;
        }

        public string GetPassword()
        {
            return this.password;
        }

        public void SetPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Password cannot be null or empty.", nameof(password));
            }

            this.password = password;
        }

        public Address GetAddress()
        {
            return this.address;
        }

        public void SetAddress(Address address)
        {
            if (address == null)
            {
                throw new ArgumentNullException(nameof(address), "Address cannot be null.");
            }

            this.address = address;
        }
        
        public List<Product> GetProducts()
        {
            return this.products;
        }

        public void SetProducts(List<Product> products)
        {
            if (products == null)
            {
                throw new ArgumentNullException(nameof(products), "Products cannot be null.");
            }

            this.products = products;
        }

        // ToString method to display the Seller's information.
        public override string ToString()
        {
            string str = $"Name: {this.name}, {this.address.ToString()}";
            if (this.products != null && this.products.Count > 0)
            {
                str += "\nProducts:\n";
                int counter = 0;
                foreach (Product product in this.products)
                {
                    if (product != null)
                    {
                        str += product.ToString();
                        if (counter < this.products.Count - 1)
                        {
                            str += "\n";
                        }
                    }
                    counter++;
                }
            }
            else
            {
                str += "\nNo products yet.";
            }
            return str;
        }

        // Equals method to compare two Seller objects.
        public override bool Equals(object other)
        {
            Seller temp = other as Seller;
            if (temp == null)
                return false;

            if (!name.Equals(temp.name) || !password.Equals(temp.password) || !address.Equals(temp.address))
                return false;

            if (this.products.Count != temp.products.Count)
                return false;

            for (int i = 0; i < this.products.Count; i++)
            {
                if (!this.products[i].Equals(temp.products[i]))
                {
                    return false;
                }
            }

            return true;
        }

        // Add a new product to the Seller's list of products.
        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");
            }

            this.products.Add(product);
        }
    }
}