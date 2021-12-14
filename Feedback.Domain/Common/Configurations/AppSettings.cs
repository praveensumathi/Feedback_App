using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.Domain.Common.Configurations
{
    public interface IAppSettings
    {
        
        public ConnectionString ConnectionStrings { get; set; }
    }

    public class AppSettings : IAppSettings
    {
        public ConnectionString ConnectionStrings { get; set; }
    }
}
