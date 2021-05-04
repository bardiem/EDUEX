using EDUEX.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class UserWebinars
    {
        [Key]
        public int Id { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public Webinar Webinar { get; set; }

        public int WebinarId { get; set; }

        public CourseAccessTypeEnum AccessType { get; set; }

        public DateTime EnrollDate { get; set; }
    }
}
