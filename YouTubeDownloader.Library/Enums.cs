using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownloader.Library
{
    public enum DownloadResponse
    {
        Success,
        InvalidUrl,
        Error
    }

    public enum FileType
    {
        MP3,
        MP4
    }
}
