//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BT_BlogOdev.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Blog
    {
        public int ID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogDescription { get; set; }
        public Nullable<int> BlogType { get; set; }
        public string BlogWriter { get; set; }
        public Nullable<System.DateTime> Datetime { get; set; }
        public Nullable<int> OrderNumber { get; set; }
        public string ImageURL { get; set; }
    }
}