using Microsoft.Extensions.DependencyInjection;
using System;

namespace Jiguang.JPush.JPushDependencyInjection
{
    public static class JPushDependencyInjectionExtensions
    {
        public static IServiceCollection AddJPush(this IServiceCollection services, Action<JPushConfiguration> config)
        {
            services.Configure(config);
            services.AddSingleton<JPushClient>();
            return services;
        }
    }
    public class JPushConfiguration
    {
        public string AppKey { get; set; }
        public string MasterSecret { get; set; }
    }
}
