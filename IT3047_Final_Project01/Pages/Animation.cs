using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IT3047_Final_Project01.Pages
{
    public class AnimationModel : PageModel
    {
        private readonly ILogger<AnimationModel> _logger;

        public AnimationModel(ILogger<AnimationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}