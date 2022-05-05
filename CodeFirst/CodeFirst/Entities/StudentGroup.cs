using System;

namespace CodeFirst.Entities
{
    public class StudentGroup
    {
        public int IdStudent { get; set; }
        public int IdGroup { get; set; }
        public DateTime AddedAt { get; set; }

        public virtual Student IdStudentNavigation { get; set; }
        public virtual Group IdGroupNavigation { get; set; }
    }
}
