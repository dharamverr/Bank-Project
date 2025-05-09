using System;
using System.Collections.Generic;
using System.Linq;
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
                        case 1://Customers
                            break;
                        case 2: //Accounts
                            break;
                        case 3://Funds Transfer
                            break;
                        case 4://Funds Transfer Statment
                            break;
                        case 5://Account Statement
                            break;


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
    }
}
