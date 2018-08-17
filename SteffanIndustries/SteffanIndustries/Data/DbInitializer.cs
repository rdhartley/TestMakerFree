using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SteffanIndustries.Models;
using SteffanIndustries.Models.ViewModels;


namespace SteffanIndustries.Data
{
    public class DbInitializer
    {
        public static void Initialize(SteffanContext context)
        {
            if (context.Estimate.Any())
            {
                return; // DB has been seeded

            }
            var estimates = new Estimate[]
            {
                new Estimate { JobName = "Protenergy recart line matchmark and tag",
                    Scope = "Labor and equipment to matchmark, tagmark and photograph" +
                    "components and utility piping of recart line in Cambridge, MD" +
                    "prior to equipment relocation",
                    Contact="Al Tooney",
                    ContactPhone="412 352-8786",
                    EstimateDate = DateTime.Parse("03-13-2017") }
            };
            foreach (Estimate s in estimates)
            {
                context.Estimate.Add(s);
            }
            context.SaveChanges();

            var estimateDetails = new EstimateDetail[]
            {
                new EstimateDetail
                {
                    EstimateSection="SUBCONTRACTORS",
                    Category="Mechanical",
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
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").EstimateID 
                },
                new EstimateDetail
                {
                    EstimateSection="RENTED EQUIPMENT",
                    Category="United Rental",
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
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").EstimateID
                },
                new EstimateDetail
                {
                    EstimateSection="RENTED EQUIPMENT",
                    Category="",
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
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").EstimateID

                },
                new EstimateDetail
                {
                    EstimateSection="STEFFAN INDUSTRIES",
                    Category="LABOR",
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
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").EstimateID

                },
             new EstimateDetail
                {
                    EstimateSection="STEFFAN INDUSTRIES",
                    Category="LABOR",
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
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").EstimateID

                },
             new EstimateDetail
                {
                    EstimateSection="STEFFAN INDUSTRIES",
                    Category="LABOR",
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
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").EstimateID

                },
             new EstimateDetail
                {
                    EstimateSection="STEFFAN INDUSTRIES",
                    Category="LABOR",
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
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").EstimateID

                },
             new EstimateDetail
                {
                    EstimateSection="STEFFAN INDUSTRIES",
                    Category="EQUIPMENT",
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
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").EstimateID

                },
             new EstimateDetail
                {
                    EstimateSection="STEFFAN INDUSTRIES",
                    Category="EQUIPMENT",
                    Description="Material",
                    Rate=500.00m,
                    UOM="EA",
                    UOMQuantity=1,
                    NumberOfWorkers=0,
                    NumberOfHours=0,
                    NumberOfDays=0,
                    Cost=500.00m,
                    Markup=0.00m,
                    TotalAmount=500.00m,
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").EstimateID

                },
             new EstimateDetail
                {
                    EstimateSection="STEFFAN INDUSTRIES",
                    Category="",
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
                    EstimateID = estimates.Single( i => i.Contact == "Al Tooney").EstimateID

                }
            };
            foreach (EstimateDetail s in estimateDetails)
            {
                context.EstimateDetail.Add(s);
            }
            context.SaveChanges();

            var quotes = new Quote[]
            {
                new Quote { JobName = "Protenergy Recart line matchmark and tag",
                    JobScope = "Labor and equipment to matchmark, tagmark and photograph" +
                    "components and utility piping of Recart line in Cambridge, MD" +
                    "prior to equipment relocation, and install temporary tarping support cable arount the perimeter of the Recart line",
                    Contact="Al Tooney",
                    ContactPhone="412 352-8786",
                    QuoteDate = DateTime.Parse("03-13-2017"),
                    CompanyName="Bay Valley Foods",
                    AddressLine1="1080 River Ave.1",
                    AddressLine2="MRO Dock L",
                    City="Pittsburgh",
                    State="Pa",
                    Zip="15212",
                    JobCost=32902.50m,
                    ContactEmail="al_tooney@bayvalleyfoods.com" }
            };
            foreach (Quote s in quotes)
            {
                context.Quote.Add(s);
            }
            context.SaveChanges();
            var quotenotes = new QuoteNote[]
            {
                new QuoteNote
                {
                    NoteNumber=1,
                    Note="Quote is based upon qty of (2) consecutive work days including overtime" +
                    "onsite at the Protenergy facilty per Bay Valley Foods",
                    QuoteID = quotes.Single( i => i.Contact == "Al Tooney").QuoteID
                },
                new QuoteNote
                {
                    NoteNumber=2,
                    Note="All electrical matchmark, tagging and disconnects shall be performed by others.",
                    QuoteID = quotes.Single( i => i.Contact == "Al Tooney").QuoteID
                },
                new QuoteNote
                {
                    NoteNumber=3,
                    Note="Steffan Industries, Inc. must have unrestricted access to the Protenergy facility" +
                    "to complete this work in the time table provided by Bay Valley Foods",
                    QuoteID = quotes.Single( i => i.Contact == "Al Tooney").QuoteID
                },
                new QuoteNote
                {
                    NoteNumber=4,
                    Note="All modifications to the above scope of work must be done via signed change orders between Steffan Industries, Inc." +
                    "and Bay Vally Foods.",
                    QuoteID = quotes.Single( i => i.Contact == "Al Tooney").QuoteID
                },
                new QuoteNote
                {
                    NoteNumber=5,
                    Note="Terms are Net 30.",
                    QuoteID = quotes.Single( i => i.Contact == "Al Tooney").QuoteID
                },
                new QuoteNote
                {
                    NoteNumber=6,
                    Note="Quote is valid for 60 days.",
                    QuoteID = quotes.Single( i => i.Contact == "Al Tooney").QuoteID
                }
            };
            foreach (QuoteNote s in quotenotes)
            {
                context.QuoteNote.Add(s);
            }
            context.SaveChanges();
        }
    };
}
