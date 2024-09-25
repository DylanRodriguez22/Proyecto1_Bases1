using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ERP.Pages.Administrador
{
    public class InsertarZonasModel : PageModel
    {
        [BindProperty]
        public string zona { get; set; } = "";
        public void OnGet()
        {
        }
    }
}
