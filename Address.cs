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

        public Address(string roadNo,string houseNo,string city,string country)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.city = city;
            this.country = country;
        }


        public string GetAddress()
        {
            return "Road No: " + this.roadNo + ", House No: " + this.houseNo + ", City: " + this.city + ", Country: " + this.country;
        }

    }
}
