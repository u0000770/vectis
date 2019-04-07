using PackerRep;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VectisDB;
using VectisPackers;

namespace PackerApp28_11.Models
{

    public class LotDetailVMItem
    {
        public List<LotDetail> LotDetails { get; set; }
    }

    public class LotDetail
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string AuctionTitle { get; set; }
        public int LotId { get; set; }
        public int LotNumber { get; set; }
        public string LotDescription { get; set; }
        public string image { get; set; }
        public int AuctionId { get; set; }
        public List<LotDetail> LotDetails { get; set; }

    }

    /// <summary>
    /// get CustomerAcutionLotDetails
    /// </summary>
    /// uses:tblClients, tblLots
    public class LotDetailVM
        {


        private IPackerRepository db;


        public LotDetailVM(IPackerRepository packerRepository)
        {
            this.db = packerRepository;
        }


        public List<LotDetail> listOfLotDetails;

        public static List<LotDetail> BuildLDVM(IEnumerable<VectisPackers.mockLot> allLotDetails)
        {
            // conecting to the database
            IPackerRepository db =  new 

            List<LotDetail> vm = new List<LotDetail>();
            //tblClients to access customer details
            var ListofClients = Vdb.tblClients;

            //static parts of image url
            string urlpre = "https://images.vectis.co.uk/";
            string urlpost = "_m.jpg";

            foreach (VectisPackers.mockLot a in allLotDetails)
            {
                var item = new LotDetail();
                var thisCustomer = ListofClients.SingleOrDefault(c => c.ClientID == a.BuyerID);
                item.CustomerId = thisCustomer.ClientID;
                item.CustomerName = thisCustomer.Forename + " " + thisCustomer.Surname;
                item.LotNumber = (int)a.LotNumber;
                item.LotId = (int)a.LotID;
                item.LotDescription = a.Description;
                item.AuctionId = a.AuctionID;
                item.AuctionTitle = a.WebLotTitle;
                item.image = urlpre + a.AuctionID.ToString() + "/" + a.LotNumber.ToString() + urlpost;
                vm.Add(item);
            }

            return vm;

        }
    }
}

