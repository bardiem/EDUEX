namespace EDUEX.Web.Dto.UserDtos
{
    public class CreateUserDto : UserDtoWithEmail
    {
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
