using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VectisDB;
using VectisPackers;

namespace PackerApp28_11.Models
{

    public class CustomerAuctionLotVMItem
    {
        public int CustomerId { get; set; }
        [Display(Name = "Customer Name") ]
        public string CustomerName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Auction Date")]
        public DateTime AuctionDate { get; set; }      
        public List<ListofLotsVM> CustomerAuctionLot { get; set; }
               
    }

    public class ListofLotsVM
    {
        public int AuctionId { get; set; }
        public string AuctionTitle { get; set; }
        public int AuctionLotId { get; set; }
        public int AuctionLotNumber { get; set; }
        
    }

    /// <summary>
    /// get all lots bought by a customer at an Auction(s) add to list
    /// </summary>
    /// uses:VectisDB.tblLot
    public class CustomerAuctionLotVM
    {
        public List<ListofLotsVM> listOfAuctionLots;

        public static List<ListofLotsVM> BuildLVM(IEnumerable<VectisPackers.mockLot> allLots)
        {
            //get all customer lots, add to new list (listofClientAuctionLots)
            List<ListofLotsVM> listofClientAuctionLots = new List<ListofLotsVM>();
            foreach (VectisPackers.mockLot a in allLots)
            {
                var item = new ListofLotsVM();
                item.AuctionLotNumber = (int)a.LotNumber;
                item.AuctionLotId = (int)a.LotID;
                item.AuctionId = a.AuctionID;
                item.AuctionTitle = a.WebLotTitle;
                listofClientAuctionLots.Add(item);
            }

            return listofClientAuctionLots;

        }

    }
}