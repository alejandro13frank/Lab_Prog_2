using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class ErrorArchivoException : Exception
    {
        public ErrorArchivoException() : base()
        {

        }
        public ErrorArchivoException(string message) : base(message)
        {

        }
        public ErrorArchivoException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
