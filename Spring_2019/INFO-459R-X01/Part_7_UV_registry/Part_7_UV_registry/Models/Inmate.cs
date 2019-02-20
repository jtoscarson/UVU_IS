using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part_7_UV_registry.Models
{
    public class Inmate
    {
        public int InmateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Conviction> Convictions { get; set; }
    }
}