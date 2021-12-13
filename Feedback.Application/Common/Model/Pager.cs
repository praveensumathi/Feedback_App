using Feedback.Application.Common.Mappings;
using Feedback.Domain.Common.Entity;

namespace Feedback.Application.Common.Model
{
    public abstract class Pager : IMapTo<PagerParameters>
    {
        public int OffSet { get; set; }

        public int PageSize { get; set; }

        public string SortColumn { get; set; }

        public string SortDirection { get; set; }
    }
}
