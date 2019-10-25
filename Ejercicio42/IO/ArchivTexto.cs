using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace IO
{
    public static class ArchivTexto
    {
        public static void Guardar(string path,string texto)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(texto);
            }
        }
        public static string Leer(string path)
        {
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                return streamReader.ReadToEnd();
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

    }
}
