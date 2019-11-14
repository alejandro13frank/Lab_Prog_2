using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializarXML<T> : IArchivo<T> 
    {
        public T Leer(string rutaArchivo)
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(rutaArchivo);
                XmlSerializer serializar = new XmlSerializer(typeof(T));
                T dato = (T)serializar.Deserialize(reader);
                reader.Close();
                return dato;
            }
            catch (Exception)
            {
                throw new ErrorArchivoException("Error al leer archivo");
            }

        }
        public bool Guardar(string rutaArchivo, T objeto)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(rutaArchivo, null);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, objeto);
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                throw new ErrorArchivoException("Error al guardar el archivo");
            }
        }
    }
}
