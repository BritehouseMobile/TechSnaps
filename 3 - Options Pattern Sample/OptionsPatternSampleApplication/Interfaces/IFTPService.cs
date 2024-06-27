namespace OptionsPatternSampleApplication.Interfaces
{
    public interface IFTPService
    {
        IEnumerable<string> ListDirectory(string path);
        byte[] DownloadFile(string path);
    }
}
