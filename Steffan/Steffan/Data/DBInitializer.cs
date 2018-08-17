using SteffanIndustries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steffan.Data
{
    public class DBInitializer
    {
        public static void Initialize(SteffanContext context)
        {
            context.Database.EnsureCreated();

            if (context.Estimates.Any())
            {
                return;   // DB has been seeded
            }


            var estimates = new Estimate[]
{
                new Estimate { JobName = "Protenergy recart line matchmark and tag ",
                    Scope = "Labor and equipment to matchmark, tagmark and photograph " +
                    "components and utility piping of recart line in Cambridge, MD " +
                    "prior to equipment relocation ",
                    Contact="Al Tooney",
                    ContactPhone="412 352-8786",
                    EstimateDate = DateTime.Parse("03-13-2017") }
};
            foreach (Estimate s in estimates)
            {
                context.Estimates.Add(s);
            }
            context.SaveChanges();

            var estimateDetails = new EstimateDetail[]
            {
                new EstimateDetail
                {
                    Section=Section.SUBCONTRACTORS,
                    Trade=Trade.Mechanical,
                    RentalCompany="",
                    Description="QCCM",
                    Rate=11100.00m,
                    UOM="EA",
                    UOMQuantity=1,
                    NumberOfWorkers=0,
                    NumberOfHours=0,
                    NumberOfDays=0,
                    Cost=11100.00m,
                    Markup=2775.00m,
                    TotalAmount=13875.00m,
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").ID
                },
                new EstimateDetail
                {
                    Section=Section.RENTED_EQUIPMENT,
                    RentalCompany="United Rental",
                    Description="19' manlift",
                    Rate=330.00m,
                    UOM="EA",
                    UOMQuantity=2,
                    NumberOfWorkers=0,
                    NumberOfHours=0,
                    NumberOfDays=0,
                    Cost=660.00m,
                    Markup=165.00m,
                    TotalAmount=825.00m,
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").ID
                },
                new EstimateDetail
                {
                    Section=Section.RENTED_EQUIPMENT,
                    RentalCompany="",
                    Description="Freight",
                    Rate=450.00m,
                    UOM="EA",
                    UOMQuantity=1,
                    NumberOfWorkers=0,
                    NumberOfHours=0,
                    NumberOfDays=0,
                    Cost=450.00m,
                    Markup=112.50m,
                    TotalAmount=562.50m,
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").ID

                },
                new EstimateDetail
                {
                    Section=Section.STEFFAN_INDUSTRIES,
                    Category=Category.LABOR,
                    RentalCompany="",
                    Description="Travel",
                    Rate=120.00m,
                    UOM="DA",
                    UOMQuantity=2,
                    NumberOfWorkers=3,
                    NumberOfHours=0,
                    NumberOfDays=0,
                    Cost=720.00m,
                    Markup=0.00m,
                    TotalAmount=720.00m,
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").ID

                },
             new EstimateDetail
                {
                    Section=Section.STEFFAN_INDUSTRIES,
                    Category=Category.LABOR,
                    RentalCompany="",
                    Description="Rigger",
                    Rate=115.00m,
                    UOM="HR",
                    UOMQuantity=12,
                    NumberOfWorkers=2,
                    NumberOfHours=0,
                    NumberOfDays=2,
                    Cost=5520.00m,
                    Markup=0.00m,
                    TotalAmount=5520.00m,
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").ID

                },
             new EstimateDetail
                {
                    Section=Section.STEFFAN_INDUSTRIES,
                    Category=Category.LABOR,
                    RentalCompany="",
                    Description="Rigger Foreman",
                    Rate=155.00m,
                    UOM="HR",
                    UOMQuantity=12,
                    NumberOfWorkers=1,
                    NumberOfHours=0,
                    NumberOfDays=2,
                    Cost=5520.00m,
                    Markup=0.00m,
                    TotalAmount=5520.00m,
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").ID

                },
             new EstimateDetail
                {
                    Section=Section.STEFFAN_INDUSTRIES,
                    Category=Category.LABOR,
                    RentalCompany="",
                    Description="Per Diem",
                    Rate=180.00m,
                    UOM="DA",
                    UOMQuantity=1,
                    NumberOfWorkers=3,
                    NumberOfHours=0,
                    NumberOfDays=3,
                    Cost=1620.00m,
                    Markup=0.00m,
                    TotalAmount=1620.00m,
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").ID

                },
             new EstimateDetail
                {
                    Section=Section.STEFFAN_INDUSTRIES,
                    Category=Category.EQUIPMENT,
                    RentalCompany="",
                    Description="Rigging Service Truck",
                    Rate=105.00m,
                    UOM="HR",
                    UOMQuantity=8,
                    NumberOfWorkers=0,
                    NumberOfHours=0,
                    NumberOfDays=2,
                    Cost=1680.00m,
                    Markup=0.00m,
                    TotalAmount=1680.00m,
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").ID

                },
             new EstimateDetail
                {
                    Section=Section.STEFFAN_INDUSTRIES,
                    Category=Category.MATERIAL,
                    RentalCompany="",
                    Description="",
                    Rate=500.00m,
                    UOM="EA",
                    UOMQuantity=1,
                    NumberOfWorkers=0,
                    NumberOfHours=0,
                    NumberOfDays=0,
                    Cost=500.00m,
                    Markup=0.00m,
                    TotalAmount=500.00m,
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").ID

                },
             new EstimateDetail
                {
                    Section=Section.STEFFAN_INDUSTRIES,
                    RentalCompany="",
                    Description="Initial Walkthrough",
                    Rate=3880.00m,
                    UOM="EA",
                    UOMQuantity=1,
                    NumberOfWorkers=0,
                    NumberOfHours=0,
                    NumberOfDays=0,
                    Cost=3880.00m,
                    Markup=0.00m,
                    TotalAmount=3880.00m,
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").ID

                }
            };
            foreach (EstimateDetail s in estimateDetails)
            {
                context.EstimateDetails.Add(s);
            }
            context.SaveChanges();

        }
    }
}
