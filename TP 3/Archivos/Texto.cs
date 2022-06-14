using Archivos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Texto<T> : IArchivo<T>
    {

        /// <summary>
        /// Retorna true si se pudo escribir el archivo correctamente.
        /// </summary>
        /// <param name="rutaDeArchivo"></param>
        /// <param name="nombreDeArchivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string rutaDeArchivo, string nombreDeArchivo, T datos)
        {
            bool rta = false;
            Encoding codificacion = Encoding.UTF8;
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(rutaDeArchivo+nombreDeArchivo, false, codificacion))
                {
                    streamWriter.WriteLine(datos);
                    rta = true;
                }
            }
            catch (Exception ex)
            {
                throw new ArchivosException($"Error con el archivo ubicado en {rutaDeArchivo}", ex.InnerException);
            }

            return rta;
        }

        /// <summary>
        /// Método necesario para implementar la interfaz.
        /// </summary>
        /// <param name="rutaDeArchivo"></param>
        /// <param name="nombreDeArchivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string rutaDeArchivo, string nombreDeArchivo, out T datos)
        {
            datos = default(T);
            return false;
        }

        /// <summary>
        /// Retorna el texto del archivo pasado por parámetro, o una excepción en caso de haber un error.
        /// </summary>
        /// <param name="rutaDeArchivo"></param>
        /// <param name="nombreDeArchivo"></param>
        /// <returns></returns>
        public string Leer(string rutaDeArchivo, string nombreDeArchivo)
        {
            string texto = string.Empty;
            Encoding codificacion = Encoding.UTF8;
            try
            {
                using (StreamReader streamReader = new StreamReader(rutaDeArchivo + nombreDeArchivo, codificacion))
                {
                    texto = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw new ArchivosException($"Error con el archivo ubicado en {rutaDeArchivo}", ex.InnerException);
            }
            return texto;
        }
    }
}