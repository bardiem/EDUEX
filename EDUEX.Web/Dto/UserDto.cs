using System;
using System.Collections.Generic;

namespace EDUEX.Web.Dto
{
    public class UserDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public List<string> Roles { get; set; }

        public DateTime BirthDate { get; set; }

        public string Position { get; set; }

    }
}
