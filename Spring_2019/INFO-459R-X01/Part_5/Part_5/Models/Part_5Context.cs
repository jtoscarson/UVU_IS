using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Part_5.Models
{
    public class Part_5Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Part_5Context() : base("name=Part_5Context")
        {
        }

        public DbSet<Part_5.Models.Trainee> Trainees { get; set; }

        public DbSet<Part_5.Models.FitnessStyle> FitnessStyles { get; set; }

        public DbSet<Part_5.Models.HealthCoaches> HealthCoaches { get; set; }
    }
}
