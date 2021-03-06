﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using hirelonghorn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hirelonghorn.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<Application> Applications { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<MajorPosition> MajorPositions { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
