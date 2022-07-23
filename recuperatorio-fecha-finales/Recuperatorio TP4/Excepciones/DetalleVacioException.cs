using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DetalleVacioException : Exception
    {
        public DetalleVacioException(string mensaje) : base(mensaje)
        {

        }
    }
}
