using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FavoriteCars.Models;

namespace FavoriteCars.Data
{
    public class FavoriteCarsContext : DbContext
    {
        public FavoriteCarsContext (DbContextOptions<FavoriteCarsContext> options)
            : base(options)
        {
        }

        public DbSet<FavoriteCars.Models.Car> Car { get; set; }
    }
}
