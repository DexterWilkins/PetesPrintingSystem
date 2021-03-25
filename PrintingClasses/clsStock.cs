using System;

namespace PrintingClasses
{
    public class clsStock
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int StockNo { get; set; }
        public string StockDescription { get; set; }
        public string StockLocation { get; set; }
        public bool InStock { get; set; }
    }
}