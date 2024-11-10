using sacs.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sacs.adapter
{
    public class AssignmentAdapter
    {
        public Assignment Assignment { get; set; }

        public HashSet<Assignment> Assignments { get; set; }
    
     
        public Assignment ConvertToAssignment(string title, string description, DateTime dueDate, List<string> files, string unit_code)
        {
            return new Assignment(title, description, dueDate, files, unit_code);
        }

        public List<Assignment> WrapAssignments(List<Assignment> assignments)
        {
            //encapsulation the assignment objects to return
            return assignments;
        }
       
    }
}
