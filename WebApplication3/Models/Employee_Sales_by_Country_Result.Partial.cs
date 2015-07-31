namespace WebApplication3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Employee_Sales_by_Country_ResultMetaData))]
    public partial class Employee_Sales_by_Country_Result
    {
    }
    
    public partial class Employee_Sales_by_Country_ResultMetaData
    {
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        public string Country { get; set; }
        
        [StringLength(20, ErrorMessage="欄位長度不得大於 20 個字元")]
        [Required]
        public string LastName { get; set; }
        
        [StringLength(10, ErrorMessage="欄位長度不得大於 10 個字元")]
        [Required]
        public string FirstName { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        [Required]
        public int OrderID { get; set; }
        public Nullable<decimal> SaleAmount { get; set; }
    }
}
