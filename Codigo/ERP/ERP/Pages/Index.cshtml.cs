using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ERP.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public string Usuario { get; set; } = "";

        [BindProperty]
        public string Contrasenia { get; set; } = "";

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Message { get; set; }

        public IActionResult OnPost()
        {
            
             // Guardar el usuario en la sesi�n
             HttpContext.Session.SetString("Usuario", Usuario);

             // Redirigir a la p�gina principal (por ejemplo, un dashboard)
             return RedirectToPage("/Privacy");
            

        
        }
    }
}
