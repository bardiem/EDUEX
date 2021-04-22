using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUEX.Domain
{
    public class ModuleLections
    {
        [Key]
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public Module Module { get; set; }
        public int LectionId { get; set; }
        public Lection Lection { get; set; }
        public int Number { get; set; }

    }
}
