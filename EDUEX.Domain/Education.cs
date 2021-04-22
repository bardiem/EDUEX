using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUEX.Domain
{
    public class Education
    {
        [Key]
        public int Id { get; set; }
        public string Level { get; set; }
        public string Institution { get; set; }
        public string Faculty { get; set; }
        public string Specialty { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
