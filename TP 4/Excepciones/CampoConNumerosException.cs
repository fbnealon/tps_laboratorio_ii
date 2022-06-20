using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CampoConNumerosException : Exception
    {
        public CampoConNumerosException(string mensaje) : base(mensaje)
        {

        }
    }
}
