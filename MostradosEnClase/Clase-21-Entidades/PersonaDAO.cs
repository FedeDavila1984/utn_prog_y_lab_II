using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class PersonaDAO
    {
        #region Atributos
        private static SqlConnection _conexion;
        private static SqlCommand _comando;
        #endregion

        #region Constructores
        static PersonaDAO()
        {
            // CREO UN OBJETO SQLCONECTION
            PersonaDAO._conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);//CadenaConexionMDE);//
            // CREO UN OBJETO SQLCOMMAND
            PersonaDAO._comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            PersonaDAO._comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            PersonaDAO._comando.Connection = PersonaDAO._conexion;
        }
        #endregion

        #region Métodos

        #region Getters
        public static Persona ObtienePersona()
        {
            bool TodoOk = false;
            Persona persona = null;

            try
            {
                // LE PASO LA INSTRUCCION SQL
                PersonaDAO._comando.CommandText = "SELECT TOP 1 id,nombre,apellido,dni FROM Personas";

                // ABRO LA CONEXION A LA BD
                PersonaDAO._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = PersonaDAO._comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                if (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    persona = new Persona(int.Parse(oDr["id"].ToString()), oDr["nombre"].ToString(), oDr["apellido"].ToString(), int.Parse(oDr["dni"].ToString()));
                }

                //CIERRO EL DATAREADER
                oDr.Close();

                TodoOk = true;
            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (TodoOk)
                    PersonaDAO._conexion.Close();
            }
            return persona;
        }
        #endregion

        #region Insertar Persona
        public static bool InsertaPersona(Persona p)
        {
            string sql = "INSERT INTO Personas (nombre,apellido,dni) VALUES(";
            sql = sql + "'" + p.Nombre + "','" + p.Apellido + "'," + p.DNI.ToString() + ")";

            return EjecutarNonQuery(sql);

        }
        #endregion

        #region Modificar Persona
        public static bool ModificaPersona(Persona p)
        {
            string sql = "UPDATE Personas SET nombre = '" + p.Nombre + "', apellido = '";
            sql = sql + p.Apellido + "', dni = " + p.DNI.ToString() + " WHERE id = " + p.ID.ToString();

            return EjecutarNonQuery(sql);
        }
        #endregion

        #region Eliminar Persona
        public static bool EliminaPersona(Persona p)
        {

            string sql = "DELETE FROM Personas WHERE id = " + p.ID.ToString();

            return EjecutarNonQuery(sql);
        }
        #endregion

        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                PersonaDAO._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                PersonaDAO._conexion.Open();

                // EJECUTO EL COMMAND
                PersonaDAO._comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    PersonaDAO._conexion.Close();
            }
            return todoOk;
        }

        #endregion
    }
}
