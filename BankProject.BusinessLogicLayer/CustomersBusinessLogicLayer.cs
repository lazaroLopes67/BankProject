using System;
using System.Collections.Generic;
using BankProject.BusinessLogicLayer.BALContracts;
using BankProject.Configuration;
using BankProject.DataAccessLayer;
using BankProject.DataAcessLayer.ADLContracts;
using BankProject.Entities;
using BankProject.Exceptions;
namespace BankProject.BusinessLogicLayer
{
    public class CustomersBusinessLogicLayer : ICustomersBusinessLogicLayer
    {
        #region Private fields
        private ICustomerDataAcessLayer _customerDataAcessLayer;
        #endregion
        #region Constructor
        /// <summary>
        /// Constructor that iniciliazes CustomersDataAccessLayer
        /// </summary>
        public CustomersBusinessLogicLayer()
        {
            _customerDataAcessLayer = new CustomerDataAccessLayer();
        }
        #endregion
        #region Properties
        /// <summary>
        /// Private properties that represents reference of CustomersDataAccessLayer
        /// </summary>
        private ICustomerDataAcessLayer CustomersDataAccessLayer
        {
            set => _customerDataAcessLayer = value;
            get => _customerDataAcessLayer;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Returns all existing customers
        /// </summary>
        /// <returns>List of customers</returns>
        public List<Customer> GetCustomers()
        {
            try
            {
                //invoke Date Access Layer (DAL)
                return CustomersDataAccessLayer.GetCustomers();

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
        /// Represents a set of customers that matches with specified criteria
        /// </summary>
        /// <param name="predicate">Lambda expression that contains condition to check</param>
        /// <returns>The list of matching customers</returns>
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            try
            {
                //invoke Data Access Layer (DAL)
                return CustomersDataAccessLayer.GetCustomersByCondition(predicate);
            }
            catch(CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Adds a new customer the the existing customers list
        /// </summary>
        /// <param name="customer">The customer object to add</param>
        /// <returns>Returns true, taht indicates the customer is added successfully</returns>
        public Guid AddCustomer(Customer customer)
        {
            try
            {
                //get all customers
                List<Customer> customers = CustomersDataAccessLayer.GetCustomers();
                long maxCusNo = 0;
                foreach(var c in customers)
                {
                    if(c.CostumerCode > maxCusNo)
                    {
                        maxCusNo = c.CostumerCode;
                    }
                }
                //generates new customer no
                if (customers.Count >= 1)
                {
                    customer.CostumerCode = maxCusNo+1;
                }
                else
                {
                    customer.CostumerCode = Settings.BaseCustomerNo + 1;
                }
                //Invoke Data Access Layer (DAL)
                return CustomersDataAccessLayer.AddCustomer(customer);
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
        /// Updates an existing customer
        /// </summary>
        /// <param name="customer">CustomerID to delete</param>
        /// <returns>Returns true, that indicates the customer is deleted successfully</returns>
        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                //invoke the Data Access Layer (DAL)
                return CustomersDataAccessLayer.UpdateCustomer(customer);
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
        /// Deletes an existing customer
        /// </summary>
        /// <param name="customerID">CustomerID to delete</param>
        /// <returns>Return true, that indicates the customer is deleted successfully</returns>
        public bool DeleteCustomer(Guid customerID)
        {
            try
            {
                return CustomersDataAccessLayer.DeleteCustomer(customerID);
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