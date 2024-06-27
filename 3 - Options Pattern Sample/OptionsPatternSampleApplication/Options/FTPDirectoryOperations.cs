using System.ComponentModel.DataAnnotations;

namespace OptionsPatternSampleApplication.Options
{
    public class FTPDirectoryOperations
    {
        [Required(AllowEmptyStrings = false)]
        public string Directory { get; set; }

        [Required, MinLength(1)]
        public List<string> Operations { get; set; }
    }
}
