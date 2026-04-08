using System;

namespace BankProject.Entities.Contracts
{
    /// <summary>
    /// Represents interface of customer entity
    /// </summary>
    public interface ICustomer
    {
        //CostumerID
        Guid  CustomerID { get; set; }
        //CostumerCode
        long CostumerCode { get; set; }
        //Nome
        string CostumerName { get; set; }
        //Endereço
        string Addres {  get; set; }
        //Ponto de referência
        string Landmark {  get; set; }
        //País
        string Country { get; set; }
        //Mobile
        string Mobile { get; set; }
    
    }
}