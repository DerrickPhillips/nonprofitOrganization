using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using nonprofitOrganization.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace nonprofitOrganization.Data
{
    public class NonProfitContext : IdentityDbContext<User>
    {
        public NonProfitContext(DbContextOptions<NonProfitContext> options) : base(options)
        { }

        public DbSet<Event> Events { get; set; }

        public DbSet<Donor> Donors { get; set; }

        public DbSet<Donation> Donations { get; set; }

        public DbSet<DonationType> DonationTypes { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<News> News { get; set; }

        public DbSet<User> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasIndex(u => u.MemberID)
                .IsUnique();


            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },

                new IdentityRole
                {
                    Id = "2",
                    Name = "Member",
                    NormalizedName = "MEMBER"
                },

                new IdentityRole
                {
                    Id = "3",
                    Name = "Donor",
                    NormalizedName = "DONOR"
                },

                new IdentityRole
                {
                    Id = "4",
                    Name = "Staff",
                    NormalizedName = "STAFF"
                }
                );

            modelBuilder.Entity<DonationType>().HasData(
                new DonationType
                {
                    TypeID = 1,
                    Type = "Anonymous",
                    Description = "Help out CodeSign anonymously!"
                },

                new DonationType
                {
                    TypeID = 2,
                    Type = "Accredited",
                    Description = "Be recognized for helping out CodeSign!"
                }
                );

            modelBuilder.Entity<Donor>().HasData(
                new Donor
                {
                    DonorID = 1,
                    Address = "250 Derrick Ln",
                    Phone = "864-547-7310",
                    Email = "derrickrphillips@yahoo.com",
                    ContactPreference = "Email"
                },
                new Donor
                {
                    DonorID = 2,
                    Address = "107 Landcaster St",
                    Phone = "864-243-5402",
                    Email = "nanny@yahoo.com",
                    ContactPreference = "Phone"
                }
                );

            // Code to setup Mr.Sanders admin user account DP.
            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>(
                entity =>
                {
                    entity.HasKey(e => e.Id);
                    entity.HasAlternateKey(e => e.MemberID);

                    entity.Property(e => e.MemberID)
                        .ValueGeneratedOnAdd();

                    entity.HasData(
                    new User
                    {
                        Id = "1",
                        MemberID = 1,
                        UserName = "admin@cpt275.beausanders.org",
                        NormalizedUserName = "ADMIN@CPT275.BEAUSANDERS.ORG",
                        Email = "simmonsb218569@my.gvltec.edu",
                        PasswordHash = hasher.HashPassword(null, "teamProjeck275"),
                        NormalizedEmail = "SIMMONSB218569@MY.GVLTEC.EDU",
                        EmailConfirmed = true
                    }
                    );
                });


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "1"
                }
                );

            base.OnModelCreating(modelBuilder);

        }

        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            UserManager<User> userManager =
                serviceProvider.GetRequiredService<UserManager<User>>();
            RoleManager<IdentityRole> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = "admin";
            string password = "Password";
            string roleName = "Admin";

            // if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            // if username doesn't exist, create it and add to role
            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new User { UserName = username };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }
    }
}
