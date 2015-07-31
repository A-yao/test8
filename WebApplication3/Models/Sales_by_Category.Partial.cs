namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Sales_by_CategoryMetaData))]
    public partial class Sales_by_Category
    {
    }
    
    public partial class Sales_by_CategoryMetaData
    {
        [Required]
        public int CategoryID { get; set; }
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        [Required]
        public string CategoryName { get; set; }
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        [Required]
        public string ProductName { get; set; }
        public Nullable<decimal> ProductSales { get; set; }
    }
}
