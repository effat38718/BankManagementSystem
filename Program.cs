using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    class Program
    {

        public int serviceNo;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.launchApp();
            program.launchService();

            

        }

        public void launchApp()
        {
            Console.WriteLine("WELCOME TO MY BANK!!!");
            Console.WriteLine("HOW CAN I HELP YOU?");
            Console.WriteLine("=======================");
            Console.WriteLine("1 . Create An Account");
            Console.WriteLine("2 . Delete An Account");
            Console.WriteLine("3 . Do A Transaction");
            Console.WriteLine("4 . Show Account Details");
            Console.WriteLine("=======================");
            Console.WriteLine("Press the serial number to get a service");

            this.serviceNo = Convert.ToInt32(Console.ReadLine());            
        }

        public void launchService()
        {
            Bank bank = new Bank();

            if (serviceNo == 1)
            {
                bank.AddAccount();
            }
            else if(serviceNo == 2)
            {
                Console.WriteLine("Enter your A/C No: ");
                int accountNo = Console.Read();
                bank.DeleteAccount(accountNo);
            }
            else if (serviceNo == 3)
            {
                Console.WriteLine("ENTER YOUR A/C NO: ");
                int accountNo = Convert.ToInt32(Console.ReadLine());
                //check if the A/C No exist or not

                Console.WriteLine("WHAT TYPE OF TRANSACTION YOU WANT TO PERFORM? ");

                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Diposit");
                Console.WriteLine("3. Transfer");
                Console.WriteLine("=======================");
                Console.WriteLine("Press the Transaction Type");
                int transactionType = Convert.ToInt32(Console.ReadLine());
                bank.Transaction(transactionType,accountNo);
            }
            else if (serviceNo == 4)
            {

            } 
            else
            {
                Console.WriteLine("Choose a service number between 1-4");
            }
        }
    }
}
