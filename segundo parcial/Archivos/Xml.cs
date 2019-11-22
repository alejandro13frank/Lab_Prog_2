using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml <T> : IFiles<T>
    {
        public string GetDirectoryPath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
        }

        public bool FileExists(string nombreArchivo)
        {
            return File.Exists(this.Path(nombreArchivo));
        }

        public void Guardar(string nombreArchivo, T objeto, Encoding encoding)
        {
            XmlTextWriter writer = null;
            XmlSerializer ser;
            try
            {
                writer = new XmlTextWriter(this.Path(nombreArchivo), encoding);
                ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, objeto);
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException(e.Message,e);
            }
            finally
            { 
                if(writer != null)
                {
                    writer.Close();
                }
            }
        }

        public void Guardar(string nombreArchivo, T objeto)
        {
            this.Guardar(nombreArchivo, objeto, Encoding.UTF8);
        }

        public bool Leer(string nombreArchivo, out T objeto, Encoding encoding)
        {
            XmlTextReader reader = null;
            XmlSerializer ser;
            try
            {
                reader = new XmlTextReader(this.Path(nombreArchivo));
                ser = new XmlSerializer(typeof(T));
                objeto = (T)ser.Deserialize(reader);
                return true;
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException(e.Message, e);
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
            }
        }

        public bool Leer(string nombreArchivo, out T objeto)
        {
            return this.Leer(nombreArchivo, out objeto, Encoding.UTF8);
        }

        public string Path(string nombreArchivo)
        {
            string path = this.GetDirectoryPath + "\\" + nombreArchivo + ".xml";
            return path;
        }


    }
}
