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
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, datos);
                stream.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Leer(string archivo, out T datos)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                datos = (T)formatter.Deserialize(stream);
                stream.Close();

                return true;
            }
            catch (Exception)
            {
                datos = default(T);
                return false;
            }
        }
    }
}
