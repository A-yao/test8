namespace WebApplication3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(CustOrderHist_ResultMetaData))]
    public partial class CustOrderHist_Result
    {
    }
    
    public partial class CustOrderHist_ResultMetaData
    {
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        [Required]
        public string ProductName { get; set; }
        public Nullable<int> Total { get; set; }
    }
}
