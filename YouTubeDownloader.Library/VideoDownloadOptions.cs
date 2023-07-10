using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownloader.Library
{
    public class VideoDownloadOptions
    {
        public string URL { get; set; }
        public string OutputFolder { get; set; }
        public FileType FileType{ get; set; }
    }
}
