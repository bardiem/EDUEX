using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EDUEX.Domain
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Education { get; set; }
        public User User { get; set; } 
        public int UserId { get; set; }
    }
}
