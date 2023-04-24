using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IT3047_Final_Project01.Pages
{
    public class WilmerModel : PageModel
    {
        private readonly ILogger<WilmerModel> _logger;

        public WilmerModel(ILogger<WilmerModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}