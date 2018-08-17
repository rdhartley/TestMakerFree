using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SteffanIndustries.Models
{
    public partial class Estimate
    {
        public int EstimateID { get; set; }
        public int EstimateSection { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Estimate Date")]
        public DateTime EstimateDate { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Job Name")]
        public string JobName { get; set; }

        [DataType(DataType.MultilineText)]
        public string Scope { get; set; }
        public string Contact { get; set; }
        [Display(Name = "Contact Phone")]

        public string ContactPhone { get; set; }
        public List<EstimateDetail> EstimateDetail { get; set; }
    }
}
