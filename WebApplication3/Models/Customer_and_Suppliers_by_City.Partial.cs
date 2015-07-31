namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Customer_and_Suppliers_by_CityMetaData))]
    public partial class Customer_and_Suppliers_by_City
    {
    }
    
    public partial class Customer_and_Suppliers_by_CityMetaData
    {
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        public string City { get; set; }
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        [Required]
        public string CompanyName { get; set; }
        
        [StringLength(30, ErrorMessage="欄位長度不得大於 30 個字元")]
        public string ContactName { get; set; }
        
        [StringLength(9, ErrorMessage="欄位長度不得大於 9 個字元")]
        [Required]
        public string Relationship { get; set; }
    }
}
