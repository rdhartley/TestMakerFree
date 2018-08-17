using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SteffanIndustries.Models;
using SteffanIndustries.Models.ViewModels;

namespace SteffanIndustries
{
    public class SteffanContext : DbContext
    {
        public SteffanContext(DbContextOptions<SteffanContext> options) : base(options)
        {
        }
        public virtual DbSet<Estimate> Estimate { get; set; }
        public virtual DbSet<EstimateDetail> EstimateDetail { get; set; }
        public virtual DbSet<Quote> Quote { get; set; }
        public virtual DbSet<QuoteNote> QuoteNote { get; set; }
       
    }
}