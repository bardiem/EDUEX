using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EDUEX.Domain
{
    public class Courses
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AverageMark { get; set; }
        public ICollection<Modules> Modules { get; set; }       
    }
}
