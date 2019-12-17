namespace Exercise03
{
    /// <summary>
    /// Add a static field for the class Student, which holds the number of created objects of this class.
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
    }
}