//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CleaningApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbWindow
    {
        public int windowid { get; set; }
        public string side { get; set; }
        public int noOfBedrooms { get; set; }
        public decimal wprice { get; set; }
        public Nullable<int> serviceid { get; set; }
    
        public virtual tbservice tbservice { get; set; }
    }
}
