using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TvShowsMVC.Models;

namespace TvShowsMVC.Data
{
    public class TvShowsMVCContext : DbContext
    {
        public TvShowsMVCContext (DbContextOptions<TvShowsMVCContext> options)
            : base(options)
        {
        }

        public DbSet<TvShow> TvShow { get; set; } = default!;
    }
}
