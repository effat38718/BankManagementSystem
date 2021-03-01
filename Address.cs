using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    class Address
    {
        private string roadNo;
        private string houseNo;
        private string city;
        private string country;

        public string RoadNo
        {
            set { this.roadNo = value; }
            get { return this.roadNo; }
        }

        public string HouseNo
        {
            set { this.houseNo = value; }
            get { return this.houseNo; }
        }

        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }

        public string Country
        {
            set { this.country = value; }
            get { return this.country; }
        }


        public string GetAddress()
        {
            return "Road No: " + this.roadNo + ", House No: " + this.houseNo + ", City: " + this.city + ", Country: " + this.country;
        }

    }
}
