using sacs.entity;
using System;

namespace sacs.controller
{
    public class InstructorController
    {

        public InstructorController()
        {
        }

        private Instructor Instructor { set; get; }
        private Student student { get; set; }

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
            try
            {
                if (Instructor == null)
                {
                    throw new InvalidOperationException("Instructor not initialized");
                }

                // Notify that member has been added to group
                Console.WriteLine("Member has been added to the group");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding member to group: {ex.Message}");
            }
        }

        public bool feedback(string FeedbackText)
        {

            Console.WriteLine($"Feedback stored: {FeedbackText}");
            return true;

        }

        public void view_grade()
        {
            try
            {
                if (Instructor == null)
                {
                    throw new InvalidOperationException("Instructor not initialized");
                }
                if (student == null)
                {
                    throw new InvalidOperationException("Instructor not initialized");
                }
                // Placeholder for grade viewing logic
                Console.WriteLine("Displaying grades:");
                Console.WriteLine("------------------");
                Console.WriteLine(" A");
              
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error viewing grades: {ex.Message}");
            }
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
