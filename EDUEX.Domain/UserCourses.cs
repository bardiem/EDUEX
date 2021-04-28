using EDUEX.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class UserCourses
    {
        [Key]
        public int Id { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public Course Course { get; set; }

        public int CourseId { get; set; }

        public CourseAccessTypeEnum AccessType { get; set; }

        public DateTime StartParticipationDate { get; set; }

        public DateTime EndPartticipationDate { get; set; }

        public bool IsActive { get; set; }
    }
}
