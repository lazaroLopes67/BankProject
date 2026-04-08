using BankProject.Entities.Contracts;
using BankProject.Exceptions;
using System;

namespace BankProject.Entities
{
    /// <summary>
    /// Represents a customer of the bank
    /// </summary>
    public class Customer : ICustomer, ICloneable
    {
        #region Private fields
        private Guid _customerID;
        private long _customerCode;
        private string _customerName;
        private string _addres;
        private string _landmark;
        private string _city;
        private string _country;
        private string _mobile;
        #endregion
        #region Properties
        /// <summary>
        /// Guid of Customer for Unique Identfication
        /// </summary>
        public Guid CustomerID 
        {
            get
            {
                return _customerID;
            }
            set
            {
                _customerID = value;
            }
        }
        /// <summary>
        /// Auto-generated code number of the customer
        /// </summary>
        public long CostumerCode
        {
            get
            {
                return _customerCode;
            }
            set
            {
                if (value > 0)
                {
                    _customerCode = value;
                } else
                {
                    throw new CustomerException("Customer code should be positive only.");
                }
            }
        }
        /// <summary>
        /// Name of the customer
        /// </summary>
        public string CostumerName 
        { 
            get 
                { return _customerName; 
            }
            set 
            {
                if (value.Length <= 40 && string.IsNullOrEmpty(value) == false)
                {
                    _customerName = value;
                } else
                {
                    throw new CustomerException("Customer Name should not be null and less than 40 characters long.");
                }
            }
        }
        /// <summary>
        /// Address of the customer 
        /// </summary>
        public string Addres { get => _addres; set => _addres = value; }
        /// <summary>
        /// Landmark of the customer
        /// </summary>
        public string Landmark { get => _landmark; set => _landmark = value; }
        /// <summary>
        /// City of the customer
        /// </summary>
        public string City { get => _city; set => _city = value; }
        /// <summary>
        /// Country of the customer
        /// </summary>
        public string Country { get => _country; set => _country = value; }
        /// <summary>
        /// 10-digit Mobile number of the customer
        /// </summary>
        public string Mobile
        {
            get => _mobile;
            set
            {
                if(value.Length == 10)
                {
                    _mobile = value;
                }
                else
                {
                    throw new CustomerException("Mobile Number should be a 10-digit number.");
                }
            }
        }
        #endregion
        #region Methods
        public object Clone()
        {
            return new Customer()
            {
                _customerID = this._customerID,
                _customerCode = this._customerCode,
                _customerName = this._customerName,
                _addres = this._addres,
                _landmark = this._landmark,
                _city = this._city,
                _country = this._country,
                _mobile = this._mobile,
            };
        }
        #endregion
    }
}
