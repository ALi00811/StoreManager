//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _4payeSystem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblPurchaseRecord
    {
        public int ID { get; set; }
        public string Name_Customer { get; set; }
        public int Amount { get; set; }
        public System.DateTime DateTime { get; set; }
        public string Type { get; set; }
        public string MeliCode { get; set; }
    
        public virtual TblUser TblUser { get; set; }
    }
}
