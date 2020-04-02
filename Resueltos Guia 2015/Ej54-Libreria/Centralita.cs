using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using Ej54_CentralitaSerializacion;

namespace Ej54_Libreria
{
    [Serializable]
    public class Centralita : ISerializable
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        private string ruta;

        #region Propiedades
        /// <summary>
        /// Retorna la lista de llamadas de la central
        /// </summary>
        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }
        /// <summary>
        /// Retorna las ganancias en la central sólo para llamadas Locales
        /// </summary>
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        /// <summary>
        /// Retorna las ganancias en la central sólo para llamadas Provinciales
        /// </summary>
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        /// <summary>
        /// Retorna las ganancias en la central para todas las llamadas
        /// </summary>
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        #endregion

        #region Constructores
        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa)
            : this()
        {
            this._razonSocial = nombreEmpresa;
        }
        #endregion

        #region Métodos

        private bool GuardarEnArchivo(Llamada unaLlamada, bool agrego)
        {
            try
            {
                string path = this.ruta + Path.DirectorySeparatorChar + "Llamadas.txt";
                //Genero el stream
                StreamWriter sw = new StreamWriter(path, agrego);
                //Escrito todo el archivo
                sw.Write(unaLlamada.ToString());
                //Cierro el archivo
                sw.Close();

                return true;
            }
            catch (Exception ex)
            {
                throw new CentralitaException("No se pudo guardar el archivo Llamadas.txt.", "Centralita", "GuardarEnArchivo", ex);
            }
        }

        public string RecuperarArchivoTexto()
        {
            try
            {
                string path = this.ruta + Path.DirectorySeparatorChar + "Llamadas.txt";
                //Genero el stream
                StreamReader sr = new StreamReader(path);
                //Leo todo el archivo
                string datos = sr.ReadToEnd();
                //Cierro el archivo
                sr.Close();

                return datos;
            }
            catch (Exception ex)
            {
                throw new CentralitaException("No se pudo guardar el archivo Llamadas.txt.", "Centralita", "GuardarEnArchivo", ex);
            }
        }

        /// <summary>
        /// Recibe un Enumerado de tipo TipoLlamada y retornará el valor de lo recaudado, según el criterio elegido.
        /// </summary>
        /// <param name="tipo">Criterio para la suma de las ganancias.</param>
        /// <returns></returns>
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float total = 0;
            // Recorro la lista de llamadas.
            foreach (Llamada l in this._listaDeLlamadas)
            {
                // Según el tipo de llamada que quiero analizar, opero.
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        // Si el TipoLlamada es Local y la clase es del tipo Local...
                        if (l is Local)
                            total += ((Local)l).CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        // Si el TipoLlamada es Provincial y la clase es del tipo Provincial...
                        if (l is Provincial)
                            total += ((Provincial)l).CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Todas:
                        // Si el TipoLlamada es Todas y verifico el tipo de la llamada para castear.
                        if (l is Local)
                            total += ((Local)l).CostoLlamada;
                        else if (l is Provincial)
                            total += ((Provincial)l).CostoLlamada;
                        break;
                }
            }

            return total;
        }
        /// <summary>
        /// Genera y retorna una cadena de texto con la información de la central.
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CENTRAL  : " + this._razonSocial);
            sb.AppendLine("*******************************************");

            sb.AppendLine("GANANCIAS");
            sb.AppendLine("TOTALES      : " + this.GananciasPorTotal);
            sb.AppendLine("LOCALES      : " + this.GananciasPorLocal);
            sb.AppendLine("PROVINCIALES : " + this.GananciasPorProvincial);

            sb.AppendLine("*******************************************");
            sb.AppendLine("DETALLE DE LLAMADAS");
            foreach (Llamada llamada in this._listaDeLlamadas)
            {
                sb.AppendLine(llamada.ToString());
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this._listaDeLlamadas.Add(nuevaLlamada);
            try
            {
                this.GuardarEnArchivo(nuevaLlamada, true);
            }
            catch (CentralitaException ce)
            {
                throw ce;
            }
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach(Llamada l in c.Llamadas)
            {
                if(llamada == l)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            try
            {
                if (c != nuevaLlamada)
                    c.AgregarLlamada(nuevaLlamada);
                else
                    throw new CentralitaException("La llamada ya existe.", "Centralita", "Operator +");
                return c;
            }
            catch (CentralitaException ce)
            {
                throw ce;
            }
        }

        #endregion

        #region ISerializable Members

        public string RutaDeArchivo
        {
            get
            {
                return this.ruta;
            }
            set
            {
                this.ruta = value;
            }
        }

        public bool DeSerializarse()
        {
            try
            {
                string path = this.ruta + Path.DirectorySeparatorChar + "Centralita.bin";
                //Genero el stream
                Stream myFileStream = File.OpenRead(path);
                BinaryFormatter deserializer = new BinaryFormatter();
                //Leo todo el archivo
                Centralita c = (Centralita)(deserializer.Deserialize(myFileStream));
                //Cierro el archivo
                myFileStream.Close();

                // Copio los datos
                this._listaDeLlamadas = c.Llamadas;
                //this._razonSocial = c._razonSocial;

                return true;
            }
            catch (Exception ex)
            {
                throw new CentralitaException("No se pudo leer el archivo.", "Centralita", "DeSerializarse", ex);
            }
        }

        public bool Serializarse()
        {
            try
            {
                string path = this.ruta + Path.DirectorySeparatorChar + "Centralita.bin";
                //Genero el stream
                Stream myFileStream = File.Create(path);
                BinaryFormatter serializer = new BinaryFormatter();
                //Leo todo el archivo
                serializer.Serialize(myFileStream, this);
                //Cierro el archivo
                myFileStream.Close();

                return true;
            }
            catch (Exception ex)
            {
                throw new CentralitaException("No se pudo guardar el archivo.", "Centralita", "Serializarse", ex);
            }
        }

        #endregion
    }
}
