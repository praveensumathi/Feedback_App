using Feedback.Application.Common.Mappings;
using Feedback.Domain.Common.Entity;
using System.Collections.Generic;

namespace Feedback.Application.Common.Model
{
    public class PaginatedModel<T> : IMapFrom<PagedResult<T>>
    {
        public IEnumerable<T> Items { get; set; }
        public int TotalCount { get; set; }
    }
}
