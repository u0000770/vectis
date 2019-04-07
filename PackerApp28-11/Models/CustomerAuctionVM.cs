using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VectisDB;
using VectisPackers;

namespace PackerApp28_11.Models
{
    public class CustomerAuctionVMItem
    {
        public int customerId { get; set; }
        public string CustomerName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Auction Date")]
        public DateTime AuctionDate { get; set; }
        public string AuctionTitle { get; set; }
        public int AuctionLotId { get; set; }
        public int AuctionLotNumber { get; set; }
        public int AuctionId { get; set; }
    }

    public class CustomerAuction
    {
       public int customerId { get; set; }
       public int auctionId { get; set; }
       public string auctionTitle { get; set; }
       public int lotId { get; set; }
       public int lotNumber { get; set; }
    }

    public class CustomerAuctionVM
    {
        public List<CustomerAuctionVMItem> listOfAuctions;

        /// <summary>
        /// connect to database (Vdb),
        /// get all customers at an Auction, add to new list (listofClientswhohaveboughtsumat)
        /// get customer details for each customer in list add to view
        /// </summary>
        /// uses:TestVectis2008.tblAuction, TestVectis2008.tblClient. TestVectis2008.tblLot
        public static List<CustomerAuctionVMItem> buildVM(IEnumerable<VectisPackers.MockAuction> all)
         { 
            TestVectis2008Entities Vdb = new TestVectis2008Entities();

            List<CustomerAuction> listofClientswhohaveboughtsumat = new List<CustomerAuction>();
            foreach(VectisPackers.MockAuction a in all)
            {
                var x = getCustomersatAnAuction(a);
                listofClientswhohaveboughtsumat.AddRange(x);
            }

            List<CustomerAuctionVMItem> vm = new List<CustomerAuctionVMItem>();

            //tblClients used to get customer details (Name, address, delivery instructions)
            var ListofClients = Vdb.tblClients;
            //tblLot used to get list of customer lots from an auction
            var ListofLots = Vdb.tblLots;

            foreach (var v in listofClientswhohaveboughtsumat)
            {
                CustomerAuctionVMItem thisVM = new CustomerAuctionVMItem();
                var thisCustomer = ListofClients.SingleOrDefault(a => a.ClientID == v.customerId);
                var thisAuction = all.SingleOrDefault(a => a.AuctionID == v.auctionId);
                var thisAuctionTitle = all.FirstOrDefault(at => at.AuctionTitle == v.auctionTitle);
                var thisAuctionLot = ListofLots.SingleOrDefault(a => a.LotNumber == v.lotNumber);
                thisVM.AuctionDate = thisAuction.AuctionDate;
                thisVM.customerId = thisCustomer.ClientID;
                thisVM.CustomerName = thisCustomer.Forename + " " + thisCustomer.Surname;
                thisVM.AuctionTitle = thisAuctionTitle.AuctionTitle;
                thisVM.AuctionId = thisAuction.AuctionID;
                vm.Add(thisVM);

            }
            return vm;
         }

        /// <summary>
        /// connect to database (Vdb)
        /// get CustomerIds, get Lots, create list of buyers for each lot
        /// add buyer details to listofClientswhohaveboughtsumat
        /// </summary>
        /// uses:TestVectis2008.tblAuctions, TestVectis2008.tblClient. TestVectis2008.tblLot
        public static List<CustomerAuction> getCustomersatAnAuction(VectisDB.tblAuction a)
        {
            TestVectis2008Entities Vdb = new TestVectis2008Entities();
            List<CustomerAuction> listofClientswhohaveboughtsumat = new List<CustomerAuction>();

            // get all clients from Vdb.tblClients
            var ListofClients = Vdb.tblClients;

            //get all lots from an Auction where hammer price is not null
            var lots = a.tblLots.Where(l => l.HammerPrice != (0.0000m) && l.AuctionID == a.AuctionID);

            // create a list of Buyers for each lot from db.tblClients 
            HashSet<int> ListOfClientId = new HashSet<int>();
            foreach (var l in lots)
            {
                if (l.BuyerID != null)
                ListOfClientId.Add((int)l.BuyerID);
            }

            // add buyer details to listofClientswhohaveboughtsumat
            foreach (var c in ListOfClientId)
            {
                var thisAC = new CustomerAuction();
                thisAC.customerId = c;
                thisAC.auctionId = a.AuctionID;
                thisAC.auctionTitle = a.AuctionTitle;

                listofClientswhohaveboughtsumat.Add(thisAC);

            }

            return listofClientswhohaveboughtsumat;

            }

    }
}