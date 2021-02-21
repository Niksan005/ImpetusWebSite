using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImpetusWebsite.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ImpetusWebsite.Data
{
    public class ImpetusContext : IdentityDbContext<AppUser>
    {
        public ImpetusContext(DbContextOptions<ImpetusContext> options)
            : base(options)
        {
        }
        override
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Match> Matchs { get; set; }
        public DbSet<UserMatchRelation> UserMatchRelations { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserMatchRelation>()
                .HasKey(umr => new { umr.IdUser, umr.IdMatch });
            builder.Entity<UserMatchRelation>()
                .HasOne(bc => bc.ModelUser)
                .WithMany(b => b.MatchHistory)
                .HasForeignKey(bc => bc.IdUser);
            builder.Entity<UserMatchRelation>()
                .HasOne(bc => bc.ModelMatch)
                .WithMany(c => c.Players)
                .HasForeignKey(bc => bc.IdMatch);
        }
    }
}
