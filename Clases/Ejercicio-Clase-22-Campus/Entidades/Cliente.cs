using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string cuit;

        public Cliente(string nombre, string apellido, string cuit)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cuit = cuit;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public string Cuit
        {
            get
            {
                return this.cuit;
            }
            set
            {
                this.cuit = "";
                // Corroboro la cantidad de caracteres
                if (value.Length == 13)
                {
                    // Divido el CUIT por sus -
                    string[] valores = value.Split(new char[] { '-' });
                    // Debe tener 3 partes
                    if (valores.Length == 3)
                    {
                        // Compruebo que todos sean valores numéricos
                        int j;
                        for (int i = 0; i < valores.Length; i++)
                        {
                            if( ! int.TryParse(valores[i], out j) )
                                return;
                        }
                        // CUIT valido
                        this.cuit = value;
                    }
                }
            }
        }
    }
}
