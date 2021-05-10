using EDUEX.Domain.ValidationAttributes;
using EDUEX.Web.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Web.Dto.UserDtos
{
    public class BasicUserDto
    {

        [Range(1, int.MaxValue)]
        public int? Id { get; set; }

        [MinLength(2)]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [MinLength(2)]
        [MaxLength(150)]
        public string LastName { get; set; }

        [MinLength(2)]
        public List<string> Roles { get; set; }

        //[DateIsLessThanToday(ErrorMessageResourceName = "WrongBirthDateMsg", ErrorMessageResourceType = typeof(SharedResource))]
        public DateTime BirthDate { get; set; }

        [MinLength(5)]
        [MaxLength(150)]
        public string Position { get; set; }

    }
}
