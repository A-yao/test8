namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Order_Details_ExtendedMetaData))]
    public partial class Order_Details_Extended
    {
    }
    
    public partial class Order_Details_ExtendedMetaData
    {
        [Required]
        public int OrderID { get; set; }
        [Required]
        public int ProductID { get; set; }
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public short Quantity { get; set; }
        [Required]
        public float Discount { get; set; }
        public Nullable<decimal> ExtendedPrice { get; set; }
    }
}
