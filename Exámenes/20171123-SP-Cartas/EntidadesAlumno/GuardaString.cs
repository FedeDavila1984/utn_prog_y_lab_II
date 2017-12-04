using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace EntidadesAlumno
{
    public static class GuardaString
    {
        public static bool Guardar(this String texto, string archivo)
        {
            try
            {
                string fullPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Path.DirectorySeparatorChar + archivo;
                using (StreamWriter file = new StreamWriter(fullPath, true))
                {
                    file.WriteLine(texto);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
