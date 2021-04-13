using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EDUEX.Domain
{
    public class Modules
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public ICollection<Lections> Lections { get; set; }
    }
}
