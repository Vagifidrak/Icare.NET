//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Icare.NET.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderHistory
    {
        public int id { get; set; }
        public int OrderId { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
    
        public virtual Order Order { get; set; }
    }
}
