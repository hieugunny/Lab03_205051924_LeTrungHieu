using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab03_Movie.Models;
using Microsoft.Extensions.Logging;

namespace Lab03_Movie.Data
{
    public class Lab03_MovieContext : DbContext
    {
        public Lab03_MovieContext (DbContextOptions<Lab03_MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Lab03_Movie.Models.Movie> Movie { get; set; } = default!;
         
    }
}
