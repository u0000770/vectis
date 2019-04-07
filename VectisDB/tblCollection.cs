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
    
    public partial class tblCollection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCollection()
        {
            this.tblCollectionTypes = new HashSet<tblCollectionType>();
            this.tblLots = new HashSet<tblLot>();
        }
    
        public int CollectionID { get; set; }
        public int ClientID { get; set; }
        public Nullable<System.DateTime> DateReceived { get; set; }
        public string ForAuction { get; set; }
        public string Comments { get; set; }
        public string InhouseComments { get; set; }
        public Nullable<int> CommisionRateID { get; set; }
        public Nullable<decimal> CommisionRate { get; set; }
        public Nullable<decimal> InsuranceRate { get; set; }
        public Nullable<decimal> MiscCost { get; set; }
        public string StoragePoint { get; set; }
        public Nullable<int> LogBookNumber { get; set; }
        public Nullable<System.DateTime> ReceiptPrinted { get; set; }
        public Nullable<System.DateTime> LetterPrinted { get; set; }
        public Nullable<decimal> UnsoldItemCharge { get; set; }
        public Nullable<decimal> MinimumVendorCommision { get; set; }
        public Nullable<decimal> CatalogueCharge { get; set; }
    
        public virtual tblClient tblClient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCollectionType> tblCollectionTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLot> tblLots { get; set; }
    }
}
