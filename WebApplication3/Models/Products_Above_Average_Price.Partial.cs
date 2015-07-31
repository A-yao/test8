namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Products_Above_Average_PriceMetaData))]
    public partial class Products_Above_Average_Price
    {
    }
    
    public partial class Products_Above_Average_PriceMetaData
    {
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        [Required]
        public string ProductName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
    }
}
