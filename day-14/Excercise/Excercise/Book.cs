//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Excercise
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int BId { get; set; }
        public string BName { get; set; }
        public Nullable<double> BPrice { get; set; }
        public string AName { get; set; }
        public Nullable<int> CatID { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
