using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Entidades
{
    public class ProductoDAO
    {
        private SqlConnection conexion;
        private SqlCommand comando;

        public ProductoDAO()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
            this.comando = new SqlCommand();
            // No hace falta ponerlo como Text, es el default
            // this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.Connection = this.conexion;
        }

        public List<Producto> GetProductos()
        {
            comando.CommandText = "SELECT id, descripcion FROM Productos";

            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                SqlDataReader oDr = comando.ExecuteReader();

                List<Producto> lista = new List<Producto>();
                while (oDr.Read())
                {
                    int id;
                    int.TryParse(oDr["id"].ToString(), out id);
                    string descrip = oDr["descripcion"].ToString();

                    Producto prod = new Producto(id, descrip);
                    lista.Add(prod);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexion.Close();
            }
        }

        public void Insert(Producto p)
        {
            comando.Parameters.Clear();
            comando.CommandText = "INSERT INTO Productos(descripcion,idTipoProducto) VALUES(@descrip, @idTipoProducto)";
            comando.Parameters.AddWithValue("@descrip", p.Descripcion);
            comando.Parameters.AddWithValue("@idTipoProducto", 1);

            this.Ejecutar();
        }

        public void Delete(Producto p)
        {
            comando.Parameters.Clear();
            comando.CommandText = "DELETE FROM Productos WHERE id = @id";
            comando.Parameters.AddWithValue("@id", p.Id);

            this.Ejecutar();
        }

        private void Ejecutar()
        {
            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexion.Close();
            }
        }
    }
}
