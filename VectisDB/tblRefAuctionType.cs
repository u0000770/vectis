//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VectisDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRefAuctionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRefAuctionType()
        {
            this.tblAuctions = new HashSet<tblAuction>();
        }
    
        public int AuctionTypeID { get; set; }
        public string AuctionTypeDescription { get; set; }
        public bool AuctionTypeDeleted { get; set; }
        public bool AuctionTypeDefault { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAuction> tblAuctions { get; set; }
    }
}
