using System.Collections.Generic;

namespace Feedback.Domain.Common.Entity
{
    public class PagedResult<T>
    {
        public PagedResult()
        {
            TotalCount = default(int);
        }
        public IEnumerable<T> Items { get; set; }
        public int TotalCount { get; set; }
    }
}
