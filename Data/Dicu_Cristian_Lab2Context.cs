using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dicu_Cristian_Lab2.Models;

namespace Dicu_Cristian_Lab2.Data
{
    public class Dicu_Cristian_Lab2Context : DbContext
    {
        public Dicu_Cristian_Lab2Context (DbContextOptions<Dicu_Cristian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dicu_Cristian_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Dicu_Cristian_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
