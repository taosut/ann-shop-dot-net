//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ann_shop_server.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Register
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UnSignedName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Nullable<int> ProvinceID { get; set; }
        public string Note { get; set; }
        public string ProductCategory { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
