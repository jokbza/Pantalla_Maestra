using System.Data.SqlClient;

namespace Pantalla_Maestra.DAL
{
    // Clase para manejar la conexión a la base de datos [cite: 52]
    public class ConexionDB
    {
        // Cadena de conexión apuntando a tu servidor SQL Server específico [cite: 8]
        private readonly string connectionString = "Server=CHEPE\\SQLEXPRESS;Database=bd_gestion;Trusted_Connection=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}