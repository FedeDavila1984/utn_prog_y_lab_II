using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Entidades
{
    public class Listado
    {
        public enum Estado { Invalido, Valido }
        List<Cliente> clientes;

        public Listado()
        {
            this.clientes = new List<Cliente>();
        }

        public List<Cliente> Clientes
        {
            get
            {
                return this.clientes;
            }
        }

        public bool CargaClientes()
        {
            string archivo = "Clientes.csv";
            try
            {
                using (StreamReader file = new StreamReader(archivo, Encoding.Default))
                {
                    while (!file.EndOfStream)
                    {
                        string[] separados = this.Parse(file.ReadLine());
                        this.clientes.Add(new Cliente(separados[0], separados[1], separados[2]));
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string MostrarClientes(Estado e)
        {
            string datos = "";

            foreach (Cliente c in this.clientes)
            {
                switch (e)
                {
                    case Estado.Valido:
                        if (c.Cuit.Length > 0)
                            datos += String.Format("{1}, {0}: {2}\n", c.Nombre, c.Apellido, c.Cuit);
                        break;
                    case Estado.Invalido:
                        if (c.Cuit.Length == 0)
                            datos += String.Format("{1}, {0}\n", c.Nombre, c.Apellido);
                        break;
                }
            }

            return datos;
        }

        public string[] Parse(string entrada)
        {
            return entrada.Split(new char[] { ';' });
        }
    }
}
