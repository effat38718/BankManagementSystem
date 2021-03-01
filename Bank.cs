using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    class Bank
    {
        private string bankName;
        Account[] myBank;

        public string Bankname
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }

        public void AddAccount()
        {
            Account account = new Account();
            account.accountNumber = 1;
            account.accountName = "Careless";
            account.balance = 1000;
            account.setAddress();
            account.ShowAccountInformation();
            Console.WriteLine(account.getAddress());
        }
        public void DeleteAccount(int accountNumber)
        {

        }
        public void Transaction(int transactionType)
        {

        }
        public void PrintAccountDetails()
        {

        }
    }
}
