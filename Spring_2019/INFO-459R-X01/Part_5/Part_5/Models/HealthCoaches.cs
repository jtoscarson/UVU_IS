using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part_5.Models
{
    public class HealthCoaches
    {
        public virtual int HealthCoachesId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

    }
}