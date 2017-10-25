using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Xml<V> : IArchivo<V>
    {
        public bool Guardar(string archivo, V datos)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(V));
                //TextWriter writer = new StreamWriter(archivo);
                XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
                serializer.Serialize(writer, datos);
                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool Leer(string archivo, out V datos)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(V));
                //TextReader writer = new StreamReader(archivo);
                XmlTextReader writer = new XmlTextReader(archivo);
                datos = (V)serializer.Deserialize(writer);
                writer.Close();

                return true;
            }
            catch (Exception)
            {
                datos = default(V);
                return false;
            }
        }
    }
}
