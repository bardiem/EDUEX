using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class Module
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string Topic { get; set; }

        [MaxLength(450)]
        public string Description { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }

        public virtual ICollection<ModuleTasks> ModuleTasks { get; set; }

        public virtual ICollection<ModuleLections> ModuleLections { get; set; }
    }
}
