using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string perro = "guau";
            string perro2;
            Xml<string> xml = new Xml<string>();
            xml.Guardar("perrito.xml", perro);
            xml.Leer("perrito.xml", out perro2);
            Assert.AreEqual(perro, perro2);
        }
    }
}
