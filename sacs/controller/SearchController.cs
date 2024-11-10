using sacs.adapter;
using sacs.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sacs.controller
{
    public class SearchController
    {
        private SACSDataAdapter dataAdapter;

        public SearchController(SACSDataAdapter adapter)
        {
            this.dataAdapter = adapter;
        }

        public List<Assessment> SearchAssessmentByGroupNum(string name)
        {
            var assessments = dataAdapter.GetAllAssessments();
            var results = assessments.Where(a => a.Assessment_Title.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            return results;
        }

        public List<Assessment> SearchAssessmentByCourse(string course)
        {
            var assessments = dataAdapter.GetAllAssessments();
            return assessments;
        }
    }
}
