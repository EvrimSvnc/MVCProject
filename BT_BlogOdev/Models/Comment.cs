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
    
    public partial class Comment
    {
        public int ID { get; set; }
        public Nullable<int> BlogID { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string EMail { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
    }
}
