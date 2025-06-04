using System;

namespace Pantalla_Maestra.Entities
{
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Puesto { get; set; }
        public DateTime FechaContratacion { get; set; }
    }
}