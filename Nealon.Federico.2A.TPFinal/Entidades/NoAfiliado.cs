using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NoAfiliado : Persona
    {
        private string dni;

        public NoAfiliado(int id, string nombre, string apellido, int edad, string dni)
            : base(id, nombre, apellido, edad)
        {
            this.dni = dni;
        }

        public string Dni { get => this.dni; set => this.dni = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"DNI: {this.dni}");

            return sb.ToString();
        }
    }
}
