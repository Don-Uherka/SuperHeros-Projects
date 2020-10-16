using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperHeros_project.Models;

namespace SuperHeros_project.Data
{
    //represents database inside app
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<SuperHero> superHeroes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
