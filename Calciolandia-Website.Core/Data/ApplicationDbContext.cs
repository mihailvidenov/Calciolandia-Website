using Calciolandia_Website.Core.Data.Configuration;
using Calciolandia_Website.Core.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Calciolandia_Website.Core.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FootballClub> FootballClubs { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<President> Presidents { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           
            base.OnModelCreating(builder);

            

            builder.Entity<FootballClub>(f =>
            {
                f.HasMany(f => f.Managers).WithOne(f => f.FootballClub);
                f.HasMany(f => f.Presidents).WithOne(f => f.FootballClub);
                f.HasMany(f => f.Players).WithOne(f => f.FootballClub);
                f.HasMany(f => f.Fixtures).WithOne(f => f.HomeTeam);
                f.HasMany(f => f.Fixtures).WithOne(f => f.AwayTeam);
                f.Property(f => f.IsDeleted).HasDefaultValue(false);
            });

            builder.Entity<League>(l =>
            {
                l.HasMany(l => l.FootballClubs).WithOne(l => l.League);
                l.HasMany(l => l.Fixtures).WithOne(l => l.League);
                l.Property(l => l.IsDeleted).HasDefaultValue(false);
            });

            builder.Entity<Manager>(m =>
            {
             
                m.Property(m => m.IsDeleted).HasDefaultValue(false);
            });

            builder.Entity<President>(o =>
            {
               
                o.Property(o => o.IsDeleted).HasDefaultValue(false);
            });

            builder.Entity<Player>(p =>
            {
                p.Property(p => p.IsDeleted).HasDefaultValue(false);
            });

            builder.Entity<Stadium>(s =>
            {
                s.HasMany(s => s.FootballClubs).WithOne(s => s.Stadium);
                s.HasMany(s => s.Fixtures).WithOne(s => s.Stadium);
                s.Property(s => s.IsDeleted).HasDefaultValue(false);
            });

            builder.Entity<Fixture>(s =>
            {
               
                s.Property(s => s.IsDeleted).HasDefaultValue(false);
            });




            //builder.Entity<IdentityUserRole<string>>(entity =>
            //{
            //    entity.ToTable(name: "AspNetUserRoles");
            //    entity.HasKey(r => new { r.RoleId, r.UserId });
            //});



            builder.ApplyConfiguration(new LeagueConfiguration());
            builder.ApplyConfiguration(new StadiumConfiguration());
            builder.ApplyConfiguration(new FootballClubConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new ManagerConfiguration());
            builder.ApplyConfiguration(new PlayerConfiguration());
            builder.ApplyConfiguration(new PresidentConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());

        }
    }
}