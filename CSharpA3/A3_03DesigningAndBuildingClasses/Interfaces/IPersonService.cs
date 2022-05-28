using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_03DesigningAndBuildingClasses.Interfaces
{
    public interface IPersonService
    {
        int CalculateAge();
        decimal CalculateSalary();
        string[] GetAddresses();
    }
}
