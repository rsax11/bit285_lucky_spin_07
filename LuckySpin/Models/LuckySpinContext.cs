﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace LuckySpin.Models
{
    
    
        public class LuckySpinContext : DbContext
        {
            //Constructor
            public LuckySpinContext(DbContextOptions<LuckySpinContext>
           options) : base(options)
            {
                Database.EnsureCreated();
            }
            // Entity Properties
            public DbSet<Player> Players { get; set; }
            public DbSet<Spin> Spins { get; set; }
        }
    }

