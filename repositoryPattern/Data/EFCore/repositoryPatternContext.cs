using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using repositoryPattern.Models;

namespace repositoryPattern.Data.EFCore
{
    public class repositoryPatternContext : DbContext
    {
        public repositoryPatternContext(DbContextOptions<repositoryPatternContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
