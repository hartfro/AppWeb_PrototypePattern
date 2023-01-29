﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AntonellaCortes_EjercicioCF1.Models;

namespace AntonellaCortes_EjercicioCF1.Data
{
    public class AntonellaCortes_EjercicioCF1Context : DbContext
    {
        public AntonellaCortes_EjercicioCF1Context (DbContextOptions<AntonellaCortes_EjercicioCF1Context> options)
            : base(options)
        {
        }

        public DbSet<AntonellaCortes_EjercicioCF1.Models.Burger> Burger { get; set; } = default!;
    }
}
