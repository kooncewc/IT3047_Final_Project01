using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IT3047_Final_Project01.Pages
{
    public class ActionModel : PageModel
    {
        private readonly ILogger<ActionModel> _logger;

        public ActionModel(ILogger<ActionModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}