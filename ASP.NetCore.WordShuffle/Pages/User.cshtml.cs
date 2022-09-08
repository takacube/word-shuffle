using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NetCore.WordShuffle.Pages
{
    public class UserModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public UserModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}