using sacs.entity;
using System;

namespace sacs.adapter
{
    public class SACSDataAdapter
    {
        private List<Assessment> assessments = new List<Assessment>();


        public List<Assessment> GetAllAssessments()
        {
            return assessments;
        }


        public List<Assessment> SearchBy(string searchTerm)
        {
            return assessments;



        }
        public void OpenAssessment(int assessmentId)
        {

        }

        public void SaveAssessment(Assessment assessment)
        {

        }

        public void UpdateStatus(int assessmentId, string newStatus)
        {

        }

    }
}
