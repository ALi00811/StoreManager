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
    
    public partial class TblUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblUser()
        {
            this.TblPurchaseRecords = new HashSet<TblPurchaseRecord>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string OzviatDate { get; set; }
        public string EtebarDate { get; set; }
        public string Komod { get; set; }
        public string MeliCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblPurchaseRecord> TblPurchaseRecords { get; set; }
    }
}