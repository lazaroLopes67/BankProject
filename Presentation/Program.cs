using Presentation;
using System;

class Program
{
    //Application execution starts here
    static void Main()
    {
        //display title
        Console.WriteLine("*********Banco Master - a volta dos que não foram*********");
        Console.WriteLine("::Login Page::");
        //declare variables to store username and password
        string userName = null, password = null;
        //read userName from keyboard
        Console.Write("Username: ");
        userName = Console.ReadLine();
        //read password from keyboard only if userName is not null
        if(userName != null)
        {
            Console.Write("Password: ");
            password = Console.ReadLine();
        }
        if(userName == "system" && password == "manager")
        {
            int mainMenuChoice = -1;
            do
            {
                Console.WriteLine("\n:::Main menu:::");
                Console.WriteLine("1.Customers");
                Console.WriteLine("2.Accounts");
                Console.WriteLine("3.Funds Transfer");
                Console.WriteLine("4.Funds Tranfers Statement");
                Console.WriteLine("5.Account Statement");
                Console.WriteLine("0.Exit");
                Console.Write("Enter choice: ");
                mainMenuChoice = Convert.ToInt32(Console.ReadLine());
                switch (mainMenuChoice)
                {
                    case 1:
                        CustomersMenu();
                        break;
                    case 2: //FAZER MENU DE CONTAS
                        break;
                    case 3: //FAZER MENU DE FUNDS TRANFER
                        break;
                    case 4: //FAZER MENU DE FUNDS TRANFERS STATEMENTS
                        break;
                    case 5: //FAZER MENU DE ACCOUNT
                        break;
                    case 0: //SAIR
                        break;
                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            Console.WriteLine("Invalid username or password.");
        }

    }
    static void CustomersMenu()
    {
        //variable to store customers menu choice
        int customerMenuChoice = -1;
        do
        {
            //print customers menu
            Console.WriteLine("\n::Customers menu::");
            Console.WriteLine("1.Add Customer");
            Console.WriteLine("2.Delete Customer");
            Console.WriteLine("3.Update Customer");
            Console.WriteLine("4.Search Customers");
            Console.WriteLine("5.View Customers");
            Console.WriteLine("0.Back to Main Menu");
            Console.Write("Enter choice: ");

            //accept customers menu choice
            customerMenuChoice = Convert.ToInt32(Console.ReadLine());
            switch (customerMenuChoice)
            {
                case 1:
                    CustomerPresentation.AddCustomer();
                    break;
                case 5:
                    CustomerPresentation.ViewCustomers();
                    break;
                case 0:
                        break;
                    }
        } while (customerMenuChoice != 0);
    }
}