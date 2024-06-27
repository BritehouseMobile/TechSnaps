using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using OptionsPatternSampleApplication.Interfaces;

namespace OptionsPatternSampleApplication
{
    public class Function1
    {
        private readonly ILogger<Function1> _logger;
        private readonly IEmailService _emailService;
        private readonly IFTPService _ftpService;

        public Function1(ILogger<Function1> logger, IEmailService emailService, IFTPService ftpService)
        {
            _logger = logger;
            _emailService = emailService;
            _ftpService = ftpService;
        }

        [Function("Function1")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _emailService.SendEmail(default);
            _ftpService.DownloadFile(default);

            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
