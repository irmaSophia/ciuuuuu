using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioMunicipio : IOperacion<Municipio>
    {
        RepositorioMunicipio repositorioMunicipio;
        public ServicioMunicipio()
        {
            repositorioMunicipio = new RepositorioMunicipio(Config.FILEMUNICIPIO);
        }
        public string Actualizar(Municipio obj)
        {
            throw new NotImplementedException();
        }

        public string Agregar(Municipio obj)
        {
           return repositorioMunicipio.Save(obj);
        }

        public Municipio BuscarPorCodigo(string codigo)
        {
            return repositorioMunicipio.Read().FirstOrDefault<Municipio>(x=>x.Equals(codigo));  
        }

        public List<Municipio> Consultar()
        {
            return repositorioMunicipio.Read();
        }

        public string Eliminar(Municipio obj)
        {
            throw new NotImplementedException();
        }
    }
}
