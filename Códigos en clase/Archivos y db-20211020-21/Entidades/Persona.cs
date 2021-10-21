using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Entidades
{
    public class Persona
    {
        private static SqlConnection conn;
        private static SqlCommand command;

        private string nombre;
        private int edad;
        private bool vive;

        static Persona()
        {
            string connString = @"Data Source=.\SQLEXPRESS; Initial Catalog=Empresa; Integrated Security=True";

            Persona.conn = new SqlConnection(connString);

            Persona.command = new SqlCommand();
            Persona.command.CommandType = System.Data.CommandType.Text;
            Persona.command.Connection = Persona.conn;
        }

        public string Nombre
        {
            get => this.nombre;
            set => this.nombre = value;
        }
        public int Edad
        {
            get => this.edad;
            set => this.edad = value;
        }
        public bool Vive
        {
            get => this.vive;
            set => this.vive = value;
        }

        public static List<Persona> GetLista()
        {
            List<Persona> personas = new List<Persona>();

            Persona.command.CommandText = "Select * From personas"; // nombre,edad,estadoDeVida

            try
            {
                Persona.conn.Open();
                // Persona.command.Connection.Open();

                SqlDataReader reader = Persona.command.ExecuteReader();

                while (reader.Read())
                {
                    Persona p = new Persona();

                    // p.Nombre = reader.GetString(0);

                    //p.Nombre = reader[0].ToString();
                    //p.Edad = int.Parse(reader[1].ToString());
                    //p.Vive = bool.Parse(reader[2].ToString());

                    p.Nombre = reader["nombre"].ToString();
                    p.Edad = int.Parse(reader["edad"].ToString());
                    p.Vive = bool.Parse(reader["estadoDeVida"].ToString());

                    personas.Add(p);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Persona.conn.Close();
            }

            return personas;
        }

        public static void Delete(decimal id)
        {
            Persona.command.CommandText = "Delete From personas Where id = @ID";
            Persona.command.Parameters.Add(new SqlParameter("ID", id));

            try
            {
                Persona.conn.Open();

                Persona.command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Persona.conn.Close();
            }
        }
    }
}
