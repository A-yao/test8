namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Summary_of_Sales_by_YearMetaData))]
    public partial class Summary_of_Sales_by_Year
    {
    }
    
    public partial class Summary_of_Sales_by_YearMetaData
    {
        public Nullable<System.DateTime> ShippedDate { get; set; }
        [Required]
        public int OrderID { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
    }
}
