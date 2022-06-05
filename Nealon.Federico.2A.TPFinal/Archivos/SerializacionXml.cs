using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;


namespace Archivos
{
    public class SerializacionXml<T> : IArchivo<T>
    {
        public bool Guardar(string rutaDeArchivo, string nombreDeArchivo, T datos)
        {
            bool rta = false;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(rutaDeArchivo+nombreDeArchivo, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, datos);
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
                using (XmlTextReader reader = new XmlTextReader(rutaDeArchivo+nombreDeArchivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    datos = (T)ser.Deserialize(reader);
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
