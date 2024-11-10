using sacs.entity;
using System;


namespace assignment3
{
    class Program
    {
        public static class EmailService
        {
            public static void SendConfirmationEmail(User user, bool success = true)
            {
                if (success)
                {
                    Console.WriteLine($"Email sent to {user.User_Name} ({user.User_ContactInfo}) confirming assessment submission.");
                }
                else
                {
                    Console.WriteLine($"Email delivery failed to {user.User_Name} ({user.User_ContactInfo}).");
                }
            }
        }

        public static class PlagiarismService
        {
            public static void CheckPlagiarism(Assessment assessment)
            {
                Console.WriteLine($"Plagiarism check initiated for assessment: {assessment.Assessment_Title}");
                // Simulate report creation
                assessment.CreatePlagiarismReport();
            }

            public static void UploadReport(Assessment assessment, bool success = true)
            {
                if (success)
                {
                    Console.WriteLine($"Plagiarism report uploaded for assessment: {assessment.Assessment_Title}.");
                }
                else
                {
                    Console.WriteLine($"Uploading plagiarism report failed for assessment: {assessment.Assessment_Title}.");
                }
            }
        }
        public static class InstructorExtensions
        {
            
        }

        static void Main(string[] args)
        {
            Group group = new Group("1", "101");
          

            group.AddAssessment(new Assessment("A1", "Math Assessment", "101"));
            group.AddAssessment(new Assessment("A2", "Science Assessment", "101"));

            group.SearchassessmentByGroupnum("101");

            group.ViewAssessments();

            group.DistributeWorkload(20);

            group.SearchassessmentByGroupnum("999");

            group.DistributeWorkload(100);

            group.SubmitAssessment("A1", ".pdf");

            group.CheckGrade("A1");

            group.SearchassessmentByGroupnum("999");

            group.SubmitAssessment("A2", ".jpg");

            User student1 = new User("S1", "John Doe", "john@example.com", "Computer Science");
            Instructor instructor1 = new Instructor("I1", "Dr. Smith", "smith@example.com", "Mathematics");

            Assessment assessment = new Assessment("A1", "Final Project", "Project", "2024-11-10");

            Console.WriteLine("Standard Case: Students submit assessments.");
            assessment.SubmitAssessment(student1);

            Console.WriteLine("\nStandard Case: Confirm email delivery to students and instructors.");
            EmailService.SendConfirmationEmail(student1);
            EmailService.SendConfirmationEmail(instructor1);

            Console.WriteLine("\nStandard Case: Check plagiarism and create reports.");
            PlagiarismService.CheckPlagiarism(assessment);

            Console.WriteLine("\nStandard Case: Instructors and students view reports.");
            instructor1.ViewReport(assessment);

            Console.WriteLine("\nEdge Case: Simulating email delivery failure.");
            EmailService.SendConfirmationEmail(student1, false);

            Console.WriteLine("\nEdge Case: Simulating plagiarism report upload failure.");
            PlagiarismService.UploadReport(assessment, false);

            Instructor instructor = new Instructor("I1", "Dr. Smith", "Mathematics", "Mathematics@gmail.com");

            Manage assessmentManagement = new Manage("A1");

            Console.WriteLine("Standard Case: Instructors can open assessments and see details.");
            instructor.OpenAssessment(assessmentManagement);

            Console.WriteLine("\nStandard Case: Instructors can grade assessments.");
            Grade grade = new Grade("A1", 85);
            instructor.GradeAssessment(grade);

            Console.WriteLine("\nStandard Case: Instructors can generate feedback.");
            instructor.GenerateFeedback("Excellent work on the assessment!");

            Console.WriteLine("\nEdge Case: Instructors cannot open assessments due to timeout loading.");
            

            Console.WriteLine("\nEdge Case: Storing feedback fails due to server down.");
           instructor.GenerateFeedback("Excellent work on the assessment!");
            
        }
    }
}
