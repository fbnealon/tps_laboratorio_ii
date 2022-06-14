using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace UnitTesting
{
    [TestClass]
    public class NoAfiliadoTest
    {
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void NoAfiliado_NuevoConDniInvalidoDeberiaLanzarExcepcion()
        {
            NoAfiliado noAfiliado = new NoAfiliado(1, "nombre", "apellido", 5, "37abc", EEspecialidades.Clínico);
        }
    }
}
