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
    
    public partial class BookDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookDetail()
        {
            this.ReturnDetails = new HashSet<ReturnDetail>();
        }
    
        public string ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Publicate { get; set; }
        public string Discription { get; set; }
        public string Path { get; set; }
    
        public virtual Location Location { get; set; }
        public virtual Publisher Publisher1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnDetail> ReturnDetails { get; set; }
    }
}
