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
    /// <summary>
    /// Clase Pacientes. Implementación de Tipos genéricos. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Pacientes<T> where T : Persona
    {
        private List<T> listadoDePacientes;

        public Pacientes()
        {
            this.listadoDePacientes = new List<T>();
        }

        public List<T> Listado { get => this.listadoDePacientes; set => this.listadoDePacientes = value; }

        /// <summary>
        /// Agrega la persona a la lista de pacientes si no se encuentra en la lista ya.
        /// </summary>
        /// <param name="pacientes"></param>
        /// <param name="persona"></param>
        /// <returns></returns>
        public static Pacientes<T> operator +(Pacientes<T> pacientes, T persona)
        {
            if (pacientes != persona)
            {
                pacientes.listadoDePacientes.Add(persona);
            }
            return pacientes;
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

        /// <summary>
        /// Guarda en un archivo xml con ruta y nombre pasado por parametro, la lista de pacientes pasada por parametro.
        /// </summary>
        /// <param name="rutaArchivo"></param>
        /// <param name="nombreDeArchivo"></param>
        /// <param name="pacientes"></param>
        /// <returns></returns>
        public static bool GuardarXml(string rutaArchivo, string nombreDeArchivo, Pacientes<T> pacientes)
        {
            bool rta = false;
            SerializacionXml<Pacientes<T>> archivo = new SerializacionXml<Pacientes<T>>();
            rta = archivo.Guardar(rutaArchivo, nombreDeArchivo, pacientes);

            return rta;
        }

        /// <summary>
        /// Lee un archivo xml pasado por parámetro y recupera la lista de pacientes del archivo.
        /// </summary>
        /// <param name="rutaArchivo"></param>
        /// <param name="nombreDeArchivo"></param>
        /// <param name="pacientes"></param>
        /// <returns></returns>
        public static bool LeerXml(string rutaArchivo, string nombreDeArchivo, out Pacientes<T> pacientes)
        {
            bool rta = false;
            SerializacionXml<Pacientes<T>> archivo = new SerializacionXml<Pacientes<T>>();
            rta = archivo.Leer(rutaArchivo, nombreDeArchivo, out pacientes);
            return rta;
        }

        /// <summary>
        /// Guarda en un archivo de texto pasado por parametro la lista de pacientes.
        /// </summary>
        /// <param name="rutaArchivo"></param>
        /// <param name="nombreDeArchivo"></param>
        /// <param name="pacientes"></param>
        /// <returns></returns>
        public static bool GuardarTexto(string rutaArchivo, string nombreDeArchivo, Pacientes<T> pacientes)
        {
            bool rta = false;
            Texto<Pacientes<T>> archivo = new Texto<Pacientes<T>>();
            rta = archivo.Guardar(rutaArchivo, nombreDeArchivo, pacientes);

            return rta;
        }

        /// <summary>
        /// Lee un archivo de texto pasado por parametro y retorna un string con el contenido del archivo.
        /// </summary>
        /// <param name="rutaArchivo"></param>
        /// <param name="nombreDeArchivo"></param>
        /// <returns></returns>
        public static string LeerTexto(string rutaArchivo, string nombreDeArchivo)
        {
            Texto<Pacientes<T>> archivo = new Texto<Pacientes<T>>();
            return archivo.Leer(rutaArchivo, nombreDeArchivo);
        }



    }
}
