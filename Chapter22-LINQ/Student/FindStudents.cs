using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Student
{
    public class FindStudents
    {
        public static List<Student> GetStudentsWithFirstNameBeforeLastNameInAlphabetically(List<Student> students)
        {
            var result = from student in students
                         where (student.FirstName[0].CompareTo(student.LastName[0]) < 0)
                         select student;
            return result.ToList();
        }
    }
}
