using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sacs.entity
{
    public class Quiz : Assessment
    {
        public string Quiz_Id { get; set; }
        public string Quiz_Number { get; set; }

        public Quiz(string assessmentId, string assessmentTitle, string assessmentType, string assessmentDate, string quizId, string quizNumber)
            : base(assessmentId, assessmentTitle, assessmentType, assessmentDate) // Call to base class constructor
        {
            Quiz_Id = quizId;
            Quiz_Number = quizNumber;
        }
    }
}
