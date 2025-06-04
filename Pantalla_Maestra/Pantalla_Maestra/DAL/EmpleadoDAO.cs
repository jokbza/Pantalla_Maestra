using Pantalla_Maestra.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pantalla_Maestra.DAL
{
    public class EmpleadoDAO
    {
        private readonly ConexionDB conexion = new ConexionDB();

        public void Crear(Empleado empleado)
        {
            using (SqlConnection conn = conexion.GetConnection()) { try { conn.Open(); string query = "INSERT INTO Empleados (Documento, Nombre, Apellido, Puesto, FechaContratacion) VALUES (@Documento, @Nombre, @Apellido, @Puesto, @FechaContratacion)"; using (SqlCommand cmd = new SqlCommand(query, conn)) { cmd.Parameters.AddWithValue("@Documento", empleado.Documento); cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre); cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido); cmd.Parameters.AddWithValue("@Puesto", empleado.Puesto); cmd.Parameters.AddWithValue("@FechaContratacion", empleado.FechaContratacion); cmd.ExecuteNonQuery(); } } catch (SqlException ex) { MessageBox.Show("Error al crear el empleado: " + ex.Message); } }
        }

        public DataTable Consultar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.GetConnection()) { try { conn.Open(); string query = "SELECT * FROM Empleados ORDER BY EmpleadoID"; using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn)) { adapter.Fill(dt); } } catch (SqlException ex) { MessageBox.Show("Error al consultar empleados: " + ex.Message); } }
            return dt;
        }

        public void Actualizar(Empleado empleado)
        {
            using (SqlConnection conn = conexion.GetConnection()) { try { conn.Open(); string query = "UPDATE Empleados SET Documento = @Documento, Nombre = @Nombre, Apellido = @Apellido, Puesto = @Puesto, FechaContratacion = @FechaContratacion WHERE EmpleadoID = @EmpleadoID"; using (SqlCommand cmd = new SqlCommand(query, conn)) { cmd.Parameters.AddWithValue("@EmpleadoID", empleado.EmpleadoID); cmd.Parameters.AddWithValue("@Documento", empleado.Documento); cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre); cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido); cmd.Parameters.AddWithValue("@Puesto", empleado.Puesto); cmd.Parameters.AddWithValue("@FechaContratacion", empleado.FechaContratacion); cmd.ExecuteNonQuery(); } } catch (SqlException ex) { MessageBox.Show("Error al actualizar el empleado: " + ex.Message); } }
        }

        public void Eliminar(int empleadoId)
        {
            using (SqlConnection conn = conexion.GetConnection()) { try { conn.Open(); string query = "DELETE FROM Empleados WHERE EmpleadoID = @EmpleadoID"; using (SqlCommand cmd = new SqlCommand(query, conn)) { cmd.Parameters.AddWithValue("@EmpleadoID", empleadoId); cmd.ExecuteNonQuery(); } } catch (SqlException ex) { MessageBox.Show("Error al eliminar el empleado: " + ex.Message); } }
        }
    }
}