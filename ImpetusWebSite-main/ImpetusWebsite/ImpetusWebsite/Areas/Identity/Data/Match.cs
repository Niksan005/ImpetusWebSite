using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpetusWebsite.Areas.Identity.Data
{
    public class Match
    {
        public string Id { get; set; }
        public ICollection<UserMatchRelation> Players { get; set; }
    }
}
