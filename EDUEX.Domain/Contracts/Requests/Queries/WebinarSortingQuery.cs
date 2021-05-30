using EDUEX.Domain.Enums;

namespace EDUEX.Domain.Contracts.Requests.Queries
{
    public class WebinarSortingQuery
    {
        public string Subject { get; set; }
        public SortingTypeEnum OrderType { get; set; }
    }
}
