using PackerApp28_11.Models;
using PackerRep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VectisDB;
using VectisPackers;

namespace PackerApp28_11.Controllers
{
    public class AppController : Controller
    {

       // private PackingEntities db = new PackingEntities();
       // private TestVectis2008Entities Vdb = new TestVectis2008Entities();

        private IPackerRepository db;


        public AppController(IPackerRepository packerRepository)
        {
            this.db = packerRepository;
        }




        /// <summary>
        ///  Displays a list of pickers, list of auction types, prompts for a date range
        /// </summary>
        /// uses:db.PackingStaffs
        /// delivers:AuctionTypeVM
        /// <returns>app/index</returns>
        public ActionResult Index()
        {
            // get all packers for drop down list
            var allPackers = db.GetPackingStaff();
            ViewBag.PackerId = new SelectList(allPackers, "PackerId", "Name");


            var vm = new AuctionTypeVM();
            // get all the types out of the db
            List<mockRefAuctionType> listOfAuctionTypes = new List<mockRefAuctionType>();
            listOfAuctionTypes = db.GetRefAuctionType().ToList();
            vm.listOfAuctionTypes = new List<AuctionTypeItem>();
            vm.listOfAuctionTypes = AuctionTypeVM.buildVM(listOfAuctionTypes);
            vm.SelectedAuctionTypeIds = AuctionTypeVM.buildSelectList(listOfAuctionTypes);

            return View(vm);
        }


        /// <summary>
        /// Displays list of customers who bought something from Selected Auction Type in date range
        /// </summary>
        /// uses:TestVectis2008.tblAuctions
        /// delivers: CustomerAuctionVM
        /// <returns>app/ReadSelection</returns>
        public ActionResult ReadSelection(AuctionTypeVM vm, int PackerId)
        {
            //Get all Cutomers who bought something from Auctions held between the two input dates
            var all = db.GetAuctionByDateRange(vm.fromDate, vm.toDate);
            CustomerAuctionVM outModel = new CustomerAuctionVM();
            outModel.listOfAuctions = CustomerAuctionVM.buildVM(all);

            return View(outModel);
        }


        /// <summary>
        /// where clientId = buyerId displays customer details and customer Lots
        /// </summary>
        /// uses:TestVectis2008.tblAuctions, TestVectis2008.tblClient, TestVectis2008.tblLot
        /// delivers:CustomerAuctionLotVM
        /// <returns>PickingList</returns>
        public ActionResult PickingList(int Cid, int Aid)
        {
            var thisCustomer = db.GetClientById(Cid);
            //Get selected Customer Auction Lots 
            var lots = db.GetClientLotsForAuction(Aid, Cid);
            CustomerAuctionLotVMItem vm = new CustomerAuctionLotVMItem();
            vm.CustomerId = Cid;
            vm.CustomerName = thisCustomer.Forename + " " + thisCustomer.Surname;
            vm.AuctionDate = db.GetAuctionById(Aid).AuctionDate;
            vm.CustomerAuctionLot = CustomerAuctionLotVM.BuildLVM(lots);
 
            return View(vm);
        }


        /// <summary>
        /// displays a lot details and description
        /// </summary>
        /// uses:Vdb.tblLots
        /// delivers:LotDetailVM
        /// <returns>LotDetail</returns>
        public ActionResult LotDetail(int lotId, int lotNo, int Aid)
        {
            //get description for lots
            var descriptions = db.GetLotById(lotId);
            LotDetail LVM = new LotDetail();
            LVM.LotDetails = LotDetailVM.BuildLDVM(descriptions);
            
            return View(LVM);
        }

    }
}