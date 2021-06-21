using EDUEX.Domain.Enums;

namespace EDUEX.Domain.Contracts.Requests.Queries
{
    public class WebinarSortingQuery
    {
        public int SubjectId { get; set; }
        public SortingTypeEnum OrderType { get; set; }
    }
}
