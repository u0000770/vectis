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
    
    public partial class tblLot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblLot()
        {
            this.tblBids = new HashSet<tblBid>();
        }
    
        public long LotID { get; set; }
        public int AuctionID { get; set; }
        public Nullable<int> CatAuxID { get; set; }
        public Nullable<bool> ImportedToMain { get; set; }
        public Nullable<int> DayNo { get; set; }
        public int CatSectionID { get; set; }
        public Nullable<short> LotNumber { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Reserve { get; set; }
        public decimal BottomPrice { get; set; }
        public decimal TopPrice { get; set; }
        public Nullable<decimal> StartingPrice { get; set; }
        public int CollectionID { get; set; }
        public Nullable<int> BuyerID { get; set; }
        public Nullable<decimal> HammerPrice { get; set; }
        public Nullable<int> WinningBuyer { get; set; }
        public Nullable<int> NextBuyer { get; set; }
        public Nullable<decimal> AbsMinPrice { get; set; }
        public Nullable<System.DateTime> DateLastAmended { get; set; }
        public string LastAmendedWho { get; set; }
        public long ParentLotID { get; set; }
        public Nullable<int> SaleType { get; set; }
        public bool Checked { get; set; }
        public string UnsoldRef { get; set; }
        public int BuyerPaddleID { get; set; }
        public int BuyerPaddleNo { get; set; }
        public Nullable<decimal> WinningBid { get; set; }
        public Nullable<decimal> NextBid { get; set; }
        public string VectisCode { get; set; }
        public Nullable<int> BuyerInvoiceID { get; set; }
        public Nullable<int> VendorInvoiceID { get; set; }
        public Nullable<bool> Withdrawn { get; set; }
        public bool BidEnteredWhileBookOpen { get; set; }
        public string WebLotTitle { get; set; }
        public string Keywords { get; set; }
    
        public virtual tblAuction tblAuction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBid> tblBids { get; set; }
        public virtual tblCatAux tblCatAux { get; set; }
        public virtual tblCatSection tblCatSection { get; set; }
        public virtual tblCollection tblCollection { get; set; }
    }
}
