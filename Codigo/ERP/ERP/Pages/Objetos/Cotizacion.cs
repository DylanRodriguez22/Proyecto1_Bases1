namespace ERP.Pages.Objetos
{
    public class Cotizacion
    {
        public int ID { get; set; }
        public string CedulaCliente { get; set; }
        public string CedulaEmpleado { get; set; }
        public int MontoTotal { get; set; }
        public DateTime FechaCierreProyectada { get; set; }
        public DateTime? FechaCierre { get; set; }
        public DateTime FechaHora { get; set; }
        public int Probabilidad { get; set; }
        public string Descripcion { get; set; }
        public string Zona { get; set; }
        public string Sector { get; set; }

        public Cotizacion(int id, string cedulaCliente, string cedulaEmpleado, int montoTotal, DateTime fechaCierreProyectada, DateTime fechaHora, int probabilidad, string descripcion, string zona, string sector, DateTime? fechaCierre = null)
        {
            ID = id;
            CedulaCliente = cedulaCliente;
            CedulaEmpleado = cedulaEmpleado;
            MontoTotal = montoTotal;
            FechaCierreProyectada = fechaCierreProyectada;
            FechaHora = fechaHora;
            Probabilidad = probabilidad;
            Descripcion = descripcion;
            Zona = zona;
            Sector = sector;
            FechaCierre = fechaCierre;
        }
    }
}