using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Persons.Customers
{
    public class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmmount;
    
     public Customer
            (int customerID, string customerFirstName, string customerLastName, decimal purchaseAmmountOnce)
            : base(customerID, customerFirstName, customerLastName)
        {
            this.netPurchaseAmmount = CalculateNetAmmount(purchaseAmmountOnce);
        }

     decimal totalAmmount = 0;
     public decimal CalculateNetAmmount(decimal ammountOnce)
     {   
        totalAmmount+= ammountOnce;
        return totalAmmount;
     }
    }
}
