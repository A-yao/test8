namespace WebApplication3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(CustOrdersOrders_ResultMetaData))]
    public partial class CustOrdersOrders_Result
    {
    }
    
    public partial class CustOrdersOrders_ResultMetaData
    {
        [Required]
        public int OrderID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
    }
}
