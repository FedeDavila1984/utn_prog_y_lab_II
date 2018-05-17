using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class TestEntidades
    {
        [TestMethod]
        public void ValidaCuit()
        {
            Cliente c = new Cliente("A2", "D2", "2-12345678-9");
            Assert.AreNotEqual("2-12345678-9", c.Cuit);

            c.Cuit = "22-123456789";
            Assert.AreEqual("", c.Cuit);

            c.Cuit = "2a-12345678-9";
            Assert.AreEqual("", c.Cuit);

            c.Cuit = "22-1234567j-9";
            Assert.AreEqual("", c.Cuit);

            c.Cuit = "28-12345678-?";
            Assert.AreEqual("", c.Cuit);

            c.Cuit = "00-12345678-9";
            Assert.AreEqual("00-12345678-9", c.Cuit);
        }

        [TestMethod]
        public void ParseArchivo()
        {
            Listado l = new Listado();
            string[] partes = l.Parse("Nombre;Apellido;00-12345678-9");

            Assert.AreEqual("Nombre", partes[0]);
            Assert.AreEqual("Apellido", partes[1]);
            Assert.AreEqual("00-12345678-9", partes[2]);

            //Assert.IsTrue(partes[0] == "Nombre");

            //Assert.IsInstanceOfType(l, typeof(Listado));
        }
    }
}
