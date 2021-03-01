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
            if(serviceNo == 1)
            {

            }
            else if(serviceNo == 2)
            {

            }
            else if (serviceNo == 3)
            {

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
