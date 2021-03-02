using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    class Account
    {
        public int accountNumber ;
        public string accountName { get; set; }
        public double balance { get; set; }
        private Address address;

        public Account(int accountNumber) {
            /*TextReader reader = File.OpenText("E:/AIUB/8th semester/OOP2 (C#)/code/BankManagementSystem/currentAccountNo.txt");
            accountNumber = int.Parse(reader.ReadLine());
            accountNumber++;
            reader.Close();
            StreamWriter sw = new StreamWriter("E:/AIUB/8th semester/OOP2 (C#)/code/BankManagementSystem/currentAccountNo.txt");
            sw.Write(accountNumber);
            sw.Close();*/
            this.accountNumber = accountNumber;
        }

        public void setAddress()
        {
                var addressInfo = this.takeAddressInput();
                this.address= new Address(addressInfo.Item1,addressInfo.Item2,addressInfo.Item3,addressInfo.Item4); 
        }

        public string getAddress()
        {
            return this.address.GetAddress();
        }

        public void Withdraw(double amount)
        {
            balance = balance - amount;
        }
        public void Deposit(double amount)
        {

        }
        public void Transfer(Account reciever, double amount)
        {
            reciever.balance += amount;
            //sender.balance -= amount;
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine("Account Number: " + this.accountNumber + "  Account Name: " + this.accountName + "  Balance: " + this.balance);
            Console.WriteLine(this.getAddress());
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
