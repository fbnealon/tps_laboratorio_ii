﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CampoVacioException : Exception
    {
        public CampoVacioException(string mensaje) : base(mensaje)
        {

        }
    }
}
