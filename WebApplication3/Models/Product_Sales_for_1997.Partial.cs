namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Product_Sales_for_1997MetaData))]
    public partial class Product_Sales_for_1997
    {
    }
    
    public partial class Product_Sales_for_1997MetaData
    {
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        [Required]
        public string CategoryName { get; set; }
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        [Required]
        public string ProductName { get; set; }
        public Nullable<decimal> ProductSales { get; set; }
    }
}
