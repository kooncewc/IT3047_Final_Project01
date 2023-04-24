using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IT3047_Final_Project01.Pages
{
    public class ComedyModel : PageModel
    {
        private readonly ILogger<ComedyModel> _logger;

        public ComedyModel(ILogger<ComedyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}