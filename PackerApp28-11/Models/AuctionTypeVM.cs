using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VectisPackers;

namespace PackerApp28_11.Models
{

    /// <summary>
    /// Gets and sets the AuctionTypeId and the AuctionType
    /// </summary>
    public class AuctionTypeItem
    {
        public int id { get; set; }
        public string type { get; set; }
    }

    /// <summary>
    /// Get Lists of; AuctionTypeIds AuctionTypes and selectedAuctionTypes 
    /// (Packers specialise in one or many AuctionTypes)
    /// Get dates from - to (cutomer may have lots from one or many Auctions)
    /// Build list of AuctionTypes
    /// </summary>
    public class AuctionTypeVM
    {

        public List<int> SelectedAuctionTypeIds { get; set; }

        public List<AuctionTypeItem> listOfAuctionTypes;

        public List<AuctionTypeItem> SelectedAuctionTypes { get; set; }

        public DateTime fromDate { get; set; }

        public DateTime toDate { get; set; }
    

        public static List<int> buildSelectList(IEnumerable<mockRefAuctionType> listOfAuctionTypes)
        {
            List<int> list = new List<int>();
            foreach(var l in listOfAuctionTypes)
            {
                if(l.AuctionTypeDeleted == false)
                {
                    list.Add(l.AuctionTypeID);
                }
            }
            return list;

        }

        public static List<AuctionTypeItem> buildVM(IEnumerable<mockRefAuctionType> all)
        {
            var vm = all.Select(p => new AuctionTypeItem
            {
                id = p.AuctionTypeID,
                type = p.AuctionTypeDescription
            }

            ).AsEnumerable();

            return vm.ToList();

        }
    }
}