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
