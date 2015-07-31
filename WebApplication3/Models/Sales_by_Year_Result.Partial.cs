namespace WebApplication3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Sales_by_Year_ResultMetaData))]
    public partial class Sales_by_Year_Result
    {
    }
    
    public partial class Sales_by_Year_ResultMetaData
    {
        public Nullable<System.DateTime> ShippedDate { get; set; }
        [Required]
        public int OrderID { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        
        [StringLength(30, ErrorMessage="欄位長度不得大於 30 個字元")]
        public string Year { get; set; }
    }
}
