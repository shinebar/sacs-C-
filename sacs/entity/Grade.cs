using System;


namespace sacs.entity
{
    public class Grade
    {
        public string AssessmentId { get; set; }
        public int GradeValue { get; set; }

        public Grade(string assessmentId, int gradeValue)
        {
            AssessmentId = assessmentId;
            GradeValue = gradeValue;
        }
    }
}
