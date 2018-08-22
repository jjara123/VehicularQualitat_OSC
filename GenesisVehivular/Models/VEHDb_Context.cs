using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GenesisVehivular.Models
{
    public class VEHDb_Context : DbContext
    {
        public VEHDb_Context() : base("ConGenesis")
        {

        }

        #region

        public DbSet<t_foto> t_fotos { get; set; }

        #endregion



    }
}