using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBuildPacker4.Models
{
    public class TblPayment
    {
        public int ClientId { get; set; }
        public int? Cctype { get; set; }
        public string Ccno { get; set; }
        public string CcholderName { get; set; }
        public string Ccexpiry { get; set; }
        public string Ccstart { get; set; }
        public string CcsecurityNo { get; set; }
        public string CcissueNo { get; set; }
        public string SageVendorId { get; set; }
        public string SageBuyerId { get; set; }
        public string BankHoldersName { get; set; }
        public string BankAccountNo { get; set; }
        public string BankSortCode { get; set; }
        public bool UseCardForPayment { get; set; }
        public string PaymentToken { get; set; }
        public bool? IsOldCreditCardDetails { get; set; }
        public bool? IsInitialPaymentMade { get; set; }

        public TblClient Client { get; set; }
    }
}
