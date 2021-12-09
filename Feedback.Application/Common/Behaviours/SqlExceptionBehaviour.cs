using Feedback.Application.Common.Exceptions;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace Feedback.Application.Common.Behaviours
{
    public class SqlExceptionBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
		private readonly ILogger<TRequest> logger;
		//private readonly IErrorLocalizer _errorLocalizer;

		public SqlExceptionBehaviour(ILogger<TRequest> logger)
		{
			this.logger = logger;
			//this._errorLocalizer = errorLocalizer;
		}

		public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken,
			RequestHandlerDelegate<TResponse> next)
		{
			try
			{
				return await next();
			}
			catch (SqlException ex)
			{
				var requestName = typeof(TRequest).Name;
				logger.LogError(ex, "SQL Exception for Request {Name} {@Request}", requestName, request);
				throw new ApplicationSqlException("error message");
			}
		}
	}
}
