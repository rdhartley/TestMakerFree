using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SteffanIndustries;

namespace SteffanIndustries.Migrations
{
    [DbContext(typeof(SteffanContext))]
    partial class SteffanContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SteffanIndustries.Models.Estimate", b =>
                {
                    b.Property<int>("EstimateID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contact");

                    b.Property<string>("ContactPhone");

                    b.Property<DateTime>("EstimateDate");

                    b.Property<int>("EstimateSection");

                    b.Property<string>("JobName");

                    b.Property<string>("Scope");

                    b.HasKey("EstimateID");

                    b.ToTable("Estimate");
                });

            modelBuilder.Entity("SteffanIndustries.Models.EstimateDetail", b =>
                {
                    b.Property<int>("EstimateDetailID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<decimal?>("Cost");

                    b.Property<string>("Description");

                    b.Property<int>("EstimateID");

                    b.Property<string>("EstimateSection");

                    b.Property<decimal?>("Markup");

                    b.Property<decimal>("NumberOfDays");

                    b.Property<decimal>("NumberOfHours");

                    b.Property<decimal>("NumberOfWorkers");

                    b.Property<decimal>("Rate");

                    b.Property<decimal?>("TotalAmount");

                    b.Property<string>("UOM");

                    b.Property<decimal>("UOMQuantity");

                    b.HasKey("EstimateDetailID");

                    b.HasIndex("EstimateID");

                    b.ToTable("EstimateDetail");
                });

            modelBuilder.Entity("SteffanIndustries.Models.Quote", b =>
                {
                    b.Property<int>("QuoteID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("City");

                    b.Property<string>("CompanyName");

                    b.Property<string>("Contact");

                    b.Property<string>("ContactEmail");

                    b.Property<string>("ContactPhone");

                    b.Property<decimal?>("JobCost");

                    b.Property<string>("JobName");

                    b.Property<string>("JobScope");

                    b.Property<DateTime>("QuoteDate");

                    b.Property<string>("State");

                    b.Property<string>("Zip");

                    b.HasKey("QuoteID");

                    b.ToTable("Quote");
                });

            modelBuilder.Entity("SteffanIndustries.Models.QuoteNote", b =>
                {
                    b.Property<int>("QuoteNoteID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Note");

                    b.Property<int>("NoteNumber");

                    b.Property<int>("QuoteID");

                    b.HasKey("QuoteNoteID");

                    b.HasIndex("QuoteID");

                    b.ToTable("QuoteNote");
                });

            modelBuilder.Entity("SteffanIndustries.Models.EstimateDetail", b =>
                {
                    b.HasOne("SteffanIndustries.Models.Estimate")
                        .WithMany("EstimateDetail")
                        .HasForeignKey("EstimateID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SteffanIndustries.Models.QuoteNote", b =>
                {
                    b.HasOne("SteffanIndustries.Models.Quote", "quote")
                        .WithMany("QuoteNote")
                        .HasForeignKey("QuoteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
