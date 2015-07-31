namespace WebApplication3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(SalesByCategory_ResultMetaData))]
    public partial class SalesByCategory_Result
    {
    }
    
    public partial class SalesByCategory_ResultMetaData
    {
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        [Required]
        public string ProductName { get; set; }
        public Nullable<decimal> TotalPurchase { get; set; }
    }
}
