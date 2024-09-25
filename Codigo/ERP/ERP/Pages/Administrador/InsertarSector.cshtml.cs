using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace ERP.Pages.Administrador
{
    public class InsertarSectorModel : PageModel
    {
        [BindProperty]
        public string sector { get; set; } = "";
        public BaseDeDatos baseDeDatos = new BaseDeDatos();
        //Se ejecuta cuando presiono el botón
        public void OnGet()
        {
            int cuenta = 0;
            string sectorBusqueda = "'" + sector + "'";
            try
            {
                using (SqlConnection conexion = new SqlConnection(baseDeDatos.stringConexion))
                {
                    conexion.Open();
                    SqlCommand cmd = conexion.CreateCommand();
                    cmd.CommandText = "select COUNT(*) as cuenta from Ventas.Sector where descripcion= " + sectorBusqueda;
                    cuenta = (int)cmd.ExecuteScalar();

                    if (cuenta > 0) {
                        //Insertar
                        try
                        {
                            using (SqlConnection conexion2 = new SqlConnection(baseDeDatos.stringConexion))
                            {
                                conexion2.Open();
                                SqlCommand cmd2 = conexion2.CreateCommand();
                                cmd2.CommandText = "i"
                            }
                        }
                        catch (Exception ex) { }
                    }
                  
                }
            }
            catch (Exception ex) { }
        }
    }
}
