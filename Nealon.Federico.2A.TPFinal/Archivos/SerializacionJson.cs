using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    public class SerializacionJson<T> : IArchivo<T>
    {
        public bool Guardar(string rutaDeArchivo, string nombreDeArchivo, T datos)
        {
            bool rta = false;
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(rutaDeArchivo + nombreDeArchivo))
                {
                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    opciones.WriteIndented = true;
                    

                    string jsonString = JsonSerializer.Serialize(datos, datos.GetType(), opciones);
                    streamWriter.Write(jsonString);
                    rta = true;
                }
            }
            catch (Exception ex)
            {

                throw new ArchivosException("No se pudo guardar el archivo\n", ex);
            }
            return rta;
        }

        public bool Leer(string rutaDeArchivo, string nombreDeArchivo, out T datos)
        {
            bool rta = false;
            try
            {
                using (StreamReader streamReader = new StreamReader(rutaDeArchivo + nombreDeArchivo))
                {
                    
                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    opciones.WriteIndented = true;
                    datos = JsonSerializer.Deserialize<T>(streamReader.ReadToEnd(), opciones);
                    rta = true;
                }
            }
            catch (Exception ex)
            {

                throw new ArchivosException("No se pudo leer el archivo\n", ex);
            }
            return rta;
        }
    }
}
