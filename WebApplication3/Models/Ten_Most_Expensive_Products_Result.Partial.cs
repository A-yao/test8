namespace WebApplication3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Ten_Most_Expensive_Products_ResultMetaData))]
    public partial class Ten_Most_Expensive_Products_Result
    {
    }
    
    public partial class Ten_Most_Expensive_Products_ResultMetaData
    {
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        [Required]
        public string TenMostExpensiveProducts { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
    }
}
