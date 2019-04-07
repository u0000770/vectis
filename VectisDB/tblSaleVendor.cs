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
    
    public partial class tblSaleVendor
    {
        public int VendorInvoiceID { get; set; }
        public int InvoiceNumberID { get; set; }
        public int VendorID { get; set; }
        public System.DateTime SoldDate { get; set; }
        public decimal HammerPrice { get; set; }
        public decimal VatRate { get; set; }
        public decimal InsuranceRate { get; set; }
        public decimal CommissionRate { get; set; }
        public decimal Commission { get; set; }
        public Nullable<decimal> ComVat { get; set; }
        public Nullable<decimal> Insurance { get; set; }
        public Nullable<decimal> InsVat { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<bool> InvoicePrinted { get; set; }
        public Nullable<System.DateTime> InvoicePrintDate { get; set; }
        public Nullable<int> LotNumber { get; set; }
        public Nullable<int> AuctionID { get; set; }
        public Nullable<System.DateTime> DateAmended { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> AmendedWho { get; set; }
        public Nullable<decimal> UnsoldItemCharge { get; set; }
        public Nullable<decimal> MinimumVendorCommision { get; set; }
        public Nullable<decimal> CatalogueCharge { get; set; }
        public Nullable<decimal> TotalCharge { get; set; }
        public Nullable<decimal> TotalChargeVat { get; set; }
    
        public virtual tblClient tblClient { get; set; }
        public virtual tblSaleInvoice tblSaleInvoice { get; set; }
    }
}
