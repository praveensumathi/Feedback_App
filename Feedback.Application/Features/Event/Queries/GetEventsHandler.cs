using AutoMapper;
using Feedback.Application.Common.Contracts.Repositories;
using Feedback.Application.Common.Model;
using Feedback.Application.Features.Event.Models;
using Feedback.Domain.Common.Model;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Feedback.Application.Features.Event.Queries
{
    public class GetEventsHandler : IRequestHandler<GetEventsQuery, PaginatedModel<EventModel>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetEventsHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<PaginatedModel<EventModel>> Handle(GetEventsQuery request, CancellationToken cancellationToken)
        {
            var parameters = mapper.Map<EventParameters>(request);
            var eventPagedResult = await unitOfWork.EventRepository.Get(parameters);

            return mapper.Map<PaginatedModel<EventModel>>(eventPagedResult);
        }
    }
}
