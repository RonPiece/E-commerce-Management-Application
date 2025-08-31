using System;

namespace MiniProject
{
    // Product class with properties ProductName, ProductPrice, Counter, ID, Category.
    public class Product
    {
        // Fields of the Product class.
        private string productName;
        private double productPrice;
        private static int counter;
        private int id;
        public enum eCategory { kids = 1, electronics = 2, office = 3, clothing = 4 };
        private eCategory category;

        // Constructor for the Product class. Takes in a product name, product price, and category.
        public Product(string productName, double productPrice, eCategory category)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            counter++;
            id = counter;
            this.category = category;
        }

        // Getters and setters for the fields of the Product class.
        public string GetProductName()
        {
            return this.productName;
        }

        public void SetProductName(string productName)
        {
            if (string.IsNullOrEmpty(productName))
            {
                throw new ArgumentException("Product name cannot be null or empty.", nameof(productName));
            }
            this.productName = productName;
        }

        public double GetProductPrice()
        {
            return this.productPrice;
        }

        public void SetProductPrice(double productPrice)
        {
            if (productPrice < 0)
            {
                throw new ArgumentException("Product price cannot be negative.", nameof(productPrice));
            }

            this.productPrice = productPrice;
        }

        public eCategory GetCategory()
        {
            return this.category;
        }

        public bool SetCategory(eCategory category)
        {
            this.category = category;
            return true;
        }

        public int GetNumOfProducts()
        {
            return counter;
        }

        // ToString method to return a string representation of the Product object.
        public override string ToString()
        {
            return $"Product Name: {this.productName}, Product Price: {this.productPrice}, Category: {this.category}, Serial Number: {this.id}";
        }

        // Equals method to compare two Product objects.
        public override bool Equals(object other)
        {
            Product temp = other as Product;
            if (temp == null)
                return false;

            return productName.Equals(temp.productName) && productPrice.Equals(temp.productPrice) && id.Equals(temp.id) && category.Equals(temp.category);
        }
    }

    // SpecialProduct class that inherits from the Product class.
    public class SpecialProduct : Product
    {
        // Fields of the SpecialProduct class.
        private double extraPrice;
        private double totalPrice;

        // Constructor for the SpecialProduct class. Takes in a product name, product price, category, extra price, and total price.
        public SpecialProduct(string productName, double productPrice, eCategory category, double extraPrice, double totalPrice) 
            : base(productName, productPrice, category)
        {
            this.extraPrice = extraPrice;
            this.totalPrice = productPrice + extraPrice;
        }

        // Getters and setters for the fields of the SpecialProduct class.
        public double GetExtraPrice()
        {
            return this.extraPrice;
        }

        public void SetExtraPrice(double extraPrice)
        {
            if (extraPrice <= 0)
            {
                throw new ArgumentException("Extra price cannot be zero or negative.", nameof(extraPrice));
            }

            this.extraPrice = extraPrice;
        }

        public double GetTotalPrice()
        {
            return this.totalPrice;
        }

        public void SetTotalPrice(double totalPrice)
        {
            if (totalPrice < this.GetProductPrice() + this.GetExtraPrice())
            {
                throw new ArgumentException("Total price cannot be less than the sum of product price and extra price.", nameof(totalPrice));
            }

            this.totalPrice = totalPrice;
        }

        // ToString method to return a string representation of the SpecialProduct object.
        public override string ToString()
        {
            return base.ToString() + $", Special package extra price: {this.extraPrice}, Total Price: {this.totalPrice}";
        }

        // Equals method to compare two SpecialProduct objects.
        public override bool Equals(object other)
        {
            SpecialProduct temp = other as SpecialProduct;
            if (temp == null)
            {
                return false;
            }
            return base.Equals(other) && extraPrice.Equals(temp.extraPrice) && totalPrice.Equals(temp.totalPrice);
        }
    }
}