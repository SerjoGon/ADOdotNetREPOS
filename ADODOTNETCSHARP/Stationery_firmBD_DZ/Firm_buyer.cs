//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stationery_firmBD_DZ
{
    using System;
    using System.Collections.Generic;
    
    public partial class Firm_buyer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Firm_buyer() { }
        public Firm_buyer(int id,string firmname)
        {
            this.Id = id;
            this.Firm_Name = firmname;
            this.Sales = new HashSet<Sales>();
        }
    
        public int Id { get; set; }
        public string Firm_Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
