using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; }

        public virtual void AssingManager (Employee manager)
        {
            Manager = manager;
        }

        public void AssingManager (IEmployee manager)
        {
            Manager = manager;
        }
    }
}
