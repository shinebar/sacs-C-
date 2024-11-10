using sacs.Tools;
using sacs.entity;

namespace sacs.controller
{
    public class StudentController
    {
        private AssignmentController AssignmentController;
        public string Profile { get; set; }
        public List<string> Groups { get; set; }
        private Student student { get; set; }
        private Assignment assignment{ get; set; }
        public StudentController(){
            
            Groups = new List<string>();
            Profile = "Default Profile";
        }

        public void invite_memebers_in_group(string memberId,string groupName)
        {
            Console.WriteLine($"{memberId} invited to join group '{groupName}'.");
        }

        public void create_group(string groupCode,string groupName)
        {
            Groups.Add(groupName);
            Console.WriteLine($"Group '{groupName}' created successfully.");
        }

        public void entry_group(string groupCode,string groupName)
        {
            if (Groups.Contains(groupName))
            {
                Console.WriteLine($"Successfully joined group '{groupName}'.");
            }
            else
            {
                Console.WriteLine($"Group '{groupName}' does not exist.");
            }
        }

        public void view_group()
        {
            Console.WriteLine("Groups:");
            foreach (var group in Groups)
            {
                Console.WriteLine($"- {group}");
            }
        }

        public void update_profile(User user)
        {
            Console.WriteLine($"Profile updated to: {user}");
        }

        public void trace_assignment_deadlines()
        {
            Console.WriteLine("Assignment Deadlines:");
            AssignmentController.trace_assignment_deadlines();
        }

        public void upload_assignment(String filepath)
        {
            Console.WriteLine($"Assignment '{filepath}' uploaded successfully.");

        }

        public void sumit_assignment(String filepath)
        {
            Console.WriteLine($"Assignment '{filepath}' submitted for review.");
        }
        // Method to view an assessment
        public void ViewAssessment(Assignment assignment)
        {
            Console.WriteLine($"{student.User_Name} is viewing the assignment with ID: {assignment.assigmentCode}");
        }

        // Method to submit an assessment
        public void SubmitAssessment(Assignment assignment)
        {
            Console.WriteLine($"{student.User_Name} submitted the assignment with ID: {assignment}");
        }

        // Method to check the grade
        public void CheckGrade(Assignment assignment)
        {
            Console.WriteLine($"{student.User_Name}'s grade for the assignment with ID: {assignment.assigmentCode} is {assignment}");
        }


    }
}
