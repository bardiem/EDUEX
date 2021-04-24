using System.ComponentModel.DataAnnotations;

namespace EDUEX.Web.Dto.UserDtos
{
    public class UserDtoWithEmail : BasicUserDto
    {
        [EmailAddress]
        public string Email { get; set; }
    }
}
