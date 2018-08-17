using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SteffanIndustries.Models
{
    public partial class EstimateDetail
    {
        public int EstimateDetailID { get; set; }
        public string EstimateSection { get; set; }
        public string Category { get; set; }

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
        public int EstimateID { get; set; }
    }
}
