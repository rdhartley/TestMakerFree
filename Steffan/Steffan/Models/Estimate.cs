using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SteffanIndustries.Models
{
    public class Estimate
    {
        public int ID { get; set; }

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

        public ICollection<EstimateDetail> EstimateDetails { get; set; }
    }
}