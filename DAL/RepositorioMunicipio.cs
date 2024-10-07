using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositorioMunicipio : BaseRepository<Municipio>
    {
        RepositorioDpto repositorioDpto;
        public RepositorioMunicipio(string fileName) : base(fileName)
        {
            repositorioDpto = new RepositorioDpto(Config.FILEDPTO);
        }

        public override List<Municipio> Read()
        {
            try
            {
                string line;
                List<Municipio> lista = new List<Municipio>();
                //1. abrrir
                StreamReader reader = new StreamReader(fileName);
                //2 operaciones
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    lista.Add(Map(line));
                }
                //3 cerrar
                reader.Close();
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private Municipio Map(string line)
        {
            Municipio municipio = new Municipio();

            municipio.CodigoMunicipio= line.Split(';')[0];
            municipio.NombreMunicipio= line.Split(';')[1];
            municipio.Departamento = ObtenerDptoPorCodigo(line.Split(';')[2]);
            municipio.EsCapital = bool.Parse(line.Split(';')[3]);
            return municipio;
        }

        private Departamento ObtenerDptoPorCodigo(string codigo)
        {
          return  repositorioDpto.Read().FirstOrDefault<Departamento>(x => x.CodigoDpto.Equals(codigo));
        }
    }
}
