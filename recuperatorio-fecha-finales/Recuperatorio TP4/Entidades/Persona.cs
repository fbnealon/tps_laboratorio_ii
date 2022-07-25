using System;
using System.Text;

namespace Entidades
{
    [System.Xml.Serialization.XmlInclude(typeof(Afiliado))]
    [System.Xml.Serialization.XmlInclude(typeof(NoAfiliado))]
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private int edad;
        private EEspecialidades especialidad;

        public Persona(int id, string nombre, string apellido, int edad, EEspecialidades especialidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.especialidad = especialidad;
        }

        public Persona(int id, string nombre, string apellido, int edad, string especialidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.especialidad = (EEspecialidades)Enum.Parse(typeof(EEspecialidades), especialidad);
        }

        public Persona()
        {

        }

        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Apellido { get => this.apellido; set => this.apellido = value; }
        public int Edad { get => this.edad; set => this.edad = value; }
        public EEspecialidades Especialidad { get => this.especialidad; set => this.especialidad = value; }

        public string EspecialidadString { get => this.especialidad.ToString(); }

        public static bool operator ==(Persona p1, Persona p2)
        {
            bool rta = false;
            if (p1 is not null && p2 is not null)
            {
                if (p1.Id == p2.Id)
                {
                    rta = true;
                }
            }
            return rta;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            return obj is Persona persona && this == persona;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this.id} ");
            sb.AppendLine($"Nombre: {this.nombre} ");
            sb.AppendLine($"Apellido: {this.apellido} ");
            sb.AppendLine($"Edad: {this.edad} ");
            sb.AppendLine($"Especialidad: {this.especialidad} ");

            return sb.ToString();
        }
    }
}
