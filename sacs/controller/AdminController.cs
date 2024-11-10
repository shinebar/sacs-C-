using System;
using sacs.adapter;
using sacs.entity;

namespace sacs.controller
{
    public class AdminController
    {
        private SACSDataAdapter dataAdapter;

        public AdminController(SACSDataAdapter adapter)
        {
            this.dataAdapter = adapter;
        }

        public void CheckPlagiarism(string document)
        {
            Turnitin turnitin = new Turnitin("1", "12345", "No plagiarism detected");
            var result = turnitin;
            Console.WriteLine($"Plagiarism check result: {result.Turnitin_Result}");
        }

        public void OpenAssessment(int assessmentId)
        {
            dataAdapter.OpenAssessment(assessmentId);
        }
    }
}
