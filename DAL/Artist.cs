//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Artist
    {
        public Artist()
        {
            this.Albums = new HashSet<Album>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<Album> Albums { get; set; }
    }
}
