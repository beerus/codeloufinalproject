using System;
using System.Collections.Generic;
using System.Text;
using LetsTryAgain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LetsTryAgain.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
