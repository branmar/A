using A3_03DesigningAndBuildingClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_03DesigningAndBuildingClasses
{
    public class Person : IPersonService
    {
        public DateTime Birthday { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public int CalculateAge()
        {
            throw new NotImplementedException();
        }

        public virtual decimal CalculateSalary()
        {
            throw new NotImplementedException();
        }

        public string[] GetAddresses()
        {
            throw new NotImplementedException();
        }
    }
}
