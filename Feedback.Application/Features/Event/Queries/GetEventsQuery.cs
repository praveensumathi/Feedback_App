using Feedback.Application.Common.Model;
using Feedback.Application.Features.Event.Models;
using MediatR;

namespace Feedback.Application.Features.Event.Queries
{
    public class GetEventsQuery : EventParametersModel, IRequest<PaginatedModel<EventModel>>
    {

    }
}
