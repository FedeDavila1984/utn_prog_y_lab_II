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
            Assert.AreNotEqual(c.Cuit, "2-12345678-9");

            c.Cuit = "22-123456789";
            Assert.AreEqual(c.Cuit, "");

            c.Cuit = "2a-12345678-9";
            Assert.AreEqual(c.Cuit, "");

            c.Cuit = "22-1234567j-9";
            Assert.AreEqual(c.Cuit, "");

            c.Cuit = "28-12345678-?";
            Assert.AreEqual(c.Cuit, "");

            c.Cuit = "00-12345678-9";
            Assert.AreEqual(c.Cuit, "00-12345678-9");
        }

        [TestMethod]
        public void ParseArchivo()
        {
            Listado l = new Listado();
            string[] partes = l.Parse("Nombre;Apellido;00-12345678-9");

            Assert.AreEqual(partes[0], "Nombre");
            Assert.AreEqual(partes[1], "Apellido");
            Assert.AreEqual(partes[2], "00-12345678-9");
        }
    }
}
