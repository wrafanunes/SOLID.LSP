using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /*quando uma super classe possui um comportamento, suas sub classes devem seguir o mesmo comportamento,
     * a aplicação agora respeita essa regra, pois todas as sub classes de BaseEmployee possuem o mesmo comportamento*/
    public abstract class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public virtual void CalculatePerHourRate (short rank)
        {
            decimal baseAmount = 12.50M;
            Salary = baseAmount + rank * 2;
        }
    }
}
