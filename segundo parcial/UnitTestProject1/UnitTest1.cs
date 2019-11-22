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
            string aux = "Hola mundo";
            string rtn;
            Xml<string> xml = new Xml<string>();

            xml.Guardar("Prueba", aux);
            xml.Leer("Prueba", out rtn);

            Assert.AreEqual(aux, rtn);
        }

        [TestMethod]
        [ExpectedException(typeof(ErrorArchivoException))]
        public void TestMethod2()
        {
            Xml<string> xml = new Xml<string>();

            xml.Guardar("$%·%(&T/¨^", "Hola mundo");
        }
    }

}
