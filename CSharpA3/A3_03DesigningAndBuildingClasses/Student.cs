using A3_03DesigningAndBuildingClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_03DesigningAndBuildingClasses
{
    internal class Student : Person, IStudentService
    {
        List<Course> EnrolledCourses { get; set; }
        Dictionary<Course, char> Grades { get; set; }
        public float CalculateGPA()
        {
            throw new NotImplementedException();
        }
    }
}
