using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IT3047_Final_Project01.Pages
{
    public class SuperheroModel : PageModel
    {
        private readonly ILogger<SuperheroModel> _logger;

        public SuperheroModel(ILogger<SuperheroModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}