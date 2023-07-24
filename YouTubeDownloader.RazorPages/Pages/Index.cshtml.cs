using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YouTubeDownloader.Library;

namespace YouTubeDownloader.RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private string downloadedFilePath = "";

        [BindProperty]
        public FileType SelectedOption { get; set; }
        [BindProperty]
        public string URL { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest();
            }

            string guid = Guid.NewGuid().ToString();

            VideoDownloadOptions options = new VideoDownloadOptions
            {
                URL = URL,
                FileType = SelectedOption,
                OutputFolder = @$"C:\Users\Ekas\Downloads\Temp\{guid}"
            };

            IDownloader downloader = new YtDlpDownloader();

            var response = await downloader.Download(options);

            string filePath = response.Item2;
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
            var fileContentResult = new FileContentResult(fileBytes, "application/octet-stream")
            {
                FileDownloadName = System.IO.Path.GetFileName(filePath)
            };
            
            return fileContentResult;
        }
    }
}
