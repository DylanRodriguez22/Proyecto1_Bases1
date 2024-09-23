using ERP.wwwroot;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

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

        [BindProperty]
        public string salario { get; set; } = "";
        public DateTime fechaHoy = DateTime.Now;

        public Direccion direccion = new Direccion();
        public BaseDeDatos baseDeDatos = new BaseDeDatos();

        //Listas para los puestos
        public List<string> puestosRRHH = new List<string>();
        public List<string> puestosVentas = new List<string>();
        public List<string> puestosProduccion = new List<string>();
        public string ErrorMensaje { get; set; }
        public void OnGet()

        {
            baseDeDatos = new BaseDeDatos();
            fechaHoy = DateTime.Now;
            direccion = new Direccion();
            consultaPuestos();
        }

        //Esta función se ejecuta cuando se presiona el botón de Registrar Empleado
        public void OnPost()
        {
            //Por si ya tenían algo para evitar duplicados
            puestosRRHH.Clear();
            puestosVentas.Clear();
            puestosProduccion.Clear();

            //Parte de la inserción
            try
            {
                using (SqlConnection conexion = new SqlConnection(baseDeDatos.stringConexion))
                {
                    string primeraParte = "insert into RRHH.Usuario (usuario, cedula, primerNombre, segundoNombre, primerApellido, segundoApellido, genero, provincia, canton, distrito, seniaExacta,fechaRegistro, fechaDeNacimiento, salarioActual)";
                    string segundaParte = "values ('pepita','1414567890', 'María', 'Isabel', 'Ramírez', 'Jiménez', 'F', 'Alajuela', 'San Carlos', 'Quesada', 'Frente a la plaza central', '2024-09-22', '1985-08-12', 520000)";
                    conexion.Open();
                    using (SqlCommand cmd = conexion.CreateCommand()) {
    
                        cmd.CommandText = primeraParte + segundaParte;
                        //cmd.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (SqlException ex) { ErrorMensaje = ex.Message; }
            
        }

        public void consultaPuestos()
        {
            //Voy a buscar por cada departamento los puestos 
            //Primero RRHH
            try
            {
                using (SqlConnection conexion = new SqlConnection(baseDeDatos.stringConexion))
                {
                    conexion.Open();
                    SqlCommand cmd = conexion.CreateCommand();
                    cmd.CommandText = "select nombre from RRHH.Puesto where nombreD_Departamento = 'RRHH'";
                    var reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        puestosRRHH.Add(reader.GetString(0));
                    }
                    conexion.Close();
                }
                
            }
            catch (SqlException ex) { }

            //Ahora Ventas
            try
            {
                using (SqlConnection conexion = new SqlConnection(baseDeDatos.stringConexion))
                {
                    conexion.Open();
                    SqlCommand cmd = conexion.CreateCommand();
                    cmd.CommandText = "select nombre from RRHH.Puesto where nombreD_Departamento = 'Ventas'";
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        puestosVentas.Add(reader.GetString(0));
                    }
                    conexion.Close();
                }

            }
            catch (SqlException ex) { }

            //Producción
            try
            {
                using (SqlConnection conexion = new SqlConnection(baseDeDatos.stringConexion))
                {
                    conexion.Open();
                    SqlCommand cmd = conexion.CreateCommand();
                    cmd.CommandText = "select nombre from RRHH.Puesto where nombreD_Departamento = 'Produccion'";
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        puestosProduccion.Add(reader.GetString(0));
                    }
                    conexion.Close();
                }
            }
            catch (SqlException ex) { }
        }
    }
}
