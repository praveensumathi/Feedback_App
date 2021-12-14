using Feedback.Application.Common.Mappings;
using Feedback.Application.Common.Utils;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Feedback.Application
{
    public static partial class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            #region AddLocalisation
            services.AddLocalization();
            services.AddSingleton(typeof(IErrorLocalizer), typeof(ErrorLocalizer));
            #endregion

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            #region AutoMapper_Dependency_Injection
            var mappingConfig = new AutoMapperConfig().Configure();
            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            #endregion

            return services;
        }
    }
}
