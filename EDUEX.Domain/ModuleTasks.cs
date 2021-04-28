using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class ModuleTasks
    {
        [Key]
        public int Id { get; set; }

        public int ModuleId { get; set; }

        public Module Module { get; set; }

        public int TaskId { get; set; }

        public Task Task { get; set; }

        public int Number { get; set; }
    }
}
