using AutoMapper.Configuration;
using Feedback.Application.Common.Contracts.Repositories;
using Feedback.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.Infrastructure
{
    public static partial class DependencyInjection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {

            #region Repositories
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            return services;
        }
    }
}
