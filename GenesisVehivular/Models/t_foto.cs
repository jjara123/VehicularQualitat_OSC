using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GenesisVehivular.Models
{
    public class t_foto
    {
        [Key, Display(Name = "Código de Imagen")]
        public int idimagen { get; set; }

        [Display(Name = "Código de Inspección")]
        public int codinspeccion { get; set; }

        [Display(Name = "Hora")]
        public Nullable<System.DateTime> hora { get; set; }

        [Display(Name = "Descripción")]
        public string descripcion { get; set; }

        [Display(Name = "Imagen de Inspección"), DataType(DataType.Upload)]
        public byte[] imagen { get; set; }
    }
}