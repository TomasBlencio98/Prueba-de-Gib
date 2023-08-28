using Tema01.Recu.Entidades;

namespace Tema01.Recu.Prueba
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarFechaTest()
        {
            Assert.IsTrue(ValidadorFecha.Validar(22, 12, 1998));
        }
        [TestMethod]
        public void ValidarFechaTest2()
        {
            Assert.IsFalse(ValidadorFecha.Validar(-5, 12, 1998));
        }
        [TestMethod]
        public void GetAreaTest()
        {
            var piramide = new PiramideCuadrada(10, 5);
            Assert.AreNotEqual(10,piramide.GetArea());
        }
        [TestMethod]
        public void GetVolumenTest()
        {
            var piramide = new PiramideCuadrada(10,5);
            Assert.AreNotEqual(10,piramide.GetVolumen());
        }

    }
}