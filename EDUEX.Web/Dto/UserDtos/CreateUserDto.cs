using System.ComponentModel.DataAnnotations;

namespace EDUEX.Web.Dto.UserDtos
{
    public class CreateUserDto : UserDtoWithEmail
    {
        [Required]
        public string Password { get; set; }
    }
}
