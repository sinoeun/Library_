//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_CSharp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Borrow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Borrow()
        {
            this.BorrowDetails = new HashSet<BorrowDetail>();
        }
    
        public string ID { get; set; }
        public string Staff { get; set; }
        public string Member { get; set; }
        public System.DateTime BDate { get; set; }
        public System.DateTime Due { get; set; }
    
        public virtual Member Member1 { get; set; }
        public virtual Staff Staff1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorrowDetail> BorrowDetails { get; set; }
    }
}