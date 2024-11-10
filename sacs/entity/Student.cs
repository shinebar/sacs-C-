using System;


namespace sacs.entity
{
    public class Student : User
    {

        // Default constructor, calls the base (User) class constructor
        public Student() : base() { }

        // Parameterized constructor, initializes both User and Student properties
        public Student(string userId, string userName, string userContactInfo, string userDepartment,
                      List<Unit> units)
            : base(userId, userName, userContactInfo, userDepartment)
        {
            Units = units ?? new List<Unit>();  // Ensure units is not null
        }

        // Student-specific properties
        public List<Unit> Units { get; set; }  // List of Units the student is enrolled in

    }
}
