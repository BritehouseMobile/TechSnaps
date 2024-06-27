using System.ComponentModel.DataAnnotations;

namespace OptionsPatternSampleApplication.Options
{
    public class EmailServiceOptions
    {
        [Required]
        public ServiceHost HostDetails { get; set; }
        
        [Required]
        public ServiceCredentials Credentials { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string SenderEmail { get; set; }
    }
}
