using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace EntidadesHechas
{
    public static class PaqueteDAO
    {
        #region Atributos
        private static SqlConnection _conexion;
        private static SqlCommand _comando;
        #endregion

        #region Constructores
        static PaqueteDAO()
        {
            // CREO UN OBJETO SQLCONECTION
            PaqueteDAO._conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);//CadenaConexionMDE);//
            // CREO UN OBJETO SQLCOMMAND
            PaqueteDAO._comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            PaqueteDAO._comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            PaqueteDAO._comando.Connection = PaqueteDAO._conexion;
        }
        #endregion

        #region Insertar
        public static bool Insertar(Paquete p)
        {
            string sql = "INSERT INTO Paquetes (direccionEntrega,trackingId,alumno) VALUES(";
            sql = sql + "'" + p.DireccionEntrega + "','" + p.TrackingID + "','profesor')";

            try
            {
                // LE PASO LA INSTRUCCION SQL
                PaqueteDAO._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                PaqueteDAO._conexion.Open();

                // EJECUTO EL COMMAND
                PaqueteDAO._comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (PaqueteDAO._conexion.State == ConnectionState.Open)
                    PaqueteDAO._conexion.Close();
            }

            return true;

        }
        #endregion
    }
}
