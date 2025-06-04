using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pantalla_Maestra.DAL
{
    public class UsuarioDAO
    {
        private readonly ConexionDB conexion = new ConexionDB();

        public string ValidarCredenciales(string usuario, string contrasena)
        {
            string rol = null;
            using (SqlConnection conn = conexion.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Rol FROM Usuarios WHERE Usuario = @user AND Contrasena = @pass";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", usuario);
                        cmd.Parameters.AddWithValue("@pass", contrasena);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            rol = result.ToString();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error de base de datos al validar: " + ex.Message);
                }
            }
            return rol;
        }
    }
}