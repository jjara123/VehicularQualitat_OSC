using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class DatosPolizaEntity
    {
        public string tipodoc { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string sexo { get; set; }
        public string nacionalidad { get; set; }
        public string ecivil { get; set; }
        public string fecnaci { get; set; }
        public string email { get; set; }
        public string telf { get; set; }
        public string celu { get; set; }

        public int nropoliza { get; set; }
        public string planproducto { get; set; }
        public string vigencia { get; set; }
        public string tipopoliza { get; set; }
        public string formapago { get; set; }

        public string claseveh { get; set; }
        public string marcaveh { get; set; }
        public string modeloveh { get; set; }
        public string anio { get; set; }
        public string color { get; set; }
        public string nromotor { get; set; }
        public string placa { get; set; }

        //ok
    }
}
}
