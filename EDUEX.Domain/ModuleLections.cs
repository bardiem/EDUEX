using System.ComponentModel.DataAnnotations;

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
