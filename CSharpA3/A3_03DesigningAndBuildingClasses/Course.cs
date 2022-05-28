using A3_03DesigningAndBuildingClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_03DesigningAndBuildingClasses
{
    public class Course : ICourseService
    {
        string CourseName { get; set; }
        List<Student> EnrolledStudents { get; set; }
    }
}
