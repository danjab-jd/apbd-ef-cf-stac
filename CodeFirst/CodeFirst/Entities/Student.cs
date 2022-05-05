using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Student
    {
        public int IdStudent { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int IndexNumber { get; set; }

        public virtual ICollection<StudentGroup> StudentGroups { get; set; }

        public Student()
        {
            StudentGroups = new HashSet<StudentGroup>();
        }
    }
}
