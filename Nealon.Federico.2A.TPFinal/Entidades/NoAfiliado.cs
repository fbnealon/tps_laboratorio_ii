using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class NoAfiliado : Persona
    {
        private string dni;

        public NoAfiliado(int id, string nombre, string apellido, int edad, string dni, EEspecialidades especialidad)
            : base(id, nombre, apellido, edad, especialidad)
        {
            if (ValidarDni(dni))
            {
                this.dni = dni;
            }
        }

        public string Dni { get => this.dni; set => this.dni = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"DNI: {this.dni}");

            return sb.ToString();
        }

        private bool ValidarDni(string dni)
        {
            bool rta = true;
            foreach (char c in dni)
            {
                if (c < '0' || c > '9')
                {
                    rta = false;
                    throw new DniInvalidoException("DNI se conforma de solo numeros");
                }
            }
            return rta;
        }
    }
}
