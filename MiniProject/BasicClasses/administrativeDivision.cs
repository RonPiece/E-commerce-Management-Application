using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    // administrativeDivision manages the Buyers and Sellers and stores their information.
    public class administrativeDivision
    {
        // Fields of the administrativeDivision class.
        private string name;
        private List<Buyer> buyers;
        private List<Seller> sellers;

        // Constructor for the administrativeDivision class.
        public administrativeDivision(string name, List<Buyer> buyers, List<Seller> sellers)
        {
            this.name = name;
            // ?? is the null-coalescing operator
            this.buyers = buyers ?? throw new ArgumentNullException(nameof(buyers), "Buyers cannot be null."); 
            this.sellers = sellers ?? throw new ArgumentNullException(nameof(sellers), "Sellers cannot be null.");
        }

        // Getters and setters for the fields of the administrativeDivision class.
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

        public List<Buyer> GetBuyers()
        {
            return this.buyers;
        }

        public void SetBuyers(List<Buyer> buyers)
        {
            if (buyers == null)
            {
                throw new ArgumentNullException(nameof(buyers), "Buyers cannot be null.");
            }
            this.buyers = buyers;
        }

        public List<Seller> GetSellers()
        {
            return this.sellers;
        }

        public void SetSellers(List<Seller> sellers)
        {
            if (sellers == null)
            {
                throw new ArgumentNullException(nameof(sellers), "Sellers cannot be null.");
            }
            this.sellers = sellers;
        }
    }
}