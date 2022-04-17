using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HR.LeaveManagement.App
{
    public static class AppStartup
    {
        public static IServiceCollection AppConfigureServices(this IServiceCollection services)
        {
            /* 'GetExecutingAssembly()' traverses all 'Profile' types for one generic
                call for mapper vs. multiple [model]profiles */
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
