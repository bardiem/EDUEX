using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EDUEX.Domain
{
    public class Module
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public virtual ICollection<ModuleTasks> ModuleTasks { get; set; }
        public virtual ICollection<ModuleLections> ModuleLections { get; set; }
    }
}
