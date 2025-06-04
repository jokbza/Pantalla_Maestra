using Pantalla_Maestra.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pantalla_Maestra.DAL
{
    public class ProductoDAO
    {
        private readonly ConexionDB conexion = new ConexionDB();

        public void Crear(Producto producto)
        {
            using (SqlConnection conn = conexion.GetConnection()) { try { conn.Open(); string query = "INSERT INTO Productos (Codigo, Nombre, Descripcion, Precio, Stock) VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @Stock)"; using (SqlCommand cmd = new SqlCommand(query, conn)) { cmd.Parameters.AddWithValue("@Codigo", producto.Codigo); cmd.Parameters.AddWithValue("@Nombre", producto.Nombre); cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion); cmd.Parameters.AddWithValue("@Precio", producto.Precio); cmd.Parameters.AddWithValue("@Stock", producto.Stock); cmd.ExecuteNonQuery(); } } catch (SqlException ex) { MessageBox.Show("Error al crear el producto: " + ex.Message); } }
        }

        public DataTable Consultar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.GetConnection()) { try { conn.Open(); string query = "SELECT * FROM Productos ORDER BY ProductoID"; using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn)) { adapter.Fill(dt); } } catch (SqlException ex) { MessageBox.Show("Error al consultar productos: " + ex.Message); } }
            return dt;
        }

        public void Actualizar(Producto producto)
        {
            using (SqlConnection conn = conexion.GetConnection()) { try { conn.Open(); string query = "UPDATE Productos SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, Stock = @Stock WHERE ProductoID = @ProductoID"; using (SqlCommand cmd = new SqlCommand(query, conn)) { cmd.Parameters.AddWithValue("@ProductoID", producto.ProductoID); cmd.Parameters.AddWithValue("@Codigo", producto.Codigo); cmd.Parameters.AddWithValue("@Nombre", producto.Nombre); cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion); cmd.Parameters.AddWithValue("@Precio", producto.Precio); cmd.Parameters.AddWithValue("@Stock", producto.Stock); cmd.ExecuteNonQuery(); } } catch (SqlException ex) { MessageBox.Show("Error al actualizar el producto: " + ex.Message); } }
        }

        public void Eliminar(int productoId)
        {
            using (SqlConnection conn = conexion.GetConnection()) { try { conn.Open(); string query = "DELETE FROM Productos WHERE ProductoID = @ProductoID"; using (SqlCommand cmd = new SqlCommand(query, conn)) { cmd.Parameters.AddWithValue("@ProductoID", productoId); cmd.ExecuteNonQuery(); } } catch (SqlException ex) { MessageBox.Show("Error al eliminar el producto: " + ex.Message); } }
        }
    }
}