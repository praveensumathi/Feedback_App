using Feedback.Domain.Common.Entity;
using Feedback.Domain.Common.Model;
using Feedback.Domain.Entities;
using System.Threading.Tasks;

namespace Feedback.Application.Common.Contracts.Repositories
{
    public interface IEventRepository
    {
        Task<PagedResult<Event>> Get(EventParameters eventParameters);
        Task<PagedResult<Event>> Upsert(EventParameters eventParameters,Event session,string loggedInUserEmail);
        Task<PagedResult<Event>> Delete(long id, EventParameters eventParameters);
    }
}
