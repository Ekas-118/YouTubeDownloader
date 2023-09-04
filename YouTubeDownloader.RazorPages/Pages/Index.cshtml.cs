using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using YouTubeDownloader.Library;

namespace YouTubeDownloader.RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly IDownloader _downloader;

        [BindProperty]
        public FileType SelectedFileType { get; set; }

        [BindProperty]
        public string URL { get; set; } = "";

        public IndexModel(IConfiguration configuration, IDownloader downloader)
        {
            _configuration = configuration;
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
                OutputFolder = $"{_configuration["OutputDirectory"]}{guid}"
            };

            var response = await _downloader.Download(options);

            if (response.Item1 != DownloadResponse.Success)
            {
                ModelState.AddModelError(nameof(URL), "Invalid URL.");
                return Page();
            }

            return RedirectToPage($"/download", new { Id = guid });
        }
    }
}
