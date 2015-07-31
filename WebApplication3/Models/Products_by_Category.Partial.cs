namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Products_by_CategoryMetaData))]
    public partial class Products_by_Category
    {
    }
    
    public partial class Products_by_CategoryMetaData
    {
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        [Required]
        public string CategoryName { get; set; }
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        [Required]
        public string ProductName { get; set; }
        
        [StringLength(20, ErrorMessage="欄位長度不得大於 20 個字元")]
        public string QuantityPerUnit { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        [Required]
        public bool Discontinued { get; set; }
    }
}
