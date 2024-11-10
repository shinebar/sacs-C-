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
            public static async Task OpenAssessmentWithTimeout(this Instructor instructor, Admin admin)
            {
                // Simulate the timeout
                await Task.Delay(5000); // Simulate a long loading time
                Console.WriteLine($"Failed to open assessment with ID: {manage.ManageId} due to timeout.");
            }

            public static bool StoreFeedback(this Instructor instructor, Feedback feedback, bool success = true)
            {
                if (success)
                {
                    Console.WriteLine($"Feedback stored: {feedback.FeedbackText}");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Failed to store feedback: {feedback.FeedbackText}.");
                    return false;
                }
            }
        }

        static void Main(string[] args)
        {
            Group group = new Group("1", "101");
            group.AddMember(new User("U1", "Alice"));
            group.AddMember(new User("U2", "Bob"));

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
            Instructor instructor1 = new User("I1", "Dr. Smith", "smith@example.com", "Mathematics");

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
            student1.ViewReport(assessment);

            Console.WriteLine("\nEdge Case: Simulating email delivery failure.");
            EmailService.SendConfirmationEmail(student1, false);

            Console.WriteLine("\nEdge Case: Simulating plagiarism report upload failure.");
            PlagiarismService.UploadReport(assessment, false);

            Instructor instructor = new Instructor("I1", "Dr. Smith", "Mathematics");

            Manage assessmentManagement = new Manage("A1");

            Console.WriteLine("Standard Case: Instructors can open assessments and see details.");
            instructor.OpenAssessment(assessmentManagement);

            Console.WriteLine("\nStandard Case: Instructors can grade assessments.");
            Grade grade = new Grade("A1", 85);
            instructor.GradeAssessment(grade);

            Console.WriteLine("\nStandard Case: Instructors can generate feedback.");
            Feedback feedback = new Feedback("Excellent work on the assessment!");
            instructor.GenerateFeedback(feedback);

            Console.WriteLine("\nEdge Case: Instructors cannot open assessments due to timeout loading.");
            await instructor.OpenAssessmentWithTimeout(assessmentManagement);

            Console.WriteLine("\nEdge Case: Storing feedback fails due to server down.");
            bool feedbackStored = instructor.StoreFeedback(feedback, false);
            if (!feedbackStored)
            {
                Console.WriteLine("Feedback could not be stored due to server issues.");
            }
        }
    }
}
