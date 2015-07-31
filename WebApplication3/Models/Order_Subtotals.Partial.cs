namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Order_SubtotalsMetaData))]
    public partial class Order_Subtotals
    {
    }
    
    public partial class Order_SubtotalsMetaData
    {
        [Required]
        public int OrderID { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
    }
}
