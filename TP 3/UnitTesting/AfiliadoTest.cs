using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;


namespace UnitTesting
{
    [TestClass]
    public class AfiliadoTest
    {
        [TestMethod]
        [ExpectedException(typeof(NumeroAfiliadoInvalidoException))]
        public void Afiliado_NuevoConNumeroInvalidoDeberiaLanzarExcepcion()
        {
            Afiliado afiliado = new Afiliado(1, "nombre", "apellido", 5, "No empieza con a", EEspecialidades.Clínico);
        }
    }
}
