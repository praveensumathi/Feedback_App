using AutoMapper.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;

namespace Feedback.Infrastructure
{
    public static partial class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region DBConnection
            services.AddScoped<IDbConnection>(db => new SqlConnection("Server=BSD-PRAVEEN;Database=Questionnaire-app;User Id=sa;password=Password@4321;Trusted_Connection=False;MultipleActiveResultSets=true;"));
            #endregion

            #region Repositories
            //services.AddRepositories(configuration);
            #endregion

            return services;
        }
    }
}
