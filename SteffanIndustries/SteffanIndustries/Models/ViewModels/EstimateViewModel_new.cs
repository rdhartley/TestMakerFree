using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace SteffanIndustries.Models.ViewModels
{
    public class EstimateViewModel_new : ViewInformation
    {
        public Estimate Estimate;
        public EstimateDetail EstimateDetail;
        public List<Estimate> Estimates;
        public List<EstimateDetail> EstimateDetails;
        public int EstimateTotal { get; set; }

        public EstimateViewModel_new()
        {
            Estimate = new Estimate();
            EstimateDetail = new EstimateDetail();
            Estimates = new List<Estimate>();
            EstimateDetails = new List<EstimateDetail>();
            ReturnMessage = new List<String>();
            ValidationErrors = new Hashtable();
            EstimateTotal = 0;
        }

    }
}
