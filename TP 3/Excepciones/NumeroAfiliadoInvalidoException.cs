using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NumeroAfiliadoInvalidoException : Exception
    {
        public NumeroAfiliadoInvalidoException(string mensaje) : base(mensaje)
        {

        }
    }
}
