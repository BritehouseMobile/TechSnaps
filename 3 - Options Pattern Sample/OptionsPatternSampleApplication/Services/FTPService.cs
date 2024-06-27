using Microsoft.Extensions.Options;
using OptionsPatternSampleApplication.Interfaces;
using OptionsPatternSampleApplication.Options;

namespace OptionsPatternSampleApplication.Services
{
    public class FTPService : IFTPService
    {
        private readonly FTPServiceOptions fTPServiceOptions;

        public FTPService(IOptions<FTPServiceOptions> options)
        {
            fTPServiceOptions = options.Value;
        }

        public byte[] DownloadFile(string path)
        {
            // TODO: Implement this.
            return Array.Empty<byte>();
        }

        public IEnumerable<string> ListDirectory(string path)
        {
            // TODO: Implement this.
            return new List<string>();
        }
    }
}
