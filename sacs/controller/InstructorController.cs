using sacs.entity;
using System;

namespace sacs.controller
{
    public class InstructorController
    {

        public InstructorController()
        {
        }

        public Instructor Instructor { set; get; }

        public void assign_member_out_group()
        {
            try
            {
                if (Instructor == null)
                {
                    throw new InvalidOperationException("Instructor not initialized");
                }

                // Notify that member has been removed from group
                Console.WriteLine("Member has been removed from the group");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error removing member from group: {ex.Message}");
            }
        }

        public void assign_member_in_group()
        {
            // TODO implement here
        }

        public bool feedback(string FeedbackText)
        {

            Console.WriteLine($"Feedback stored: {FeedbackText}");
            return true;

        }

        public void view_grade()
        {
            // TODO implement here
        }

        public void evaluate_assignment_grade()
        {
            // TODO implement here
        }

        public void view_trace_dashbord()
        {
            // TODO implement here
        }

    }
}
