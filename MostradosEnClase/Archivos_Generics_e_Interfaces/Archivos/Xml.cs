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
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(archivo, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(V));
                //TextWriter writer = new StreamWriter(archivo);
                serializer.Serialize(writer, datos);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if(!object.ReferenceEquals(writer, null))
                    writer.Close();
            }
        }
        public bool Leer(string archivo, out V datos)
        {
            XmlTextReader writer = null;
            try
            {
                writer = new XmlTextReader(archivo);
                XmlSerializer serializer = new XmlSerializer(typeof(V));
                //TextReader writer = new StreamReader(archivo);
                datos = (V)serializer.Deserialize(writer);
                writer.Close();

                return true;
            }
            catch (Exception)
            {
                datos = default(V);
                return false;
            }
            finally
            {
                if (!object.ReferenceEquals(writer, null))
                    writer.Close();
            }
        }
    }
}
