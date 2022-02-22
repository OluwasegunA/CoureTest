using System;
using Microsoft.EntityFrameworkCore;
using Question2.Models;

namespace Question2.DataContext
{
    public partial class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CountryDetails> CountryDetails { get; set; }
    }
}