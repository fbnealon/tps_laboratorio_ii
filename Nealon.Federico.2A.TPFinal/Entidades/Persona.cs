using System;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private int edad;
        private EEspecialidades especialidad;

        public Persona(int id, string nombre, string apellido, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            //this.especialidad = EEspecialidades.A_Derivar;
        }

        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Apellido { get => this.apellido; set => this.apellido = value; }
        public int Edad { get => this.edad; set => this.edad = value; }
        //public EEspecialidades Especialidad { get => this.especialidad; set => this.especialidad = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Edad: {this.edad}");

            return sb.ToString();
        }
    }
}
