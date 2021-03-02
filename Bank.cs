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
            myBank[Account.accountNumber] = new Account();
            Console.WriteLine("Enter your A/C Name: ");
            myBank[Account.accountNumber].accountName = Console.ReadLine();
            Console.WriteLine("How Much Money you want to Deposit in the beginning : ");
            myBank[Account.accountNumber].balance = Convert.ToInt32(Console.ReadLine());
            myBank[Account.accountNumber].setAddress();
            myBank[Account.accountNumber].ShowAccountInformation();
            Console.WriteLine("ACCOUNT CREATED SUCCESSFULLY!");
            //myBank[Account.accountNumber] = account;
            Account.accountNumber++;
            //This record need to be kept in a database or a text file in JSON format
            //launchAgain();
        }
        public void DeleteAccount(int accountNumber)
        {

        }
        public void Transaction(int transactionType, int acNo)
        {
            Account account = myBank[acNo];
            if (transactionType == 1)
            {
                Console.WriteLine("ENTER THE AMOUNT YOU WANT TO WITHDRAW : ");
                double amount = Convert.ToDouble(Console.ReadLine());
                account.Withdraw(amount);
                //launchAgain();
            }
            else if (transactionType == 2)
            {
                Console.WriteLine("ENTER THE AMOUNT YOU WANT TO DEPOSIT : ");
                double amount = Convert.ToDouble(Console.ReadLine());
                account.Deposit(amount);
                //launchAgain();
            }
            else if(transactionType == 3)
            {
                Console.WriteLine("ENTER THE A/C NO YOU WANT TO TRANSFER TO: ");
                int accountNo = Convert.ToInt32(Console.ReadLine());
                Account receiver = myBank[accountNo];
                Console.WriteLine("ENTER THE AMOUNT YOU WANT TO TRANSFER: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                account.Transfer(receiver,amount);
                //launchAgain();
            }
            else
            {
                Console.WriteLine("INPUT A VALID TRANSACTION TYPE!");
            }
        }
        public void PrintAccountDetails()
        {
            Console.WriteLine("ENTER YOUR A/C NO: ");
            int accountNo = Convert.ToInt32(Console.ReadLine());

            Account account = myBank[accountNo];
            account.ShowAccountInformation();
            //launchAgain();
        }

        /*public void launchAgain()
        {
            Console.WriteLine();
            Program program = new Program();
            program.launchApp();
            program.launchService();
        }*/
    }
}
