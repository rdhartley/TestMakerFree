using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SteffanIndustries.Models
{
    public enum Section
    {
        SUBCONTRACTORS, RENTED_EQUIPMENT, STEFFAN_INDUSTRIES
    }
    public enum Category
    {
        TRAVEL, LABOR, EQUIPMENT, MATERIAL
    }
    public enum Trade
    {
        Mechanical, Electrical
    }
    public partial class EstimateDetail
    {
        public int ID { get; set; }
        public int EstimateID { get; set; }

        public Section? Section { get; set; }
        public Category? Category { get; set; }
        public Trade? Trade { get; set; }
        public string RentalCompany { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public string UOM { get; set; }
        public decimal UOMQuantity { get; set; }
        public decimal NumberOfWorkers { get; set; }
        public decimal NumberOfHours { get; set; }
        public decimal NumberOfDays { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Markup { get; set; }
        public decimal? TotalAmount { get; set; }

        public Estimate Estimate { get; set; }
    }
}
