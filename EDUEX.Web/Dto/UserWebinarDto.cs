using System;

namespace EDUEX.Web.Dto
{
    public class UserWebinarDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int WebinarId { get; set; }

        public DateTime EnrollDate { get; set; }
    }
}
