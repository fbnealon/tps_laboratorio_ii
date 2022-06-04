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

        public string NroAfiliado { get => this.nroAfiliado; set => this.nroAfiliado = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Numero de afiliado: {this.nroAfiliado}");

            return sb.ToString();
        }
    }
}
