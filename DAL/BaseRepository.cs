using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class BaseRepository<T> 
    {
        protected string fileName = string.Empty;
        protected BaseRepository(string fileName)
        {
            this.fileName = fileName;
        }

        public string Save(T entidad)
        {
            try
            {
                //1. abrrir
                StreamWriter writer = new StreamWriter(fileName, true);
                //2 operaciones
                writer.WriteLine(entidad.ToString());
                //3 cerrar
                writer.Close();
                return $"se guardo la entidad";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public abstract List<T> Read();
    }
}
