using sacs.adapter;
using sacs.entity;
namespace sacs.controller
{
    public class SubmissionController
    {
        private SACSDataAdapter dataAdapter;

        public SubmissionController(SACSDataAdapter adapter)
        {
            this.dataAdapter = adapter;
        }

        public void SubmitAssessment(User user, Assessment assessment)
        {
            dataAdapter.SaveAssessment(assessment);
            Console.WriteLine($"{user.User_Name} submitted assessment: {assessment.Assessment_Title}");
        }

        public void SubmitFeedback(User user, Feedback feedback, Assessment assessment)
        {
            
            Console.WriteLine($"{user.User_Name} submitted feedback for assessment: {assessment.Grades}");
        }
    }
}
