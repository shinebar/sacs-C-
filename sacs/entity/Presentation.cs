using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sacs.entity
{
    public class Presentation : Assessment
    {
        public string Presentation_Id { get; set; }
        public string Presentation_Number { get; set; }

        public Presentation(string assessmentId, string assessmentTitle, string assessmentType, string assessmentDate, string presentationId, string presentationNumber)
            : base(assessmentId, assessmentTitle, assessmentType, assessmentDate) // Call to base class constructor
        {
            Presentation_Id = presentationId;
            Presentation_Number = presentationNumber;
        }
    }
}
