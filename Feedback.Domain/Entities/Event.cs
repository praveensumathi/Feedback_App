using System;

namespace Feedback.Domain.Entities
{
    public class Event
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Place { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public string OrganizedBy { get; set; }

        public bool IsPublished { get; set; }

        public bool IsFeedbackReceived { get; set; }

    }
}
