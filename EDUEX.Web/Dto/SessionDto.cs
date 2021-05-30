using System;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Web.Dto
{
    public class SessionDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Topic { get; set; }

        [Url]
        [MaxLength(200)]
        public string Link { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}
