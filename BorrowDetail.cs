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
    
    public partial class BorrowDetail
    {
        public string ID { get; set; }
        public string BookID { get; set; }
        public string Tilte { get; set; }
        public string Genre { get; set; }
        public int Qty { get; set; }
        public string Note { get; set; }
    
        public virtual Borrow Borrow { get; set; }
    }
}