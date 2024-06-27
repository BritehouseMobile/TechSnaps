using System.ComponentModel.DataAnnotations;

namespace OptionsPatternSampleApplication.Options
{
    public class ServiceHost
    {
        [Required(AllowEmptyStrings = false)]
        public string Host { get; set; }

        [Required]
        public int Port { get; set; }

        [Required]
        public bool UseSSL { get; set; }
    }
}
