using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheCause.Models;

namespace TheCause.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Petition> Petitions { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Sign> Signs { get; set; }
    }
}
