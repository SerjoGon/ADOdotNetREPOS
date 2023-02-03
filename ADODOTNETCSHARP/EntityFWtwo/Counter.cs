//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFWtwo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Counter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        
        public int Id { get; set; }
        public string CounterName { get; set; }
        public string Count { get; set; }
        public System.DateTime DateDelivery { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
        public Counter() { }

        public Counter(int id,string countername, string count, DateTime date)
        {
            this.Product = new HashSet<Product>();
            Id = id;
            CounterName = countername;
            Count = count;
            DateDelivery= date;
        }
        public override string ToString()
        {
            return Id.ToString() + " " + CounterName + " " + Count + " " + DateDelivery.ToString();
        }
    }
}