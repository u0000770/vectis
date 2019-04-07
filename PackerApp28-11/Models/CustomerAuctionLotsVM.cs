using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VectisDB;

namespace PackerApp28_11.Models
{
    public class CustomerAuctionLotsVMItem
    {
        public string CustomerName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Auction Date")]
        public DateTime AuctionDate { get; set; }
        public string AuctionTitle { get; set; }
        public int LotNumber { get; set; }

    }

    public class CustomerAuctionLots
    {
        public int customerId { get; set; }
        public int auctionId { get; set; }
        public string auctionTitle { get; set; }
        public int lotId { get; set; }
        public int LotNumber { get; set; }
    }

    public class CustomerAuctionLotsVM
    {
        public List<CustomerAuctionLotsVMItem> listOfAuctionLots;

        public static List<CustomerAuctionLotsVMItem> BuildVM(IEnumerable<VectisDB.tblAuction> all)
        {
            TestVectis2008Entities Vdb = new TestVectis2008Entities();
            List<CustomerAuctionLots> listofClientLots = new List<CustomerAuctionLots>();
            foreach (VectisDB.tblAuction a in all)
            {
                var x = getCustomersatAnAuction(a);
                listofClientLots.AddRange(x);
            }

            List<CustomerAuctionLotsVMItem> vm = new List<CustomerAuctionLotsVMItem>();

            var ListofClients = Vdb.tblClients;

            foreach (var v in listofClientLots)
            {
                CustomerAuctionLotsVMItem thisVM = new CustomerAuctionLotsVMItem();
                var thisCustomer = ListofClients.Find(v.customerId);
                var thisAuction = all.Single(a => a.AuctionID == v.auctionId);
                var thisAuctionTitle = all.Single(at => at.AuctionTitle == v.auctionTitle);
                thisVM.AuctionDate = thisAuction.AuctionDate;
                thisVM.CustomerName = thisCustomer.Forename + " " + thisCustomer.Surname;
                thisVM.AuctionTitle = thisAuctionTitle.AuctionTitle;
                vm.Add(thisVM);

            }

            return vm;
        }

        public static List<CustomerAuctionLots> getCustomersatAnAuction(VectisDB.tblAuction a)
        {

            // conecting to the database
            TestVectis2008Entities Vdb = new TestVectis2008Entities();
            List<CustomerAuctionLots> listofClientLots = new List<CustomerAuctionLots>();

            // getting all clients
            var ListofClients = Vdb.tblClients;
            // getting all winning bidders
            var ListofBuyers = a.tblBids.Where(b => b.Winning == true);

            // creating a list of winning bidder ids
            HashSet<int> ListOfClientId = new HashSet<int>();
            foreach (var c in ListofBuyers)
            {
                ListOfClientId.Add(c.BuyerID);
            }

            foreach (var c in ListOfClientId)
            {
                var thisAC = new CustomerAuctionLots();
                thisAC.customerId = c;
                thisAC.auctionId = a.AuctionID;
                thisAC.auctionTitle = a.AuctionTitle;
                listofClientLots.Add(thisAC);
            }


            //HashSet<tblClient> listofClientswhohaveboughtsumat = new HashSet<tblClient>();

            //foreach(var c in ListofClients)
            //{
            //    foreach(var b in ListOfClientId)
            //    {
            //        if ( c.ClientID == b)
            //        {
            //            listofClientswhohaveboughtsumat.Add(c);
            //        }
            //    }
            //}


            return listofClientLots;

        }


    }
}