using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BondGarfoApp.Models;

    public class BondGarfoAppContext : DbContext
    {
        public BondGarfoAppContext (DbContextOptions<BondGarfoAppContext> options)
            : base(options)
        {
        }

        public DbSet<BondGarfoApp.Models.Prato> Prato { get; set; }

        public DbSet<BondGarfoApp.Models.Categoria> Categoria { get; set; }

        public DbSet<BondGarfoApp.Models.Bebidas> Bebidas { get; set; }
    }
