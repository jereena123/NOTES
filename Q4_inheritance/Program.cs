using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_inheritance
{
    internal class Program
    {
        static void Main()
        {
            Student student1 = new Student("Alice", "S123", 1001, Major.Graduate, StudentType.Undergraduate);
            Professor professor1 = new Professor("Dr. Smith", "P456", 2001, Major.Graduate);
            Course course1 = new Course("Computer Science", 12);

            student1.Study();
            professor1.Teach();
            course1.CourseDetails();
        }
    
}
    }

