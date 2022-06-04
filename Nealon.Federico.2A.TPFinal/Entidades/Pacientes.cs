using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pacientes<T> where T : Persona
    {
        private List<T> listadoDePacientes;

        public Pacientes()
        {
            this.listadoDePacientes = new List<T>();
        }

        public List<T> Listado { get => this.listadoDePacientes; set => this.listadoDePacientes = value; }

        public static Pacientes<T> operator +(Pacientes<T> pacientes, T persona)
        {
            pacientes.listadoDePacientes.Add(persona);
            return pacientes;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Listado de pacientes ");
            sb.AppendLine();

            foreach (T item in this.listadoDePacientes)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
