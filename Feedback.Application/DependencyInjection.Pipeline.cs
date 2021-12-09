using Feedback.Application.Common.Behaviours;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.Application
{
    public static partial class DependencyInjection
    {
        public static IServiceCollection AddPipeline(this IServiceCollection services, IConfiguration configuration)
        {
            #region ValidationBehavior
            // Generic pipeline behavior to check for any validation errors thrown by FluentValidation
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(SqlExceptionBehaviour<,>));
            // Logs any unhandled exceptions thrown within a request
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            #endregion

            return services;
        }
    }
}
