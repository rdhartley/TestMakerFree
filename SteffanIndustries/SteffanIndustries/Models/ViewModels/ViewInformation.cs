﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace SteffanIndustries.Models.ViewModels
{
    public class ViewInformation
    {
        public bool ReturnStatus { get; set; }
        public List<String> ReturnMessage { get; set; }
        public Hashtable ValidationErrors;

        public Int32 CurrentPageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public string SortExpression { get; set; }
        public string SortDirection { get; set; }
        public int RowIndex { get; set; }
        public string ViewState { get; set; }
        public string PageID { get; set; }

    }
}
