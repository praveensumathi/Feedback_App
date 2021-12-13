using Feedback.Application.Common.Contracts.Repositories;
using System.Data;

namespace Feedback.Infrastructure.Repositories
{
    public class DapperRepositoryBase<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly IDbConnection Connection;
        public DapperRepositoryBase(IDbConnection connection)
        {
            Connection = connection;
        }
    }
}
