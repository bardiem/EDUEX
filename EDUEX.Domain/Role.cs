using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(10)]
        public string Code { get; set; }

        [MaxLength(150)]
        public string Name { get; set; }
        public string PermissionDescription { get; set; }
        public virtual ICollection<UserCourses> UserCourses { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public override string ToString()
        {
            return $"{Code}";
        }
    }
}
