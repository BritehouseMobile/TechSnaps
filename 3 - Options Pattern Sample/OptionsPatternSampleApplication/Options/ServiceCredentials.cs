using System.ComponentModel.DataAnnotations;

namespace OptionsPatternSampleApplication.Options
{
    public class ServiceCredentials
    {
        [Required(AllowEmptyStrings = false)]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }
    }
}
