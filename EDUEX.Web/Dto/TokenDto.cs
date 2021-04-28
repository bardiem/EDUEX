using System.ComponentModel.DataAnnotations;

namespace EDUEX.Web.Dto
{
    public class TokenDto
    {
        [Required]
        public string Token { get; set; }
    }
}
