using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBuildPacker4.Models
{
    public class TblSaleVendor
    {
        public int VendorInvoiceId { get; set; }
        public int InvoiceNumberId { get; set; }
        public int VendorId { get; set; }
        public DateTime SoldDate { get; set; }
        public decimal HammerPrice { get; set; }
        public decimal VatRate { get; set; }
        public decimal InsuranceRate { get; set; }
        public decimal CommissionRate { get; set; }
        public decimal Commission { get; set; }
        public decimal? ComVat { get; set; }
        public decimal? Insurance { get; set; }
        public decimal? InsVat { get; set; }
        public decimal? TotalPrice { get; set; }
        public bool? InvoicePrinted { get; set; }
        public DateTime? InvoicePrintDate { get; set; }
        public int? LotNumber { get; set; }
        public int? AuctionId { get; set; }
        public DateTime? DateAmended { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? AmendedWho { get; set; }
        public decimal? UnsoldItemCharge { get; set; }
        public decimal? MinimumVendorCommision { get; set; }
        public decimal? CatalogueCharge { get; set; }
        public decimal? TotalCharge { get; set; }
        public decimal? TotalChargeVat { get; set; }

        public TblSaleInvoice InvoiceNumber { get; set; }
        public TblClient Vendor { get; set; }
    }
}
