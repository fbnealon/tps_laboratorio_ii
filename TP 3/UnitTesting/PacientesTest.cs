using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace UnitTesting
{
    [TestClass]
    public class PacientesTest
    {
        [TestMethod]
        public void AgregarAfiliadoQueYaEstaEnLaLista_DeberiaRetornarFalse()
        {
            Pacientes<Persona> pacientes = new Pacientes<Persona>();
            Afiliado afiliado = new Afiliado(1, "afi", "liado", 20, "A0123", EEspecialidades.Clínico);
            Afiliado afiliado2 = new Afiliado(1, "afi", "liado", 20, "A0123", EEspecialidades.Clínico);


            pacientes += afiliado;
            pacientes += afiliado2;

            Assert.IsFalse(pacientes.Listado.Count == 2);
        }

        [TestMethod]
        public void AgregarNoAfiliadoQueYaEstaEnLaLista_DeberiaRetornarFalse()
        {
            Pacientes<Persona> pacientes = new Pacientes<Persona>();
            NoAfiliado noAfiliado = new NoAfiliado(1, "afi", "liado", 20, "12345678", EEspecialidades.Clínico);
            NoAfiliado noAfiliado2 = new NoAfiliado(1, "afi", "liado", 20, "12345678", EEspecialidades.Clínico);


            pacientes += noAfiliado;
            pacientes += noAfiliado2;

            Assert.IsFalse(pacientes.Listado.Count == 2);
        }
    }
}
