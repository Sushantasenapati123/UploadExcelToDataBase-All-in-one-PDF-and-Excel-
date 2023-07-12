using System.Collections.Generic;

namespace ImportExcleToDataBase.Models
{
    public class SimpleReportViewModel
    {
        public string DimensionOne { get; set; }
        public int Quantity { get; set; }
    }
    public class StackedViewModel
    {
        public string StackedDimensionOne { get; set; }
        public List<SimpleReportViewModel> LstData { get; set; }
    }
}
