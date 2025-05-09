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
            string userName=null, password=null;

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
                System.Console.WriteLine("TO DO: Main menu here");
            }

            //about to exit
            System.Console.WriteLine("thank you! Visit again.");
            System.Console.ReadKey();
        }
    }
}
