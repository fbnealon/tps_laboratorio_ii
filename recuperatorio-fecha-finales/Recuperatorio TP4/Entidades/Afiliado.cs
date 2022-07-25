using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Afiliado : Persona
    {
        private string nroAfiliado;

        public Afiliado(int id, string nombre, string apellido, int edad, string nroAfiliado, EEspecialidades especialidad)
            : base(id, nombre, apellido, edad, especialidad)
        {
            this.nroAfiliado = nroAfiliado;
            if (!this.nroAfiliado.StartsWith("A"))
            {
                throw new NumeroAfiliadoInvalidoException("Los numeros de afiliado comienzan con A");
            }
        }

        public Afiliado()
        {

        }
        public string NroAfiliado { get => this.nroAfiliado; set => this.nroAfiliado = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Numero de afiliado: {this.nroAfiliado} ");

            return sb.ToString();
        }

        public static bool operator ==(Afiliado a1, Afiliado a2)
        {
            bool rta = false;
            if (a1 is not null && a2 is not null)
            {
                if (a1==(Persona)a2 && a1.nroAfiliado == a2.nroAfiliado)
                {
                    rta = true;
                }
            }
            return rta;
        }

        public static bool operator !=(Afiliado a1, Afiliado a2)
        {
            return !(a1 == a2);
        }

        public override bool Equals(object obj)
        {
            return obj is Afiliado afiliado && this == afiliado;
        }
    }
}
