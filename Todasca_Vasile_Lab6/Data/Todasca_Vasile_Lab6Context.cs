using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todasca_Vasile_Lab6.Models;

namespace Todasca_Vasile_Lab6.Data
{
    public class Todasca_Vasile_Lab6Context : DbContext
    {
        public Todasca_Vasile_Lab6Context (DbContextOptions<Todasca_Vasile_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Todasca_Vasile_Lab6.Models.Car> Car { get; set; }
    }
}
