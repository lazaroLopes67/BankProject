using BankProject.Entities;
using System;
using BankProject.BusinessLogicLayer;
using BankProject.BusinessLogicLayer.BALContracts;
using System.Collections.Generic;
namespace Presentation
{
    static class CustomerPresentation
    {
        internal static void AddCustomer()
        {
            try
            {
                //create an object of Customer
                Customer customer = new Customer();
                Console.WriteLine("\n**********ADD CUSTOMER**********");
                Console.Write("Customer Name:");
                customer.CostumerName = Console.ReadLine();
                Console.Write("Customer Address: ");
                customer.Addres = Console.ReadLine();
                Console.Write("LandMark: ");
                customer.Landmark = Console.ReadLine();
                Console.Write("City: ");
                customer.City = Console.ReadLine();
                Console.Write("Country: ");
                customer.Country = Console.ReadLine();
                Console.Write("Mobile: ");
                customer.Mobile = Console.ReadLine();
                ICustomersBusinessLogicLayer customersBussinessLogicLayer = new CustomersBusinessLogicLayer();
                Guid newGuid = customersBussinessLogicLayer.AddCustomer(customer);
                var matchElements = customersBussinessLogicLayer.GetCustomersByCondition(item => item.CustomerID == customer.CustomerID);
                Console.WriteLine(matchElements[0].CostumerCode);
                Console.WriteLine("Customer added.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }

        }
        internal static void ViewCustomers()
        {
            try
            {
                ICustomersBusinessLogicLayer customersBusinessLogicLayer = new CustomersBusinessLogicLayer();
                List<Customer> allCustomer = customersBusinessLogicLayer.GetCustomers();
                Console.WriteLine("\n**********ALL CUSTOMERS**********");
                foreach(Customer item in allCustomer)
                {
                    Console.WriteLine($"Customer Code: {item.CostumerCode}");
                    Console.WriteLine($"Customer Name: {item.CostumerName}");
                    Console.WriteLine($"Addres: {item.Addres}");
                    Console.WriteLine($"Landmark: {item.Landmark}");
                    Console.WriteLine($"City: {item.City}");
                    Console.WriteLine($"Country: {item.Country}");
                    Console.WriteLine($"Mobile: {item.Mobile}");
                    Console.WriteLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
        }
    }
}
