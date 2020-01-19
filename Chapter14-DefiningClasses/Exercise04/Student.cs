using System.Text;

namespace Exercise04
{
    /// <summary>
    /// Add a method in the class Student, which displays complete information about the student.
    /// </summary>
    internal class Student
    {
        private static int numberOfStudent;
        private string fullName;
        private int course;
        private string subject;
        private string university;
        private string eMail;
        private string phoneNumber;

        public Student(string fullName, int course, string subject, string university, string eMail, string phoneNumber)
        {
            this.fullName = fullName;
            this.course = course;
            this.subject = subject;
            this.university = university;
            this.eMail = eMail;
            this.phoneNumber = phoneNumber;
        }

        public Student(string fullName, int course, string subject, string university)
            : this(fullName, course, subject, university, null, null)
        {
        }

        public Student(string fullName, string university) : this(fullName, 0, null, university, null, null)
        {
        }

        /// <summary>
        /// Display info about the student
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Student name: " + fullName);
            info.Append(System.Environment.NewLine);
            info.Append("Course: " + course);
            info.Append(System.Environment.NewLine);
            info.Append("Subject: " + subject);
            info.Append(System.Environment.NewLine);
            info.Append("University: " + university);
            info.Append(System.Environment.NewLine);
            info.Append("E-Mail: " + eMail);
            info.Append(System.Environment.NewLine);
            info.Append("Telephone: " + phoneNumber);
            return info.ToString();
        }
    }
}