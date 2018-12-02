﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using porty.Models;

namespace porty.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PortfolioItem> Items {get; set;}
        
        protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
                // Customize the ASP.NET Identity model and override the defaults if needed.
                // For example, you can rename the ASP.NET Identity table names and more.
                // Add your customizations after calling base.OnModelCreating(builder);
            }
    }

}
