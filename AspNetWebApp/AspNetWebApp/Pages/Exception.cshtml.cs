using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetWebApp.Pages
{
    public class ExceptionModel : PageModel
    {
        public void OnGet()
        {
            throw new NotImplementedException();
        }
    }
}
