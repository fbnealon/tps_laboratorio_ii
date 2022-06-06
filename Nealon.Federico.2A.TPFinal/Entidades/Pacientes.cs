using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Xml;
using System.Xml.Serialization;
using Archivos;

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
            if (pacientes != persona)
            {
                pacientes.listadoDePacientes.Add(persona);
            }
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

        public static bool GuardarXml(string rutaArchivo, string nombreDeArchivo, Pacientes<T> pacientes)
        {
            bool rta = false;
            SerializacionXml<Pacientes<T>> archivo = new SerializacionXml<Pacientes<T>>();
            rta = archivo.Guardar(rutaArchivo, nombreDeArchivo, pacientes);

            return rta;
        }

        public static bool LeerXml(string rutaArchivo, string nombreDeArchivo, out Pacientes<T> pacientes)
        {
            bool rta = false;
            SerializacionXml<Pacientes<T>> archivo = new SerializacionXml<Pacientes<T>>();
            rta = archivo.Leer(rutaArchivo, nombreDeArchivo, out pacientes);
            return rta;
        }

        public static bool GuardarTexto(string rutaArchivo, string nombreDeArchivo, Pacientes<T> pacientes)
        {
            bool rta = false;
            Texto<Pacientes<T>> archivo = new Texto<Pacientes<T>>();
            rta = archivo.Guardar(rutaArchivo, nombreDeArchivo, pacientes);

            return rta;
        }

        public static string LeerTexto(string rutaArchivo, string nombreDeArchivo)
        {
            Texto<Pacientes<T>> archivo = new Texto<Pacientes<T>>();
            return archivo.Leer(rutaArchivo, nombreDeArchivo);
        }

        public static bool operator ==(Pacientes<T> pacientes, T persona)
        {
            bool rta = false;
            foreach (T item in pacientes.listadoDePacientes)
            {
                if (item.Equals(persona))
                {
                    rta = true;
                    break;
                }
            }
            return rta;
        }

        public static bool operator !=(Pacientes<T> pacientes, T persona)
        {
            return !(pacientes == persona);
        }


    }
}
