using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Persons.Customers
{
    public interface ICustomer
    {
        decimal CalculateNetAmmount(decimal ammountOnce);
    }
}
