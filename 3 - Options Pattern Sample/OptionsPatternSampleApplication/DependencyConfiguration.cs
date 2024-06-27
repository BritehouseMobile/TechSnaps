using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OptionsPatternSampleApplication.Interfaces;
using OptionsPatternSampleApplication.Options;
using OptionsPatternSampleApplication.Services;

namespace OptionsPatternSampleApplication
{
    public static class DependencyConfiguration
    {
        public static IServiceCollection RegisterEmailService(this IServiceCollection services)
        {
            return services.AddOptions<EmailServiceOptions>()
                .Configure<IConfiguration>((settings, configuration) =>
                {
                    configuration.GetSection("EmailSettings").Bind(settings);
                })
                .ValidateDataAnnotations()
                .Services
                .AddSingleton<IEmailService, EmailService>();
        }

        public static IServiceCollection RegisterFTPService(this IServiceCollection services)
        {
            return services.AddOptions<FTPServiceOptions>()
                .Configure<IConfiguration>((settings, configuration) =>
                {
                    configuration.GetSection("FTPSettings").Bind(settings);
                })
                .ValidateDataAnnotations()
                .Services
                .AddSingleton<IFTPService, FTPService>();
        }
    }
}
