using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    class Bank
    {
        public static int counter = 0;
        private string bankName;
        public Account[] myBank;

        public string Bankname
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }

        public Bank()
        {
            this.myBank = new Account[100];
        }

        public void AddAccount()
        {
            Account account = new Account(counter);
            
            Console.WriteLine("Enter your A/C Name: ");
            account.accountName = Console.ReadLine();
            Console.WriteLine("How Much Money you want to Deposit in the beginning : ");
            account.balance = Convert.ToInt32(Console.ReadLine());
            account.setAddress();
            account.ShowAccountInformation();
            myBank[counter] = account;
            counter++;
            Console.WriteLine();
            Console.WriteLine("ACCOUNT CREATED SUCCESSFULLY!");
            //myBank[Account.accountNumber] = account;
            //This record need to be kept in a database or a text file in JSON format
            //launchAgain();
        }
        public void DeleteAccount(int accountNumber)
        {
            for (int i = accountNumber - 1; i<myBank.Length; i++)
            {
                myBank[i] = myBank[i + 1];
            }
            Console.WriteLine();
            Console.WriteLine("ACCOUNT DELETED SUCCESSFULLY!");
        }
        public void Transaction(int transactionType, int acNo)
        {
            
            if (transactionType == 1)
            {
                Console.WriteLine("ENTER THE AMOUNT YOU WANT TO WITHDRAW : ");
                double amount = Convert.ToDouble(Console.ReadLine());
                this.myBank[acNo].Withdraw(amount);
                //launchAgain();
            }
            else if (transactionType == 2)
            {
                Console.WriteLine("ENTER THE AMOUNT YOU WANT TO DEPOSIT : ");
                double amount = Convert.ToDouble(Console.ReadLine());
                this.myBank[acNo].Deposit(amount);
                //launchAgain();
            }
            else if(transactionType == 3)
            {
                Console.WriteLine("ENTER THE A/C NO YOU WANT TO TRANSFER TO: ");
                int accountNo = Convert.ToInt32(Console.ReadLine());
                Account receiver = myBank[accountNo];
                Console.WriteLine("ENTER THE AMOUNT YOU WANT TO TRANSFER: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                this.myBank[acNo].Transfer(receiver,amount);
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

            this.myBank[accountNo].ShowAccountInformation();
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
