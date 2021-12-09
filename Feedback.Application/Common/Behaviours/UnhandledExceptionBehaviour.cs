﻿using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Feedback.Application.Common.Behaviours
{
    public class UnhandledExceptionBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
		private readonly ILogger<TRequest> logger;

		public UnhandledExceptionBehaviour(ILogger<TRequest> logger)
		{
			this.logger = logger;
		}

		public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken,
			RequestHandlerDelegate<TResponse> next)
		{
			try
			{
				return await next();
			}
			catch (Exception ex)
			{
				var requestName = typeof(TRequest).Name;
				logger.LogError(ex, "Unhandled Exception for Request {Name} {@Request}", requestName, request);
				throw;
			}
		}
	}
}
