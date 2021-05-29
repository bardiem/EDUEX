using System;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class Session
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Topic { get; set; }

        [MaxLength(200)]
        public string Link { get; set; }

      

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}
