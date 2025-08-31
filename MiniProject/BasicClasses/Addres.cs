using System;

namespace MiniProject
{
    public class Address
    {
        // Fields of the Address class.
        private string street;
        private string city;
        private string state;
        private string buildingNum;

        // Constructor for the Address class. Takes in a street, city, state, and building number.
        public Address(string street, string city, string state, string buildingNum)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.buildingNum = buildingNum;
        }

        // Getters and setters for the fields of the Address class.
        public string GetStreet()
        {
            return this.street;
        }

        public bool SetStreet(string street)
        {
            if (string.IsNullOrEmpty(street))
            {
                throw new ArgumentException("Street cannot be null or empty.");
            }
            this.street = street;
            return true;
        }

        public string GetCity()
        {
            return this.city;
        }

        public bool SetCity(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                throw new ArgumentException("City cannot be null or empty.");
            }
            this.city = city;
            return true;
        }

        public string GetState()
        {
            return this.state;
        }

        public bool SetState(string state)
        {
            if (string.IsNullOrEmpty(state))
            {
                throw new ArgumentException("State cannot be null or empty.");
            }
            this.state = state;
            return true;
        }

        public string GetBuildingNum()
        {
            return this.buildingNum;
        }

        public bool SetBuildingNum(string buildingNum)
        {
            if (string.IsNullOrEmpty(buildingNum))
            {
                throw new ArgumentException("Building number cannot be null or empty.");
            }
            this.buildingNum = buildingNum;
            return true;
        }

        // ToString method to return a string representation of the Address object.
        public override string ToString()
        {
            return $"{this.street},{this.city},{this.state},{this.buildingNum}";
        }

        // Equals method to compare two Address objects.
        public override bool Equals(object other)
        {
            Address temp = other as Address;
            if (temp == null)
            {
                return false;
            }
            return street.Equals(temp.street) && city.Equals(temp.city) && state.Equals(temp.state) && buildingNum.Equals(temp.buildingNum);
        }
    }
}