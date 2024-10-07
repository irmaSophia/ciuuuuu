using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Municipio
    {
        public string CodigoMunicipio { get; set; }
        public string NombreMunicipio { get; set; }
        public Departamento Departamento { get; set; }
        public bool EsCapital { get; set; }

        public Municipio() { }

        public Municipio(string codigoMunicipio, string nombreMunicipio, Departamento departamento, bool esCapital)
        {
            CodigoMunicipio = codigoMunicipio;
            NombreMunicipio = nombreMunicipio;
            Departamento = departamento;
            EsCapital = esCapital;  
        }
        public override string ToString()
        {
            return $"{CodigoMunicipio};{NombreMunicipio};{Departamento.CodigoDpto};{EsCapital}";
        }

    }
}
