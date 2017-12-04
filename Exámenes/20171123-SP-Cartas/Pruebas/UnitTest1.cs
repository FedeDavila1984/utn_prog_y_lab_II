using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EntidadesAlumno;
using EntidadesHechas;

namespace Pruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CorreoListaPaquetes()
        {
            // Realizar test que verifique que la lista de Paquetes del Correo esté instanciada
            Correo c = new Correo();
            Assert.IsNotNull(c.Paquetes);
        }
        [TestMethod]
        public void CorreoAgregaPaquetesTrackingIgual()
        {
            // Realizar test que verifique que no se puedan cargar dos Paquetes con el mismo Tracking ID
            Correo c = new Correo();

            Paquete paq1 = new Paquete("Dir 1", "123-456-789");
            Paquete paq2 = new Paquete("Dir 2", "123-456-789");

            c += paq1;
            try
            {
                c = c + paq2;
            }
            catch (TrackingIdRepetidoException ex)
            {
                Assert.IsInstanceOfType(ex, typeof(TrackingIdRepetidoException));
            }
            // Verifico que sólo haya un elemento agregado
            Assert.IsTrue(c.Paquetes.Count == 1);
        }
    }
}
