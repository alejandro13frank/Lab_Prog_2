using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
using FmrCentralTelefonica;
namespace TestCentralita
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EstaInstanciadaListaLlamadas()
        {
            Centralita c = new Centralita();

            Assert.IsNotNull(c.Llamadas);
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void SeLanzoException()
        {
            Centralita c = new Centralita();
            Local llamadaA = new Local("45", 4, "55", 45);
            Local llamadaB = new Local("45", 4, "55", 45);
            c += llamadaA;
            c += llamadaB;
        }
    }
}
