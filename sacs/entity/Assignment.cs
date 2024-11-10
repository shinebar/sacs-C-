using System;



namespace sacs.entity
{
    public class Assignment
    {

        public String title { get; set; }

        public String description { get; set; }

        public DateTime dueDate { get; set; }

        public List<string> relavent_files { get; set; }
        public string assigmentCode { get; set; }


        public Unit Unit { set; get; }
        public Assignment(string title, string description, DateTime dueDate, List<string> files, string unit)
        {
            title = title;
            description = description;
            dueDate = dueDate;
            relavent_files = files;
            unit = unit;
        }

    }
}
