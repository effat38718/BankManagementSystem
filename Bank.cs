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
        Account[] myBank = new Account[100];

        public string Bankname
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }

        public void AddAccount()
        {
            Account account = new Account();
            Console.WriteLine("Enter your A/C Name: ");
            account.accountName = Console.ReadLine();
            Console.WriteLine("How Much Money you want to Deposit in the beginning : ");
            account.balance = Convert.ToInt32(Console.ReadLine());
            account.setAddress();
            account.ShowAccountInformation();
            Console.WriteLine("ACCOUNT CREATED SUCCESSFULLY!");
            myBank[Account.accountNumber] = account;
            Account.accountNumber++;
            //This record need to be kept in a database or a text file in JSON format
            Console.WriteLine();
            Program program = new Program();
            program.launchApp();
            program.launchService();
        }
        public void DeleteAccount(int accountNumber)
        {

        }
        public void Transaction(int transactionType, int acNo)
        {
            if (transactionType == 1)
            {

            }
            else if (transactionType == 2)
            {

            }
            else if(transactionType == 3)
            {

            }
            else
            {
                Console.WriteLine("INPUT A VALID TRANSACTION TYPE!");
            }
        }
        public void PrintAccountDetails()
        {

        }
    }
}
