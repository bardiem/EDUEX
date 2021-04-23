using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class Lection
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        [Required]
        public string Topic { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(1000)]
        public string VideoPath { get; set; }

        public string Text { get; set; }

        public virtual ICollection<LectionAttachments> LectionAttachments { get; set; }

        public virtual ICollection<ModuleLections> ModuleLections { get; set; }

        public virtual ICollection<LectionComments> LectionComments { get; set; }
    }
}
