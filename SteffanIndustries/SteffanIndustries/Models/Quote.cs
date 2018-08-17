using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SteffanIndustries.Models
{
    public partial class Quote
    {
        public int QuoteID { get; set; }

        [Display(Name = "Quote Date")]
        public DateTime QuoteDate { get; set; }
        public string CompanyName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Contact { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string JobName { get; set; }
        public string JobScope { get; set; }
        public decimal? JobCost { get; set; }
        public List<QuoteNote> QuoteNote { get; set; }
    }
}
