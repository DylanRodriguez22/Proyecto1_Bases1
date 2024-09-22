using ERP.wwwroot;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ERP.Pages.RRHH
{
    public class RegistrarEmpleadoModel : PageModel
    {
        [BindProperty]
        public string primerNombre { get; set; } = "";

        public string segundoNombre { get; set; } = "";

        [BindProperty]
        public string primerApellido { get; set; } = "";

        [BindProperty]
        public string segundoApellido { get; set; } = "";

        [BindProperty]
        [RegularExpression("^\\d+$", ErrorMessage = "La cedula solo debe contener numeros.")]
        [MinLength(9, ErrorMessage = "La cedula debe contener al menos 9 digitos.")]
        public string cedula { get; set; } = "";

        public string salario { get; set; } = "";
        public DateTime fechaHoy;

        public Direccion direccion;
        public void OnGet()
        {
            fechaHoy = DateTime.Now;
            direccion = new Direccion();
        }
    }
}
