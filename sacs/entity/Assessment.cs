using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sacs.entity
{
    public class Assessment
    {
        public string Assessment_Id { get; set; }
        public string Assessment_Title { get; set; }
        public string Assessment_Type { get; set; }
        public string Assessment_Date { get; set; }
        public string Group_Number { get; set; }
        public string Grade { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();
        public List<Turnitin> Turnitins { get; set; } = new List<Turnitin>();
        public List<Assessment> Grades { get; set; } = new List<Assessment>();

        public Assessment(string assessmentId, string assessmentTitle, string assessmentType, string grade = "Not Graded")
        {
            Assessment_Id = assessmentId;
            Assessment_Title = assessmentTitle;
            Assessment_Type = assessmentType;
            grade = grade;
        }

      
        public void SubmitAssessment(User student)
        {
            Console.WriteLine($"{student.User_Name} submitted the assessment: {Assessment_Title}");
        }

        public void CreatePlagiarismReport()
        {
            Console.WriteLine($"Plagiarism report created for assessment: {Assessment_Title}.");
        }
    }
}
