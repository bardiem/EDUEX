using System.Collections.Generic;

namespace EDUEX.Web.Dto.WebinarDto
{
    public class WebinarWithSessionCreationDto : WebinarCreationDto
    {
        public IList<SessionDto> Sessions { get; set; }
    }
}
