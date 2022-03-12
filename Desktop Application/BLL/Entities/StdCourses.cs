using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StdCourses
    {
        public int Std_Id { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();
       
    }
}
