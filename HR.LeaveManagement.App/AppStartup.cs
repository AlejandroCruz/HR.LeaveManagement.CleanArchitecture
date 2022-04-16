using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.App
{
    public static class AppStartup
    {
        public static void AppConfigureServices(this IServiceCollection services)
        {
            /* 'GetExecutingAssembly()' traverses all 'Profile' types for one generic
                call for mapper vs. multiple [model]profiles */
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
