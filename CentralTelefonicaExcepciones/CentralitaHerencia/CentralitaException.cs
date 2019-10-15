using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  class CentralitaException : Exception
  {
    public string clase;
    public string metodo;
    public string  NombreClase
    {
      get
      {
        return this.clase;
      }
    }
    public string NombreMetodo
    {
      get
      {
        return this.metodo;
      }
    }

    public CentralitaException(string mensaje, string clase,string metodo)
        : this(mensaje,clase,metodo,null)
    {
    }

    public CentralitaException(string mensaje, string clase, string metodo, Exception inner)
        : base(mensaje, inner)
    {
      this.clase = clase;
      this.metodo = metodo;
    }
  }
}
