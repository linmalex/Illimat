using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Illimat.Models;


namespace Illimat.DAL
{
    public class IllimatContext: DbContext
    {
        public IllimatContext() : base("IllimatContext") { }

        public DbSet<Game> Games { get; set; }
        public DbSet<Player> MyProperty { get; set; }
    }
}