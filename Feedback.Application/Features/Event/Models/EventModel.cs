using Feedback.Application.Common.Constants;
using Feedback.Application.Common.Mappings;
using System;
using System.Globalization;
using System.Text.Json.Serialization;
using Entity = Feedback.Domain.Entities;

namespace Feedback.Application.Features.Event.Models
{
    public class EventModel : IMapFrom<Entity.Event>,IMapTo<Entity.Event>
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Place { get; set; }

        [JsonIgnore]
        public DateTime Date { get; set; }
        [JsonIgnore]
        public TimeSpan StartTime { get; set; }
        [JsonIgnore]
        public TimeSpan EndTime { get; set; }

        public string OrganizedBy { get; set; }

        public bool IsPublished { get; set; }

        public bool IsFeedbackReceived { get; set; }

        public string StartDate
        {
            get
            {
                return Date.ToString(ApplicationDate.DateFormat, CultureInfo.InvariantCulture);
            }
        }

        public string StartingTime
        {
            get
            {
                return StartTime.ToString(ApplicationDate.TimeFormat);
            }
        }
        public string EndingTime
        {
            get
            {
                return EndTime.ToString(ApplicationDate.TimeFormat);
            }
        }
    }
}
