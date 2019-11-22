using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace Archivos
{
    public class Xml<T> : IFiles<T>
    {
        public string GetDirectoryPath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\";
            }
        }
        public bool FileExists(string nombreArchivo)
        {
            /*XmlTextWriter writer = new XmlTextWriter(GetDirectoryPath + nombreArchivo,Encoding.UTF8);
            if (writer!=null)
            {
                writer.Close();
                return true;
            }
            return false;*/
            return false;
        }
        public void Guardar(string nombreArchivo, T objeto)
        {
            Guardar(nombreArchivo, objeto, Encoding.UTF8);
        }
        public void Guardar(string nombreArchivo, T objeto, Encoding encoding)
        {
            XmlTextWriter writer;
            try
            {
                /*if (!Regex.IsMatch(nombreArchivo, "^[a-zA-Z]+$+.xml"))
                {
                    throw new ErrorArchivoException();
                }*/
                
                
                    writer = new XmlTextWriter(GetDirectoryPath + nombreArchivo,encoding);
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, objeto);
                    writer.Close();
                
            }
            catch (Exception)
            {
                throw new ErrorArchivoException("Error al guardar el archivo");
            }
            /*finally
            {
                if (writer!=null)
                writer.Close();
            }*/
        }
        public bool Leer(string nombreArchivo, out T objeto)
        {
            return Leer(nombreArchivo, out objeto, Encoding.UTF8);
        
        }
        public bool Leer(string nombreArchivo, out T objeto, Encoding encoding)
        {
            try
            {
                if (FileExists(nombreArchivo))
                {
                    XmlTextReader reader = new XmlTextReader(GetDirectoryPath + nombreArchivo);
                    XmlSerializer serializar = new XmlSerializer(typeof(T));
                    T dato = (T)serializar.Deserialize(reader,encoding.ToString());
                    reader.Close();
                    objeto = dato;
                    return true;
                }
                objeto = (T)(new object());
                return false;

            }
            catch (Exception)
            {
                throw new ErrorArchivoException("Error al leer archivo");
            }
            
        }
    }
}
