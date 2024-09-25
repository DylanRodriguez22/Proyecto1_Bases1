using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace ERP.Pages.Administrador
{
    public class InsertarPuestoModel : PageModel
    {
        public BaseDeDatos baseDeDatos = new BaseDeDatos();
        public List<string> departamentos = new List<string>();
        [BindProperty]
        public string puesto { get; set; } = "";
        public void OnGet()
        {
            consultarDepartamentos();
        }

        public void consultarDepartamentos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(baseDeDatos.stringConexion))
                {
                    conexion.Open();
                    SqlCommand cmd = conexion.CreateCommand();
                    cmd.CommandText = "select nombre from RRHH.Departamento";
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        departamentos.Add(reader.GetString(0));
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex) { }
        }
    }
}
