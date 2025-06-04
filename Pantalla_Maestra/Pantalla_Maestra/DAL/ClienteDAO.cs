using Pantalla_Maestra.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pantalla_Maestra.DAL
{
    public class ClienteDAO
    {
        private readonly ConexionDB conexion = new ConexionDB();

        public void Crear(Cliente cliente)
        {
            using (SqlConnection conn = conexion.GetConnection()) { try { conn.Open(); string query = "INSERT INTO Clientes (Documento, Nombre, Apellido, Direccion, Telefono) VALUES (@Documento, @Nombre, @Apellido, @Direccion, @Telefono)"; using (SqlCommand cmd = new SqlCommand(query, conn)) { cmd.Parameters.AddWithValue("@Documento", cliente.Documento); cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre); cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido); cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion); cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono); cmd.ExecuteNonQuery(); } } catch (SqlException ex) { MessageBox.Show("Error al crear el cliente: " + ex.Message); } }
        }

        public DataTable Consultar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.GetConnection()) { try { conn.Open(); string query = "SELECT * FROM Clientes ORDER BY ClienteID"; using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn)) { adapter.Fill(dt); } } catch (SqlException ex) { MessageBox.Show("Error al consultar clientes: " + ex.Message); } }
            return dt;
        }

        public void Actualizar(Cliente cliente)
        {
            using (SqlConnection conn = conexion.GetConnection()) { try { conn.Open(); string query = "UPDATE Clientes SET Documento = @Documento, Nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion, Telefono = @Telefono WHERE ClienteID = @ClienteID"; using (SqlCommand cmd = new SqlCommand(query, conn)) { cmd.Parameters.AddWithValue("@ClienteID", cliente.ClienteID); cmd.Parameters.AddWithValue("@Documento", cliente.Documento); cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre); cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido); cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion); cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono); cmd.ExecuteNonQuery(); } } catch (SqlException ex) { MessageBox.Show("Error al actualizar el cliente: " + ex.Message); } }
        }

        public void Eliminar(int clienteId)
        {
            using (SqlConnection conn = conexion.GetConnection()) { try { conn.Open(); string query = "DELETE FROM Clientes WHERE ClienteID = @ClienteID"; using (SqlCommand cmd = new SqlCommand(query, conn)) { cmd.Parameters.AddWithValue("@ClienteID", clienteId); cmd.ExecuteNonQuery(); } } catch (SqlException ex) { MessageBox.Show("Error al eliminar el cliente: " + ex.Message); } }
        }
    }
}