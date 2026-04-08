using System;
namespace BankProject.Exceptions
{
    /// <summary>
    /// Exception class that represents error raised in Customer class
    /// </summary>
    public class CustomerException : ApplicationException
    {
        /// <summary>
        /// Constructor that initializes exception message
        /// </summary>
        ///<param name="message">exception message</param>
        public CustomerException(string message) : base(message)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">Constructor that initializes exception message and inner exception</param>
        /// <param name="innerException"></param>
        public CustomerException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}