using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using YouTubeDownloader.Library;

namespace YouTubeDownloader.RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDownloader _downloader;

        [BindProperty]
        public FileType SelectedFileType { get; set; }
        [BindProperty]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        [Required]
        public string URL { get; set; } = "";

        public IndexModel(ILogger<IndexModel> logger, IDownloader downloader)
        {
            _logger = logger;
            _downloader = downloader;
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            string guid = Guid.NewGuid().ToString();

            var options = new VideoDownloadOptions
            {
                URL = URL,
                FileType = SelectedFileType,
                OutputFolder = @$"Downloads\Temp\{guid}"
            };

            var response = await _downloader.Download(options);

            if (response.Item1 != DownloadResponse.Success)
            {
                ModelState.AddModelError("URL", "Invalid URL.");
                return Page();
            }

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
