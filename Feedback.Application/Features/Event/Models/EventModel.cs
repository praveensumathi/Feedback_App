using Feedback.Application.Common.Mappings;
using System;
using Entity = Feedback.Domain.Entities;

namespace Feedback.Application.Features.Event.Models
{
    public class EventModel : IMapFrom<Entity.Event>,IMapTo<Entity.Event>
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
