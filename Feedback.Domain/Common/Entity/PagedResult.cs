using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
