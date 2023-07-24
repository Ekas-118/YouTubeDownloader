using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownloader.Library
{
    public class YtDlpDownloader : IDownloader
    {
        public async Task<(DownloadResponse, string)> Download(VideoDownloadOptions options)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(options.URL, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (result == false)
            {
                return (DownloadResponse.InvalidUrl, "");
            }

            try
            {
                string fileName = "";
                try
                {
                    fileName = await GetFileName(options.URL);
                    if (string.IsNullOrEmpty(fileName))
                    {
                        return (DownloadResponse.Error, "");
                    }
                }
                catch
                {
                    return (DownloadResponse.InvalidUrl, "");
                }

                StringBuilder args = new();
                args.Append($"-P \"{options.OutputFolder}\" ");
                args.Append($"-o \"{fileName}.{(options.FileType == FileType.MP3 ? "mp3" : "mp4")}\" ");
                args.Append($"{(options.FileType == FileType.MP3 ? "-x --audio-format mp3" : "-f mp4")} ");
                args.Append(options.URL);

                var processInfo = new ProcessStartInfo("yt-dlp.exe", args.ToString());
                processInfo.CreateNoWindow = true;

                using (Process process = new Process { StartInfo = processInfo })
                {
                    process.Start();
                    await process.WaitForExitAsync();
                    process.Close();
                }
                
                string fullFileName = Path.Combine(options.OutputFolder, $"{fileName}.{(options.FileType == FileType.MP3 ? "mp3" : "mp4")}");

                return (DownloadResponse.Success, fullFileName);
            }
            catch
            {
                return (DownloadResponse.Error, "");
            }
        }

        private async Task<string> GetFileName(string url)
        {
            string output = "";
            string error = "";

            string args = $"-e {url}";

            var processInfo = new ProcessStartInfo("yt-dlp.exe", args);
            processInfo.CreateNoWindow = true;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;

            using (Process process = new Process { StartInfo = processInfo })
            {
                process.Start();
                output = process.StandardOutput.ReadToEnd();
                error = process.StandardError.ReadToEnd();
                await process.WaitForExitAsync();
                output = output.Trim();
                process.Close();
            }

            if (string.IsNullOrEmpty(error) == false)
            {
                throw new ArgumentException("Failed to get filename for URL", nameof(url));
            }

            return output;
        }
    }
}
