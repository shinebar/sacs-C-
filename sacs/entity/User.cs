using System;

namespace sacs.entity
{
    public class User
    {
        // Properties to store user information
        public string User_Id { get; set; }
        public string User_Name { get; set; }
        public string User_ContactInfo { get; set; }
        public string User_Department { get; set; }

        // A reference to a Group object
        public Group Details { get; set; }

        // Default constructor
        public User() { }

        // Parameterized constructor to initialize the properties
        public User(string userId, string userName, string userContactInfo, string userDepartment)
        {
            User_Id = userId;
            User_Name = userName;
            User_ContactInfo = userContactInfo;
            User_Department = userDepartment;
        }
    }
}
