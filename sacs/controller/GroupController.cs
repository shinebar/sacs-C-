using System;
using sacs.entity;

namespace sacs.controller
{
    public class GroupController
    {

        public GroupController()
        {
        }

        public HashSet<Student> UserMember { get; set; }

        public Unit unit { get; set; }

        public void create_group()
        {
            // TODO implement here
        }

        public void invite_memebers_in_group()
        {
            // TODO implement here
        }

        public void assign_member_out_group()
        {
            // TODO implement here
        }

        public void entry_group()
        {
            // TODO implement here
        }

        public void view_group()
        {
            // TODO implement here
        }

        /// <summary>
        /// @param String groupCode
        /// </summary>
        public void entry_group(String groupCode)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param String SID 
        /// @param String groupCode
        /// </summary>
        public void invite_memebers_in_group(String SID, String groupCode)
        {
            // TODO implement here
        }

    }
}
