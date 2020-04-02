using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej54_CentralitaSerializacion
{
    public interface ISerializable
    {
        string RutaDeArchivo { get; set; }

        bool DeSerializarse();
        bool Serializarse();
    }
}
