using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SteffanIndustries.Models
{
    public partial class QuoteNote
    {
        public int QuoteNoteID { get; set; }
        [Display(Name = "Sequence")]
        public int NoteNumber { get; set; }
        public string Note { get; set; }
        public int QuoteID { get; set; }

        public Quote quote { get; set; }
    }
}
