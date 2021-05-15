using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
