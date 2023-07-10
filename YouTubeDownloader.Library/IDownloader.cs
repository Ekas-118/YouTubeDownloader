using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownloader.Library
{
    public interface IDownloader
    {
        Task<DownloadResponse> Download(VideoDownloadOptions options);
    }
}
