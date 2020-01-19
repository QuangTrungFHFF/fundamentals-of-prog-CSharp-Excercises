using System.Text;

namespace Exercise06
{
    /// <summary>
    /// Modify the current source code of Student class so as to encapsulate the data in the class using properties.
    /// </summary>
    internal class Student
    {
        private static int numberOfStudent;

        public Student(string fullName, int course, string subject, string university, string email, string phoneNumber)
        {
            this.FullName = fullName;
            this.Course = course;
            this.Subject = subject;
            this.University = university;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
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
        /// <returns>String contains info about students</returns>
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Student name: " + FullName);
            info.Append(System.Environment.NewLine);
            info.Append("Course: " + Course);
            info.Append(System.Environment.NewLine);
            info.Append("Subject: " + Subject);
            info.Append(System.Environment.NewLine);
            info.Append("University: " + University);
            info.Append(System.Environment.NewLine);
            info.Append("E-Mail: " + Email);
            info.Append(System.Environment.NewLine);
            info.Append("Telephone: " + PhoneNumber);
            return info.ToString();
        }

        public static int GetNumberOfStudents
        {
            get { return Student.numberOfStudent; }
            set { numberOfStudent = value; }
        }

        public string FullName { get; set; }
        public int Course { get; set; }
        public string Subject { get; set; }
        public string University { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}