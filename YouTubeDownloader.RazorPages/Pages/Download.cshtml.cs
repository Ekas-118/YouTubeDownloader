using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace YouTubeDownloader.RazorPages.Pages
{
    public class DownloadModel : PageModel
    {
        private readonly IConfiguration _configuration;

        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }
        public string FileName { get; set; } = "";

        public DownloadModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult OnGet()
        {
            string location = Path.GetFullPath($"{_configuration["OutputDirectory"]}{Id}");
            if (Directory.Exists(location) == false)
            {
                Id = Guid.Empty;
                return Page();
            }

            var filePath = Directory.GetFiles(location).FirstOrDefault();
            if (string.IsNullOrEmpty(filePath))
            {
                Id = Guid.Empty;
                return Page();
            }

            FileName = Path.GetFileName(filePath);
            return Page();
        }

        public IActionResult OnPost()
        {
            string location = Path.GetFullPath($"{_configuration["OutputDirectory"]}{Id}");
            var filePath = Directory.GetFiles(location).First();
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "application/octet-stream", Path.GetFileName(filePath));
        }
    }
}
