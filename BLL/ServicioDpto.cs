using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioDpto : IOperacion<Departamento>
    {
        RepositorioDpto repositorioDpto;
        List<Departamento> departamentos;
        public ServicioDpto()
        {
            repositorioDpto = new RepositorioDpto(Config.FILEDPTO);
            departamentos = repositorioDpto.Read();
        }
        public string Actualizar(Departamento obj)
        {
            throw new NotImplementedException();
        }

        public string Agregar(Departamento obj)
        {
           return  repositorioDpto.Save(obj);
        }

        public Departamento BuscarPorCodigo(string codigo)
        {
           var dpto= departamentos.FirstOrDefault<Departamento>(x=>x.CodigoDpto==codigo);
            return dpto;    
        }

        public List<Departamento> Consultar()
        {
            return repositorioDpto.Read();
        }

        public string Eliminar(Departamento obj)
        {
            throw new NotImplementedException();
        }
    }
}
