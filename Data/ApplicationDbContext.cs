using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserManagement.Models;

namespace UserManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       base.OnModelCreating(modelBuilder);


       //RENAME IDENTITY TABLES NAMES
       modelBuilder.Entity<ApplicationUser>().ToTable("User","Security");
       modelBuilder.Entity<IdentityRole>().ToTable("Roles","Security");
       modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles","Security");
       modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UsersClaims","Security");
       modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaim","Security");
       modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogin","Security");
       modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserToken","Security");
       

    }
    }
}
