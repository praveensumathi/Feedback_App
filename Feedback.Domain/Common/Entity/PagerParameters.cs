namespace Feedback.Domain.Common.Entity
{
    public class PagerParameters
    {
        public int OffSet { get; set; }

        public int PageSize { get; set; }

        public string SortColumn { get; set; }

        public string SortDirection { get; set; }
    }
}
