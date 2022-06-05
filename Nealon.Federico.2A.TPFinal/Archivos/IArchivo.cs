using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivo<T>
    {
        bool Guardar(string rutaDeArchivo, string nombreDeArchivo, T datos);

        bool Leer(string rutaDeArchivo, string nombreDeArchivo, out T datos);

    }
}
