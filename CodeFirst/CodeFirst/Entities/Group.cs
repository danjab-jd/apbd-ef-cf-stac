using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Group
    {
        public int IdGroup { get; set; }
        public string Name { get; set; }

        public virtual ICollection<StudentGroup> StudentGroups { get; set; }

        public Group()
        {
            StudentGroups = new HashSet<StudentGroup>();
        }
    }
}
