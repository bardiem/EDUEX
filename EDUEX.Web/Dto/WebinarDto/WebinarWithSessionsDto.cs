using System.Collections.Generic;

namespace EDUEX.Web.Dto.WebinarDto
{
    public class WebinarWithSessionsDto : WebinarReviewDto
    {
        public IList<SessionDto> Sessions { get; set; }
    }
}
