using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ENTITY;
namespace DAL
{
    public class RepositorioDpto:BaseRepository<Departamento>
    {
        
        

        public RepositorioDpto(string fileName) : base(fileName)
        {
        }

        public override List<Departamento> Read()
        {
            try
            {
                string line;
                List<Departamento> personList = new List<Departamento>();
                //1. abrrir
                StreamReader reader = new StreamReader(fileName);
                //2 operaciones
               while (!reader.EndOfStream) 
               {
                    line= reader.ReadLine();
                    personList.Add(Map(line));
               } 
                //3 cerrar
                reader.Close();
                return personList;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        private Departamento Map(string line)
        {
            Departamento dpto = new Departamento();
            var vector= line.Split(';');
            dpto.CodigoDpto = vector[0];
            dpto.NombreDpto = vector[1];
            
            return dpto;
        }
    }
}
