//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VectisPackers
{
    using System;
    using System.Collections.Generic;
    
    public partial class MockAuction
    {
        public int AuctionID { get; set; }
        public int AuctionType { get; set; }
        public System.DateTime AuctionDate { get; set; }
        public int AuctionDays { get; set; }
        public string AuctionTitle { get; set; }
        public bool CatalogueComplete { get; set; }
        public string MarkedCompleteBy { get; set; }
        public Nullable<System.DateTime> MarkedCompleteDate { get; set; }
        public bool CatalogueExported { get; set; }
        public string ExportedBy { get; set; }
        public Nullable<System.DateTime> ExportedDate { get; set; }
        public bool CatalogueUploaded { get; set; }
        public string UploadedBY { get; set; }
        public Nullable<System.DateTime> UploadedDate { get; set; }
        public bool LettersProduced { get; set; }
        public string LettersBy { get; set; }
        public Nullable<System.DateTime> LettersDate { get; set; }
        public string ViewingText { get; set; }
        public string ImageFolder { get; set; }
        public Nullable<decimal> CataloguePrice { get; set; }
        public string CatalogueThumb { get; set; }
        public string CatalogueImage { get; set; }
        public bool SubsUpdated { get; set; }
    }
}