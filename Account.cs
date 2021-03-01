using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;

        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }

        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }

        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        public Address Address
        {
            set { this.Address = value; }
            get { return this.Address; }
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
            
        }
    }
}
