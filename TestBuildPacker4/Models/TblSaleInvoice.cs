using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBuildPacker4.Models
{
    public class TblSaleInvoice
    {
        public TblSaleInvoice()
        {
            TblSaleBuyer = new HashSet<TblSaleBuyer>();
            TblSaleVendor = new HashSet<TblSaleVendor>();
        }

        public int SaleInvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public int? ClientId { get; set; }
        public int? AuctionId { get; set; }
        public int? DayNo { get; set; }
        public string InvoiceType { get; set; }
        public int? TotalItems { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? Cctype { get; set; }
        public string Ccno { get; set; }
        public string CcholderName { get; set; }
        public string Ccexpiry { get; set; }
        public string Ccstart { get; set; }
        public string CcsecurityNo { get; set; }
        public string CcissueNo { get; set; }
        public decimal? Ccamount { get; set; }
        public decimal? Postage { get; set; }
        public decimal? PostVat { get; set; }
        public DateTime? DespatchDate { get; set; }
        public string DespatchNumber { get; set; }
        public string DespatchService { get; set; }
        public decimal? CreditCharge { get; set; }
        public string FileName { get; set; }
        public DateTime? DateGenerated { get; set; }
        public DateTime? DateAmended { get; set; }
        public DateTime? DateEmailed { get; set; }
        public DateTime? DatePrinted { get; set; }
        public bool? IsHammerPaid { get; set; }
        public bool? IsFeesPaid { get; set; }
        public decimal? CreditCardChargeRate { get; set; }
        public decimal? PostageCccharge { get; set; }
        public decimal? PostageCcchargeRate { get; set; }
        public decimal? HammerPayment { get; set; }
        public decimal? CreditChargeOn { get; set; }
        public bool? IsOnlineSaleIncluded { get; set; }

        public ICollection<TblSaleBuyer> TblSaleBuyer { get; set; }
        public ICollection<TblSaleVendor> TblSaleVendor { get; set; }
    }
}
