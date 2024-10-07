using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal interface IOperacion<T>
    {
        string Agregar(T obj);
        string Eliminar(T obj);
        string Actualizar(T obj);
        T BuscarPorCodigo(string codigo);
        List<T> Consultar();
    }
}
