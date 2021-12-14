using Feedback.Domain.Common.Configurations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;

namespace Feedback.Infrastructure
{
    public static partial class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration, IAppSettings appSettings)
        {
            #region DBConnection
            services.AddScoped<IDbConnection>(db => new SqlConnection(appSettings.ConnectionStrings.DefaultConnection));
            #endregion

            #region Repositories
            services.AddRepositories(configuration);
            #endregion

            return services;
        }
    }
}
