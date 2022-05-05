using System.Collections.Generic;

namespace CodeFirst.Entities
{
    public class Student
    {
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IndexNumber { get; set; }

        public virtual ICollection<StudentGroup> StudentGroups { get; set; }

        public Student()
        {
            StudentGroups = new HashSet<StudentGroup>();
        }
    }
}
