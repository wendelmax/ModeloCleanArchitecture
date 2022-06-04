using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ModeloCleanArchitecture.Application.Interfaces;
using ModeloCleanArchitecture.Domain.Settings;
using ModeloCleanArchitecture.Infrastructure.Shared.Services;

namespace ModeloCleanArchitecture.Infrastructure.Shared
{
    public static class ServiceRegistration
    {
        public static void AddSharedInfrastructure(this IServiceCollection services, IConfiguration _config)
        {
            services.Configure<MailSettings>(_config.GetSection("MailSettings"));
            services.AddTransient<IDateTimeService, DateTimeService>();
            services.AddTransient<IEmailService, EmailService>();
        }
    }
}
