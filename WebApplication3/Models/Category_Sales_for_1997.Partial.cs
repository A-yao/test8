namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Category_Sales_for_1997MetaData))]
    public partial class Category_Sales_for_1997
    {
    }
    
    public partial class Category_Sales_for_1997MetaData
    {
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        [Required]
        public string CategoryName { get; set; }
        public Nullable<decimal> CategorySales { get; set; }
    }
}
