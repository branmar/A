using A3_03DesigningAndBuildingClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_03DesigningAndBuildingClasses
{
    public class Department : IDepartmentService
    {
        List<Course> Courses { get; set; }
        decimal Budget { get; set; }
        Instructor Head { get; set; }
    }
}
