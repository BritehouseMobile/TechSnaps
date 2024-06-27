using System.ComponentModel.DataAnnotations;

namespace OptionsPatternSampleApplication.Options
{
    public class FTPServiceOptions
    {
        [Required]
        public ServiceHost HostDetails { get; set; }

        [Required]
        public ServiceCredentials Credentials { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string DefaultDirectory { get; set; }

        [Required]
        public Dictionary<string, FTPDirectoryOperations> DirectoryOperations { get; set; }
    }
}
