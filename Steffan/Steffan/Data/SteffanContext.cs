using Microsoft.EntityFrameworkCore;
using SteffanIndustries.Models;

namespace Steffan.Data
{
    public class SteffanContext : DbContext
    {
        public SteffanContext(DbContextOptions<SteffanContext> options) : base(options)
        {

        }
        public DbSet<Estimate> Estimates { get; set; }
        public DbSet<EstimateDetail> EstimateDetails { get; set; }

    }
}
