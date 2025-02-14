using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageActivity.Pages
{
    public class ServiceModel : PageModel
    {
        /*
                private readonly ILogger<ServiceModel> _logger;

                public ServiceModel(ILogger<ServiceModel> logger)
                {
                    _logger = logger;
                }

                public void OnGet()
                {
                }*/

        public List<string> name = new List<string>()
        {
            "prashant","maurya"
        };

    }
}