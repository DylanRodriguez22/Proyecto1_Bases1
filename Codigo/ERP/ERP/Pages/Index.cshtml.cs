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
            // Aqu� puedes hacer una autenticaci�n sencilla para un proyecto local
            if (Usuario == "." && Contrasenia == ".")
            {
                // Guardar el usuario en la sesi�n
                HttpContext.Session.SetString("Usuario", Usuario);

                // Redirigir a la p�gina principal (por ejemplo, un dashboard)
                return RedirectToPage("/Privacy");
            }

            // Mostrar un mensaje de error si la autenticaci�n falla
            Message = "Usuario o contrase�a incorrectos";
            return Page();
        }
    }
}
