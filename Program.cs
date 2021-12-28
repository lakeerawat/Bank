using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class bank
    {
        private double balance = 999999;


        public double bal
        {
            get { return balance; }
            set { balance = value; }
        }
    }
    class fuctions
    {
        bank i = new bank();
        string name;
        int account;
        double withdraw, dep, tobal;

        public void function1()
        {
            Console.WriteLine("write the Name of the depositor :");
            name = Console.ReadLine();
            Console.WriteLine("wrte the Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write Deposit Amount :");
            dep = Convert.ToDouble(Console.ReadLine());
            tobal = i.bal + dep;

            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Name of the depositor : " + name);
            Console.WriteLine("Account Number: " + account);
            Console.WriteLine("Total Balance amount in the account  : " + tobal);

        }
        public void function2()
        {
            Console.WriteLine("write the  Account Name :");
            name = Console.ReadLine();
            Console.WriteLine("write the  Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write Withdraw Amount :");
            withdraw = Convert.ToDouble(Console.ReadLine());
            if (withdraw <= i.bal)
            {
                tobal = i.bal - withdraw;
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("Account Name : " + name);
                Console.WriteLine("Account Number: " + account);
                Console.WriteLine("After Withdraw Amount balnace is : " + tobal);
            }
            else
                Console.WriteLine("\n\nWithdraw Ammount does not Exist your Account.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            char agn;
            do
            {
                fuctions k = new fuctions();
                int num;
                Console.WriteLine("Please Select Any Function.");
                Console.WriteLine("\nPress 1 for Deposit an Amount. \nPress 2 for Withdraw an Amount.");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        k.function1();
                        break;
                    case 2:
                        k.function2();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection!!!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue this program? (y/n)");
                agn = Convert.ToChar(Console.ReadLine());

            } while (agn == 'y');

            Console.ReadKey();
        }
    }
}