using Feedback.Application.Common.Mappings;
using Feedback.Application.Common.Model;
using DomainModelParam = Feedback.Domain.Common.Model;

namespace Feedback.Application.Features.Event.Models
{
    public class EventParametersModel : Pager, IMapTo<DomainModelParam.EventParameters>
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
