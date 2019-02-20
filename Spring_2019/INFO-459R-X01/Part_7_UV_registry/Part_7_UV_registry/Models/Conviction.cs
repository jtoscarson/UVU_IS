using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part_7_UV_registry.Models
{
    public class Conviction
    {
        public int ConvictionId { get; set; }
        public int InmateId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime ConvictionDate { get; set; }
        public Inmate Inmate { get; set; }
    }
}