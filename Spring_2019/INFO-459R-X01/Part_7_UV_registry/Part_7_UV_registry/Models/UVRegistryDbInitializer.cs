using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Part_7_UV_registry.Models
{
    public class UVRegistryDbInitializer : DropCreateDatabaseAlways<Part_7_UV_registryDb>
    {
        protected override void Seed(Part_7_UV_registryDb context)
        {
            context.Inmates.Add(new Inmate
            {
                FirstName = "Tyler",
                LastName = "Oscarson",
                Convictions = new List<Conviction>
                { new Conviction {
                    Type = "Robbery",
                    Description = "Stole a lollypop",
                    ConvictionDate = new DateTime(2017, 09, 27)}
                ,
                new Conviction
                {
                   Type = "Liotering",
                   Description = "Being a nuisances",
                   ConvictionDate = new DateTime(2019, 02, 12)}
                }
            });

            context.Inmates.Add(new Inmate
            {
                FirstName = "Sami",
                LastName = "Oscarson",
                Convictions = new List<Conviction>
                { new Conviction {
                    Type = "Grand Larceny",
                    Description = "Stole 100,000,000 lollipops",
                    ConvictionDate = new DateTime(2017, 09, 27)}
                ,
                new Conviction
                {
                   Type = "Liotering",
                   Description = "Being a nuisances",
                   ConvictionDate = new DateTime(2019, 02, 12)}
                }
            });

            context.Inmates.Add(new Inmate
            {
                FirstName = "Gemma",
                LastName = "Oscarson",
                Convictions = new List<Conviction>
                { new Conviction {
                    Type = "Murder",
                    Description = "Being too cute",
                    ConvictionDate = new DateTime(2017, 09, 27)}
                ,
                new Conviction
                {
                   Type = "Liotering",
                   Description = "Being a nuisances",
                   ConvictionDate = new DateTime(2019, 02, 12)}
                }
            });

            base.Seed(context);
        }
    }
}