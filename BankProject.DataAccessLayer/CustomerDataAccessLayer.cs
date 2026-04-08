using BankProject.DataAcessLayer.ADLContracts;
using System.Collections.Generic;
using BankProject.Entities;
using BankProject.Exceptions;
using System;
namespace BankProject.DataAccessLayer
{
    /// <summary>
    /// Represents DAL for bank customers
    /// </summary>
    public class CustomerDataAccessLayer : ICustomerDataAcessLayer
    {
        #region Fields
        private static List<Customer> _customers;
        #endregion
        #region Properties
        private static List<Customer> Customers
        {
            get => _customers;
            set => _customers = value;
        }
        #endregion
        #region Constructor
        static CustomerDataAccessLayer()
        {
            _customers = new List<Customer>();
        }
        #endregion
        #region Methods
        /// <summary>
        /// Returns all existing customers
        /// </summary>
        /// <returns>Customers list</returns>
        public List<Customer> GetCustomers()
        {
            try
            {
                //Creates a new customer list
                var customerList = new List<Customer>();
                _customers.ForEach(customer => customerList.Add((Customer)customer.Clone()));
                return customerList;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Returns list of customers that are matching with specified criteria
        /// </summary>
        /// <param name="predicate">Lambda expression with condition</param>
        /// <returns>List of matching customers</returns>
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            try
            {
                //create a new customer list
                var customersList = new List<Customer>();
                //filter the collection
                var filteredCustomers = _customers.FindAll(predicate);
                //copy all customers from the source collection into the newCustomers list
                filteredCustomers.ForEach(customer => customersList.Add(customer.Clone() as Customer));
                return customersList;
            }
            catch (CustomerException) 
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Adds a new customer to the existing list
        /// </summary>
        /// <param name="customer">Customer object to add</param>
        /// <returns>Returns Guid of newly created customer</returns>
        public Guid AddCustomer(Customer customer)
        {
            try
            {
                //generate new GUID
                customer.CustomerID = Guid.NewGuid();
                //add customer
                _customers.Add(customer);
                return customer.CustomerID;
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Updates an existing customer's details
        /// </summary>
        /// <param name="customer">Customer object with updated details</param>
        /// <returns>Determines whether the customer is updated or not</returns>
        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                //find existing customer by CustomerID
                Customer existingCustomer = _customers.Find(c => c.CustomerID == customer.CustomerID);
                //update all details of customer
                if (existingCustomer != null)
                {
                    existingCustomer.CostumerCode = customer.CostumerCode;
                    existingCustomer.CostumerName = customer.CostumerName;
                    existingCustomer.Addres = customer.Addres;
                    existingCustomer.Landmark = customer.Landmark;
                    existingCustomer.City = customer.City;
                    existingCustomer.Country = customer.Country;
                    existingCustomer.Mobile = customer.Mobile;
                    return true; //indicates the customer is updated
                }
                else
                {
                    return false; //indicates no object is updated
                }
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Deletes an existing customer based on customerID
        /// </summary>
        /// <param name="customerID">CustomerID to delete</param>
        /// <returns>Indicates whether the customer is deleted or not</returns>
        public bool DeleteCustomer(Guid customerID)
        {
            try
            {
                if (_customers.RemoveAll(item => item.CustomerID == customerID) > 0)
                {
                    return true; // indicates one or more customers are deleted
                }
                else
                {
                    return false; //indicates no customer are deleted
                }
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        #endregion
    }
}
