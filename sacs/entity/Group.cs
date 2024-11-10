using System;


namespace sacs.entity
{
    public class Group
    {
        public string Group_Id { get; set; }
        public string Group_Number { get; set; }
        public string Group_Code { get; set; }
        public List<User> Group_Members { get; set; } = new List<User>();
        public List<Assessment> Assessments { get; set; } = new List<Assessment>();

        public Group(string groupId, string groupNumber)
        {
            Group_Id = groupId;
            Group_Number = groupNumber;
        }

        public void AddMember(User member)
        {
            Group_Members.Add(member);
            Console.WriteLine($"User '{member.User_Name}' added to group {Group_Number}.");
        }

        public void AddAssessment(Assessment assessment)
        {
            Assessments.Add(assessment);
            Console.WriteLine($"Assessment '{assessment.Assessment_Title}' added to group {Group_Number}.");
        }

        // Method to search assessments by group number
        public void SearchassessmentByGroupnum(string groupNumber)
        {
            if (Group_Number == groupNumber)
            {
                Console.WriteLine($"Assessments for Group {groupNumber}:");
                foreach (var assessment in Assessments)
                {
                    Console.WriteLine($"- {assessment.Assessment_Title} (ID: {assessment.Assessment_Id})");
                }
            }
            else
            {
                Console.WriteLine($"Error: No assessments found for Group {groupNumber}.");
            }
        }

        // Method to view all assessments for the group
        public void ViewAssessments()
        {
            if (Assessments.Any())
            {
                Console.WriteLine($"Viewing all assessments for Group {Group_Number}:");
                foreach (var assessment in Assessments)
                {
                    Console.WriteLine($"- {assessment.Assessment_Title} (ID: {assessment.Assessment_Id})");
                }
            }
            else
            {
                Console.WriteLine($"No assessments available for Group {Group_Number}.");
            }
        }

        // Method to distribute workload among members
        public void DistributeWorkload(int totalTasks)
        {
            if (Group_Members.Count == 0)
            {
                Console.WriteLine("No members in the group to distribute workload.");
                return;
            }

            int maxWorkload = 10;  // Example max allowed workload per member
            int minWorkload = 1;   // Example min allowed workload per member
            int averageWorkload = totalTasks / Group_Members.Count;

            if (averageWorkload > maxWorkload || averageWorkload < minWorkload)
            {
                Console.WriteLine($"Error: Workload per member ({averageWorkload}) exceeds allowed limits (Min: {minWorkload}, " +
                $"Max: {maxWorkload}).");
            }
            else
            {
                Console.WriteLine($"Distributing {totalTasks} tasks among {Group_Members.Count} members:");
                foreach (var member in Group_Members)
                {
                    Console.WriteLine($"{member.User_Name} receives {averageWorkload} tasks.");
                }
            }
        }
        public void SubmitAssessment(string assessmentId, string fileType)
        {
            var validFileTypes = new List<string> { ".pdf", ".docx", ".txt" };
            if (!validFileTypes.Contains(fileType.ToLower()))
            {
                Console.WriteLine($"Error: '{fileType}' is not a valid file type for submission. Accepted types are: " +
                $"{string.Join(", ", validFileTypes)}");
                return;
            }

            var assessment = Assessments.FirstOrDefault(a => a.Assessment_Id == assessmentId);
            if (assessment != null)
            {
                Console.WriteLine($"Assessment with ID '{assessmentId}' submitted successfully for Group {Group_Number}.");
            }
            else
            {
                Console.WriteLine($"Error: Assessment with ID '{assessmentId}' not found in Group {Group_Number}.");
            }
        }

        // Method to check the grade of an assessment
        public void CheckGrade(string assessmentId)
        {
            var assessment = Assessments.FirstOrDefault(a => a.Assessment_Id == assessmentId);
            if (assessment != null)
            {
                Console.WriteLine($"The grade for assessment '{assessment.Assessment_Title}' (ID: {assessment.Assessment_Id}) is: " +
                $"{assessment.Grade}");
            }
            else
            {
                Console.WriteLine($"Error: Assessment with ID '{assessmentId}' not found in Group {Group_Number}.");
            }
        }
    }
}
