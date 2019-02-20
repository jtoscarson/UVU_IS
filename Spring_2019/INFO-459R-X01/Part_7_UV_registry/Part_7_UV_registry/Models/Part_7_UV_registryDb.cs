using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Part_7_UV_registry.Models
{
    public class Part_7_UV_registryDb : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Part_7_UV_registryDb() : base("name=Part_7_UV_registryDb")
        {
        }

        public System.Data.Entity.DbSet<Part_7_UV_registry.Models.Inmate> Inmates { get; set; }

        public System.Data.Entity.DbSet<Part_7_UV_registry.Models.Conviction> Convictions { get; set; }
    }
}
