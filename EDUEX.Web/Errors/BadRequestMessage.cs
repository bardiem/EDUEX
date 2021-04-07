using System.ComponentModel.DataAnnotations;

namespace EDUEX.Web.Errors
{
    public class BadRequestMessage
    {
        [Required]
        public string Message { get; set; }
    }
}
