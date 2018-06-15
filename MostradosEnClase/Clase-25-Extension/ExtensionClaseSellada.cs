using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase_25_Extension;

namespace Extensor
{
    public static class ExtensionClaseSellada
    {
        public static string MetodoExtendido(this ClaseSellada miClase, string prefijo)
        {
            return String.Format("{1} <---> {0}", miClase.ID, prefijo);
        }

        public static string MetodoExtendido(this ClaseSellada miClase, string prefijo, string otro)
        {
            return String.Format("{1} <---> {0} <---> {2}", miClase.ID, prefijo, otro);
        }

        public static string MetodoExtendido(this String miClase, string prefijo)
        {
            return String.Format("{1} <---> {0}", prefijo, miClase);
        }
    }
}
