namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Current_Product_ListMetaData))]
    public partial class Current_Product_List
    {
    }
    
    public partial class Current_Product_ListMetaData
    {
        [Required]
        public int ProductID { get; set; }
        
        [StringLength(40, ErrorMessage="欄位長度不得大於 40 個字元")]
        [Required]
        public string ProductName { get; set; }
    }
}
