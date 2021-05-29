using System;
using System.Collections.Generic;

namespace EDUEX.Web.Dto.UserDtos
{
    public class BasicUserDto
    {
        public int? Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<string> Roles { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Position { get; set; }

        public decimal Balance { get; set; }

    }
}
