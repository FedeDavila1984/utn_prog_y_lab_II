using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Archivos
{
    public class Binario<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            Stream stream = null;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                stream = new FileStream(archivo, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, datos);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if(!ReferenceEquals(stream, null))
                    stream.Close();
            }
        }
        public bool Leer(string archivo, out T datos)
        {
            Stream stream = null;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                stream = new FileStream(archivo, FileMode.Open, FileAccess.Read, FileShare.Read);
                datos = (T)formatter.Deserialize(stream);
                //stream.Close();

                return true;
            }
            catch (Exception)
            {
                datos = default(T);
                return false;
            }
            finally
            {
                if (!ReferenceEquals(stream, null))
                    stream.Close();
            }
        }
    }
}
