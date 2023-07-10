using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownloader.Library
{
    public class YtDlpDownloader : IDownloader
    {
        public async Task<DownloadResponse> Download(VideoDownloadOptions options)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(options.URL, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (result == false)
            {
                return DownloadResponse.InvalidUrl;
            }

            try
            {
                StringBuilder args = new();
                args.Append($"-P \"{options.OutputFolder}\" ");
                args.Append($"{(options.FileType == FileType.MP3 ? "-x --audio-format mp3" : "-f mp4")} ");
                args.Append(options.URL);

                var processInfo = new ProcessStartInfo("yt-dlp.exe", args.ToString());
                processInfo.CreateNoWindow = false;

                var process = Process.Start(processInfo);

                await process.WaitForExitAsync();
                process.Close();

                return DownloadResponse.Success;
            }
            catch
            {
                return DownloadResponse.Error;
            }
        }
    }
}
