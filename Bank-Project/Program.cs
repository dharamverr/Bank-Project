using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    internal class Program
    {
        static void Main(string[] args) // Application execution start from here
        {
            //display title
            System.Console.WriteLine("***********************Harsha Bank*******************");
            System.Console.WriteLine("::Login Page::");

            //declare variable to store userName and Password
            string userName = null, password = null;

            //read userName from keyword
            System.Console.Write("Enter Username:");
            userName = Console.ReadLine();

            //read password from keyboard only if username is enterd
            if (userName != "")
            {
                //read password from keyword
                System.Console.Write("Enter password:");
                password = Console.ReadLine();
            }

            // check username and password
            if (userName == "system" && password == "manager")
            {
                int mainMenuChoice = -1;
                do
                {
                    System.Console.WriteLine("\n:::Main Menu:::");
                    System.Console.WriteLine("1. Customers");
                    System.Console.WriteLine("2. Accounts");
                    System.Console.WriteLine("3. Funds Transfer");
                    System.Console.WriteLine("4. Funds Transfer Statement");
                    System.Console.WriteLine("5. Account Statement");
                    System.Console.WriteLine("0. Exit");



                    System.Console.WriteLine("Enter your choice");
                    mainMenuChoice = int.Parse(Console.ReadLine());
                    switch (mainMenuChoice)
                    {
                        case 1:CustomerManu(); break;
                        case 2:AccountManu(); break;
                        case 3:FundsTransferMenu();break;
                        case 4:FundsTransferStatmentMenu();break;
                        case 5:AccountStatementMenu(); break;
                    }
                } while (mainMenuChoice != 0);
            }
            else {
                System.Console.WriteLine("Invalid userName or password");
            }
            //about to exit
            System.Console.WriteLine("thank you! Visit again.");
            System.Console.ReadKey();
        }

        static void CustomerManu()
        {
            int custmerMenuChoice = -1;

            do
            {
                System.Console.WriteLine("\n:::Customer Menu:::");
                System.Console.WriteLine("1. Add Customer");
                System.Console.WriteLine("2. Delete Customer");
                System.Console.WriteLine("3. Update Customer");
                System.Console.WriteLine("4. View Customers");
                System.Console.WriteLine("0. Back To Main Menu");

                System.Console.WriteLine("Enter Choice");
                custmerMenuChoice = System.Convert.ToInt32(Console.ReadLine());

                switch (custmerMenuChoice) { 
                   case 1://AddCustomer();
                          break;
                   case 2: //DeleteCustomer();
                        break; 
                   case 3: //UpdateCustomer();
                        break;
                   case 4: //ViewCustomer();
                        break;
                }

            } while (custmerMenuChoice != 0);


        }

        static void AccountManu()
        {
            int accountMenuChoice = -1;

            do
            {
                System.Console.WriteLine("\n:::Account Menu:::");
                System.Console.WriteLine("1. Add Account");
                System.Console.WriteLine("2. Delete Account");
                System.Console.WriteLine("3. Update Account");
                System.Console.WriteLine("4. View Accounts");
                System.Console.WriteLine("0. Back To Main Menu");

                System.Console.WriteLine("Enter Choice");
                accountMenuChoice = System.Convert.ToInt32(Console.ReadLine());

                switch (accountMenuChoice)
                {
                    case 1://AddAccount();
                        break;
                    case 2: //DeleteAccount();
                        break;
                    case 3: //UpdateAccount();
                        break;
                    case 4: //ViewAccounts();
                        break;
                }

            } while (accountMenuChoice != 0);
        }

        static void FundsTransferMenu()
        {

        }

        static void FundsTransferStatmentMenu()
        {

        }

        static void AccountStatementMenu()
        {

        }
    }
}
