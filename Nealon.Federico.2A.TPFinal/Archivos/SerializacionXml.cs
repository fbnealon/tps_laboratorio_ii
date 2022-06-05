﻿using System;
using System.Collections.Generic;
using System.IO;
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
                using (StreamWriter streamWriter = new StreamWriter(rutaDeArchivo + nombreDeArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, datos);
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
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    datos = (T)xmlSerializer.Deserialize(streamReader);
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