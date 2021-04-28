using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(10)]
        [Required]
        public string Code { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; }

        [MaxLength(300)]
        public string PermissionDescription { get; set; }

        public virtual ICollection<User> Users { get; set; }

    }
}
