using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    class Account
    {
        private int accountNumber { get; set; }
        private string accountName { get; set; }
        private double balance { get; set; }
        private Address address { get; set; }

        public void setAddress()
        {
                var addressInfo = this.takeAddressInput();
                this.address= new Address(addressInfo.Item1,addressInfo.Item2,addressInfo.Item3,addressInfo.Item4); 
        }

        public void Withdraw(double amount)
        {

        }
        public void Deposit(double amount)
        {

        }
        public void Transfer(Account reciever, double amount)
        {
            
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine("Account Number: " + this.accountNumber + "Account Name: " + this.accountName + "Balance: " + this.balance);
        }

        public (string,string,string,string) takeAddressInput()
        {
            Console.WriteLine("Enter Your Road No : ");
            string roadNo = Console.ReadLine();
            Console.WriteLine("Enter Your House No: ");
            string houseNo = Console.ReadLine();
            Console.WriteLine("Enter your City : ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter Your Country : ");
            string country = Console.ReadLine();
            return (roadNo,houseNo, city, country);
        }

    }
}
