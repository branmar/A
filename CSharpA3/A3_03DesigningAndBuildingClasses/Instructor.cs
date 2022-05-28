using A3_03DesigningAndBuildingClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_03DesigningAndBuildingClasses
{
    public class Instructor : Person, IInstructorService
    {
        Department InstructorDepartment { get; set; }
        bool DepartmentHead { get; set; }
        DateTime JoinDate { get; set; }

        public override decimal CalculateSalary()
        {
            throw new NotImplementedException();
        }

        public int GetYearsOfExperience()
        {
            throw new NotImplementedException();
        }
    }
}
