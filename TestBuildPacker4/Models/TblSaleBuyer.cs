using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBuildPacker4.Models
{
    public class TblSaleBuyer
    {
        public int BuyerInvoiceId { get; set; }
        public int? InvoiceNumberId { get; set; }
        public int BuyerId { get; set; }
        public DateTime BoughtDate { get; set; }
        public decimal HammerPrice { get; set; }
        public decimal? CommissionRate { get; set; }
        public decimal VatRate { get; set; }
        public decimal Commission { get; set; }
        public decimal ComVat { get; set; }
        public decimal? TotalPrice { get; set; }
        public bool? InvoicePrinted { get; set; }
        public DateTime? InvoicePrintDate { get; set; }
        public int? SaleType { get; set; }
        public int? LotNumber { get; set; }
        public int? AuctionId { get; set; }
        public DateTime? DateAmended { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? AmendedWho { get; set; }

        public TblClient Buyer { get; set; }
        public TblSaleInvoice InvoiceNumber { get; set; }
    }
}
