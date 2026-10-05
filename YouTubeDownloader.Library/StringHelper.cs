using System.IO;

namespace YouTubeDownloader.Library
{
    public static class StringHelper
    {
        private const int MaxFileNameLength = 40;

        public static string SanitizeFileName(string fileName)
        {
            fileName = fileName.Trim();

            if (fileName.Length > MaxFileNameLength)
            {
                fileName = fileName[..MaxFileNameLength];
            }

            char[] invalidChars = Path.GetInvalidFileNameChars();

            foreach (char c in invalidChars)
            {
                fileName = fileName.Replace(c, '_');
            }

            fileName = fileName.TrimEnd('.');

            return fileName;
        }
    }
}
