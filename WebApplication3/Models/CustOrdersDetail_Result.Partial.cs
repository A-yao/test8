namespace WebApplication3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(CustOrdersDetail_ResultMetaData))]
    public partial class CustOrdersDetail_Result
    {
    }
    
    public partial class CustOrdersDetail_ResultMetaData
    {
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public short Quantity { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<decimal> ExtendedPrice { get; set; }
    }
}
