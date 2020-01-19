namespace Exercise02
{
    /// <summary>
    /// Declare several constructors for the class Student, which have different lists of parameters (for complete information about a student or part of it).
    /// Data, which has no initial value to be initialized with null. Use nullable types for all non-mandatory data.
    /// </summary>
    internal class Student
    {
        private string fullName;
        private string course;
        private string subject;
        private string university;
        private string eMail;
        private string phoneNumber;

        public Student(string fullName, string course, string subject, string university, string eMail, string phoneNumber)
        {
            this.fullName = fullName;
            this.course = course;
            this.subject = subject;
            this.university = university;
            this.eMail = eMail;
            this.phoneNumber = phoneNumber;
        }

        public Student(string fullName, string course, string subject, string university)
            : this(fullName, course, subject, university, null, null)
        {
        }

        public Student(string fullName, string university) : this(fullName, null, null, university, null, null)
        {
        }
    }
}