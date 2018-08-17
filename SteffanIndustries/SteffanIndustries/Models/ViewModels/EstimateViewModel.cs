using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SteffanIndustries.Models.ViewModels
{
    public class EstimateViewModel
    {
        public int EstimateID { get; set; }
        
        public DateTime EstimateDate { get; set; }
        
        public string JobName { get; set; }
        
        public string Scope { get; set; }
        
        public string Contact { get; set; }
        
        public string ContactPhone { get; set; }
        public List<EstimateDetail> EstimateDetail { get; set; }
    }
}
    
    

