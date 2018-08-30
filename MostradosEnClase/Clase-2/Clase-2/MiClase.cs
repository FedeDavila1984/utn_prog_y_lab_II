using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    public class MiClase
    {
        private static int atributoEstatico;
        private int atributoNoEstatico;

        /// <summary>
        /// Constructor estático
        /// </summary>
        static MiClase()
        {
            MiClase.atributoEstatico = 101;
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public MiClase()
        {
        }

        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="noEstatico"></param>
        public MiClase(int noEstatico)
        {
            this.atributoNoEstatico = noEstatico;
        }

        /// <summary>
        /// Constructor de instancia que recibe los dos parametros de la clase
        /// </summary>
        /// <param name="estatico"></param>
        /// <param name="noEstatico"></param>
        public MiClase(int estatico, int noEstatico)
        {
            this.atributoNoEstatico = noEstatico;
            MiClase.atributoEstatico = estatico;
        }

        /// <summary>
        /// Retorna el atributo estático de la clase
        /// </summary>
        /// <returns>Atributo estático</returns>
        public static int ValorEstatico()
        {
            return MiClase.atributoEstatico;
        }

        /// <summary>
        /// Retorna el atributo del objeto (no estático)
        /// </summary>
        /// <returns>Atributo del objeto</returns>
        public int? ValorNoEstatico()
        {
            //return this.atributoNoEstatico;
            return null;
        }
    }
}
