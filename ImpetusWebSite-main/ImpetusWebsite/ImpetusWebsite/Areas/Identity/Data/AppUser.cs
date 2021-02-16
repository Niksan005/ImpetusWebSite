using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ImpetusWebsite.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AppUser class
    public class AppUser : IdentityUser
    {
        public int LeaderboardSpot { get; set; }
        public int Ponts { get; set; }
        public ICollection<UserMatchRelation> MatchHistory { get; set; }
    }
}
