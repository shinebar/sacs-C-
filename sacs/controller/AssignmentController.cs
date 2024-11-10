using Microsoft.VisualBasic;
using sacs.adapter;
using sacs.entity;
using sacs.dao;
using System.Reflection;

namespace sacs.controller
{
    public class AssignmentController
    {

        private AssignmentDao dao;
        private AssignmentAdapter adapter;
        public AssignmentController()
        {
            dao = new AssignmentDao();
            adapter = new AssignmentAdapter();
        }

        public HashSet<Assignment> assignments;

        public HashSet<Unit> unit;

        public Student student;

        public String Create_assignment(string title,string description, DateTime dueDate,List<String> files,Unit unit)
        {
            // create a assignment
            Assignment newAssignment = adapter.ConvertToAssignment(title, description, dueDate, files, unit.unit_code);
            dao.SaveAssignment(newAssignment);
            return "success";
        }

        public void View_Assignment(string title, string description, DateTime dueDate, List<String> files, Unit unit)
        {
            List<Assignment> assignments = dao.query_Assignment();
            Console.WriteLine("\nAssignments:");
            foreach (var assignment in assignments)
            {
                Console.WriteLine($"Title: {assignment.title}, Due: {assignment.dueDate}, Unit: {assignment.Unit}");
            }
        }

        private List<Assignment> GetAssignments()
        {
            return dao.query_Assignment();
        }

        public void save_assignment(string title, string description, DateTime dueDate, List<String> files, string unit_code)
        {
            Assignment newAssignment = adapter.ConvertToAssignment(title, description, dueDate, files, unit_code);
            dao.SaveAssignment(newAssignment);
        }

        public void publish_assignment()
        {
            // TODO implement here
        }

        public void distribute_assignment()
        {
            // TODO implement here
        }

        public void trace_assignment_deadlines()
        {
            List<Assignment> assignments = GetAssignments();
            Console.WriteLine("\nAssignments:");
            foreach (var assignment in assignments)
            {
                Console.WriteLine($"Title: {assignment.title}, Due: {assignment.dueDate}, Unit: {assignment.Unit}");
            }
        }

        public List<Assignment> trace_assignment_progess()
        {
            List<Assignment> assignments = dao.query_Assignment();
            return adapter.WrapAssignments(assignments);
        }

        public List<Assignment> trace_task()
        {
            List<Assignment> assignments = dao.query_Assignment();
            return adapter.WrapAssignments(assignments);
        }

        public List<Assignment> check_task_status()
        {
            List<Assignment> assignments = dao.query_Assignment();
            return adapter.WrapAssignments(assignments);
        }

    }
}
