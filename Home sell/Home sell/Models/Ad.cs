//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Home_sell.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ad
    {
        public int Id { get; set; }
        public int StreetsId { get; set; }
        public int TypeId { get; set; }
        public int RoomCount { get; set; }
        public Nullable<decimal> Price { get; set; }
        public int AdType { get; set; }
        public Nullable<decimal> Area { get; set; }
        public int Floor { get; set; }
    
        public virtual Street Street { get; set; }
        public virtual Type Type { get; set; }
    }
}
