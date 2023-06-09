﻿using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opttion) :base (opttion)
        {
            
        }


        public DbSet<Features> Features { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Projects> Projects { get; set; }

        public DbSet<Slider> Sliders { get; set; }


    }
}
