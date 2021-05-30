using System.Collections.Generic;

namespace EDUEX.Web.Dto.UserDtos
{
    public class UserWithWebinars : UserDtoWithEmail
    {
        public IList<WebinarReviewDto> Webinars { get; set; }
    }
}
