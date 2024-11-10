using sacs.entity;

namespace sacs.dao
{
    
    public class AssignmentDao
    {
        private List<Assignment> database = new List<Assignment>();
        public AssignmentDao()
        {
            // Mock data
            database.Add(new Assignment("Assignment 1", "Intro to Programming", DateTime.Now.AddDays(7), new List<string> { "file1.pdf" }, "CS101"));
        }

        public List<Assignment> query_Assignment()
        {
            return database;
        }

        public void save_msg()
        {
            // TODO implement here
        }
        public void SaveAssignment(Assignment assignment)
        {
            database.Add(assignment);
            Console.WriteLine("Assignment saved to database.");
        }

    }
}
