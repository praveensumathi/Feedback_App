using Feedback.Domain.Common.Entity;

namespace Feedback.Domain.Common.Model
{
    public class EventParameters : PagerParameters
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Place { get; set; }

        public string Date { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string OrganizedBy { get; set; }
    }
}
