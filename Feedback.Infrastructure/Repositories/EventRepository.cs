using Dapper;
using Feedback.Application.Common.Contracts.Repositories;
using Feedback.Domain.Common.Entity;
using Feedback.Domain.Common.Model;
using Feedback.Domain.Entities;
using System.Data;
using System.Threading.Tasks;
using System.Linq;


namespace Feedback.Infrastructure.Repositories
{
    public class EventRepository : DapperRepositoryBase<Event>, IEventRepository
    {
        public EventRepository(IDbConnection connection) : base(connection)
        {
        }

        readonly string GetStoreProcedure = "[dbo].[EventGetAll]";

        public async Task<PagedResult<Event>> Get(EventParameters eventParameters)
        {
            var pagedResult = new PagedResult<Event>();

            var param = new
            {
                eventParameters.OffSet,
                eventParameters.PageSize,
                eventParameters.SortColumn,
                eventParameters.SortDirection,
                eventParameters.Title,
                eventParameters.Description,
                eventParameters.Place,
                eventParameters.Date,
                eventParameters.StartTime,
                eventParameters.EndTime,
                eventParameters.OrganizedBy
            };

            using (var dbResult = await Connection.QueryMultipleAsync(GetStoreProcedure, param, commandType: CommandType.StoredProcedure))
            {
                pagedResult.Items = (await dbResult.ReadAsync<Event>()).AsEnumerable();
                pagedResult.TotalCount = (await dbResult.ReadAsync<int>()).FirstOrDefault();
            }

            return pagedResult;
        }

        public Task<PagedResult<Event>> Delete(long id, EventParameters eventParameters)
        {
            throw new System.NotImplementedException();
        }

        public Task<PagedResult<Event>> Upsert(EventParameters eventParameters, Event session, string loggedInUserEmail)
        {
            throw new System.NotImplementedException();
        }
    }
}
