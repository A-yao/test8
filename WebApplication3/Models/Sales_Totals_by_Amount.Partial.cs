namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Sales_Totals_by_AmountMetaData))]
    public partial class Sales_Totals_by_Amount
    {
    }
    
    public partial class Sales_Totals_by_AmountMetaData
    {
        public Nullable<decimal> SaleAmount { get; set; }
        [Required]
        public int OrderID { get; set; }
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        [Required]
        public string CompanyName { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
    }
}
