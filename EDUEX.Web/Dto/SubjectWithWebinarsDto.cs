using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDUEX.Web.Dto
{
    public class SubjectWithWebinarsDto : SubjectReviewDto
    {
        public IList<WebinarReviewDto> webinars { get; set; }
    }
}
