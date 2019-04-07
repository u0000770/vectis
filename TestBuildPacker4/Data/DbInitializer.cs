using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBuildPacker4.Models;
using Microsoft.EntityFrameworkCore;

namespace TestBuildPacker4.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PackersContext context)
        {
            context.Database.EnsureCreated();

            // Look for any auctions.
            if (context.TblAuctions.Any())
            {
                return;   // DB has been seeded
            }

            var auction = new TblAuction[]
            {
            new TblAuction
            {
                AuctionId =699,AuctionType=1,AuctionDate=DateTime.Parse("2018-12-05"),AuctionDays=1,
                AuctionTitle ="Specialist", CatalogueComplete=false,MarkedCompleteBy="",MarkedCompleteDate=null,
                CatalogueExported =false,ExportedBy="",ExportedDate=null,CatalogueUploaded=false,UploadedBy="",
                UploadedDate =null,LettersProduced=false,LettersBy="",LettersDate=null,ViewingText="",ImageFolder="",
                CataloguePrice=null,CatalogueThumb="",SubsUpdated=false
            },
            new TblAuction
            {
                AuctionId =698,AuctionType=2,AuctionDate=DateTime.Parse("2019-01-29"),AuctionDays=1,
                AuctionTitle ="Dolls & Teds", CatalogueComplete=false,MarkedCompleteBy="",MarkedCompleteDate=null,
                CatalogueExported =false,ExportedBy="",ExportedDate=null,CatalogueUploaded=false,UploadedBy="",
                UploadedDate =null,LettersProduced=false,LettersBy="",LettersDate=null,ViewingText="",ImageFolder="",
                CataloguePrice=null,CatalogueThumb="",SubsUpdated=false
            },
            new TblAuction
            {
                AuctionId =697,AuctionType=6,AuctionDate=DateTime.Parse("2019-01-30"),AuctionDays=1,
                AuctionTitle ="TV & Film", CatalogueComplete=false,MarkedCompleteBy="",MarkedCompleteDate=null,
                CatalogueExported =false,ExportedBy="",ExportedDate=null,CatalogueUploaded=false,UploadedBy="",
                UploadedDate =null,LettersProduced=false,LettersBy="",LettersDate=null,ViewingText="",ImageFolder="",
                CataloguePrice=null,CatalogueThumb="",SubsUpdated=false
            },
            new TblAuction
            {
                AuctionId =696,AuctionType=1,AuctionDate=DateTime.Parse("20198-12-06"),AuctionDays=2,
                AuctionTitle ="Diecast", CatalogueComplete=false,MarkedCompleteBy="",MarkedCompleteDate=null,
                CatalogueExported =false,ExportedBy="",ExportedDate=null,CatalogueUploaded=false,UploadedBy="",
                UploadedDate =null,LettersProduced=false,LettersBy="",LettersDate=null,ViewingText="",ImageFolder="",
                CataloguePrice=null,CatalogueThumb="",SubsUpdated=false
            },
            new TblAuction
            {
                AuctionId =695,AuctionType=7,AuctionDate=DateTime.Parse("2018-12-13"),AuctionDays=1,
                AuctionTitle ="General", CatalogueComplete=false,MarkedCompleteBy="",MarkedCompleteDate=null,
                CatalogueExported =false,ExportedBy="",ExportedDate=null,CatalogueUploaded=false,UploadedBy="",
                UploadedDate =null,LettersProduced=false,LettersBy="",LettersDate=null,ViewingText="",ImageFolder="",
                CataloguePrice=null,CatalogueThumb="",SubsUpdated=false
            },
            new TblAuction
            {
                AuctionId =694,AuctionType=2,AuctionDate=DateTime.Parse("2018-12-14"),AuctionDays=2,
                AuctionTitle ="Trains", CatalogueComplete=false,MarkedCompleteBy="",MarkedCompleteDate=null,
                CatalogueExported =false,ExportedBy="",ExportedDate=null,CatalogueUploaded=false,UploadedBy="",
                UploadedDate =null,LettersProduced=false,LettersBy="",LettersDate=null,ViewingText="",ImageFolder="",
                CataloguePrice=null,CatalogueThumb="",SubsUpdated=false
            },
            new TblAuction
            {
                AuctionId =693,AuctionType=1,AuctionDate=DateTime.Parse("2018-12-04"),AuctionDays=1,
                AuctionTitle ="Diecast", CatalogueComplete=true,MarkedCompleteBy="",MarkedCompleteDate=null,
                CatalogueExported =true,ExportedBy="",ExportedDate=null,CatalogueUploaded=false,UploadedBy="",
                UploadedDate =null,LettersProduced=false,LettersBy="andrea.rowntree",LettersDate=DateTime.Parse("2018-11-19"),
                ViewingText ="",ImageFolder="",CataloguePrice=null,CatalogueThumb="",SubsUpdated=false
            },
            new TblAuction
            {
                AuctionId =692,AuctionType=7,AuctionDate=DateTime.Parse("2018-11-15"),AuctionDays=1,
                AuctionTitle ="General", CatalogueComplete=true,MarkedCompleteBy="",MarkedCompleteDate=null,
                CatalogueExported =true,ExportedBy="",ExportedDate=null,CatalogueUploaded=false,UploadedBy="",
                UploadedDate =null,LettersProduced=false,LettersBy="andrea.rowntree",LettersDate=DateTime.Parse("2018-11-01"),
                ViewingText ="",ImageFolder="",CataloguePrice=null,CatalogueThumb="",SubsUpdated=false
            },
            new TblAuction
            {
                AuctionId =691,AuctionType=2,AuctionDate=DateTime.Parse("2018-11-16"),AuctionDays=1,
                AuctionTitle ="Diecast", CatalogueComplete=true,MarkedCompleteBy="",MarkedCompleteDate=null,
                CatalogueExported =true,ExportedBy="",ExportedDate=null,CatalogueUploaded=false,UploadedBy="",
                UploadedDate =null,LettersProduced=false,LettersBy="pat.mcknight",LettersDate=DateTime.Parse("2018-11-19"),
                ViewingText ="",ImageFolder="",CataloguePrice=null,CatalogueThumb="",SubsUpdated=true
            },

            };
            foreach (TblAuction a in auction)
            {
                context.TblAuctions.Add(a);
            }
            context.SaveChanges();

            var auctionTypes = new TblRefAuctionType[]
            {
            new TblRefAuctionType
            {
                AuctionTypeId=1, AuctionTypeDescription="Specialist",
                AuctionTypeDeleted =false, AuctionTypeDefault=false
            },
            new TblRefAuctionType
            {
                AuctionTypeId=2, AuctionTypeDescription="Train",
                AuctionTypeDeleted =false, AuctionTypeDefault=false
            },
            new TblRefAuctionType
            {
                AuctionTypeId=3, AuctionTypeDescription="Doll & Teddy",
                AuctionTypeDeleted =false, AuctionTypeDefault=false
            },
            new TblRefAuctionType
            {
                AuctionTypeId=4, AuctionTypeDescription="Lead",
                AuctionTypeDeleted =false, AuctionTypeDefault=false
            },
            new TblRefAuctionType
            {
                AuctionTypeId=5, AuctionTypeDescription="TinPlate",
                AuctionTypeDeleted =false, AuctionTypeDefault=false
            },
            new TblRefAuctionType
            {
                AuctionTypeId=6, AuctionTypeDescription="TV & Film",
                AuctionTypeDeleted =false, AuctionTypeDefault=false
            },
            new TblRefAuctionType
            {
                AuctionTypeId=7, AuctionTypeDescription="General",
                AuctionTypeDeleted =false, AuctionTypeDefault=false
            },

            };
            foreach (TblRefAuctionType at in auctionTypes)
            {
                context.TblRefAuctionTypes.Add(at);
            }
            context.SaveChanges();

            var catAux = new TblCatAux[]
            {
            new TblCatAux
            {
                CatAuxId=6882, CatAuxAuctionId=691, CatAuxTitle="Trix MD",CatAuxDesc="",
                CatAuxCreateDate=DateTime.Parse("2018-10-15 00:00:00.000"), CatAuxWho=10,
                CatAuxImported=true, CatAuxRemoved=false
            },
            new TblCatAux
            {
                CatAuxId=6883, CatAuxAuctionId=691, CatAuxTitle="Narrow Gauge MD",CatAuxDesc="",
                CatAuxCreateDate=DateTime.Parse("2018-10-15 00:00:00.000"), CatAuxWho=10,
                CatAuxImported=true, CatAuxRemoved=false
            },
            new TblCatAux
            {
                CatAuxId=6884, CatAuxAuctionId=691, CatAuxTitle="3-rail MD",CatAuxDesc="",
                CatAuxCreateDate=DateTime.Parse("2018-10-15 00:00:00.000"), CatAuxWho=10,
                CatAuxImported=true, CatAuxRemoved=false
            },
            new TblCatAux
            {
                CatAuxId=6885, CatAuxAuctionId=691, CatAuxTitle="Books MD",CatAuxDesc="",
                CatAuxCreateDate=DateTime.Parse("2018-10-15 00:00:00.000"), CatAuxWho=10,
                CatAuxImported=true, CatAuxRemoved=false
            },
            new TblCatAux
            {
                CatAuxId=6886, CatAuxAuctionId=691, CatAuxTitle="No8",CatAuxDesc="",
                CatAuxCreateDate=DateTime.Parse("2018-10-16 00:00:00.000"), CatAuxWho=10,
                CatAuxImported=true, CatAuxRemoved=false
            },
            new TblCatAux
            {
                CatAuxId=6887, CatAuxAuctionId=691, CatAuxTitle="Lot3548",CatAuxDesc="",
                CatAuxCreateDate=DateTime.Parse("2018-10-17 00:00:00.000"), CatAuxWho=58,
                CatAuxImported=true, CatAuxRemoved=false
            },
            new TblCatAux
            {
                CatAuxId=6912, CatAuxAuctionId=691, CatAuxTitle="Hornby Dublo 3-rail",CatAuxDesc="",
                CatAuxCreateDate=DateTime.Parse("2018-11-01 00:00:00.000"), CatAuxWho=10,
                CatAuxImported=true, CatAuxRemoved=false
            },
            new TblCatAux
            {
                CatAuxId=6913, CatAuxAuctionId=691, CatAuxTitle="2-rail",CatAuxDesc="",
                CatAuxCreateDate=DateTime.Parse("2018-11-01 00:00:00.000"), CatAuxWho=10,
                CatAuxImported=true, CatAuxRemoved=false
            },

            };
            foreach (TblCatAux c in catAux)
            {
                context.TblCatAuxs.Add(c);
            }
            context.SaveChanges();

            var catSections = new TblCatSection[]
           {
            new TblCatSection
            {
                CatSectionId=10256,Heading="The South Coast Collection OO Gauge",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
            new TblCatSection
            {
                CatSectionId=10275,Heading="OO Gauge The Coventry Collection",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
            new TblCatSection
            {
                CatSectionId=127,Heading="Meccano & Other Constructional Toys",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
            new TblCatSection
            {
                CatSectionId=143,Heading="Gauge 1 & Larger",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
            new TblCatSection
            {
                CatSectionId=155,Heading="Live Steam",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
            new TblCatSection
            {
                CatSectionId=198,Heading="General Trains",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
            new TblCatSection
            {
                CatSectionId=523,Heading="Books, Magazines, Catalogues etc",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
            new TblCatSection
            {
                CatSectionId=1348,Heading="Books, Magazines, Catalogues etc",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
            new TblCatSection
            {
                CatSectionId=3352,Heading="Further O Gauge",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
            new TblCatSection
            {
                CatSectionId=3424,Heading="Narrow Gauge",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
            new TblCatSection
            {
                CatSectionId=3697,Heading="Modern O Gauge",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
             new TblCatSection
            {
                CatSectionId=5484,Heading="Hornby Dublo 3-rail",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
             new TblCatSection
            {
                CatSectionId=5836,Heading="Hornby O Gauge",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
              new TblCatSection
            {
                CatSectionId=5933,Heading="Hornby Dublo 2-rail",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
              new TblCatSection
            {
                CatSectionId=10129,Heading="HO USA & Continental Outline",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
              new TblCatSection
            {
                CatSectionId=10257,Heading="The Chris Broos Lifetime Collection - Part 7",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
                new TblCatSection
            {
                CatSectionId=10258,Heading="The Chris Broos Lifetime Collection - Part 7",
                SubHeading1 ="Wagons & Freight Cars", SubHeading2="",AdditionalComments=""
            },
                new TblCatSection
            {
                CatSectionId=10259,Heading="The Chris Broos Lifetime Collection - Part 7",
                SubHeading1 ="Kits & Accessories", SubHeading2="",AdditionalComments=""
            },
                new TblCatSection
            {
                CatSectionId=10261,Heading="The Chris Broos Lifetime Collection - Part 7",
                SubHeading1 ="Locomotives", SubHeading2="",AdditionalComments=""
            },
                new TblCatSection
            {
                CatSectionId=10265,Heading="Static O Gauge Models",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },
                new TblCatSection
            {
                CatSectionId=10266,Heading="Scratch & Kitbuilt O Gauge",
                SubHeading1 ="", SubHeading2="",AdditionalComments=""
            },

           };
            foreach (TblCatSection cs in catSections)
            {
                context.TblCatSections.Add(cs);
            }
            context.SaveChanges();

            var collections = new TblCollection[]
            {
            new TblCollection
            {
                CollectionId=528376, ClientId=120228, DateReceived=DateTime.Parse("2018-08-21 10:23:03.800"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="Collection picked up by SJ and taken to Witney. Hornby - Hornby Railways and " +
                "other manufacturers '00' gauge. Locos 280, Coaches 200, Wagons 280.", CommisionRateId=0,
                CommisionRate=(0.1500m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
            new TblCollection
            {
                CollectionId=528399, ClientId=55993, DateReceived=DateTime.Parse("2018-08-23 15:12:13.917"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="Lima H0 & 00 Locos & Rolling stock. Taken in by MB.", CommisionRateId=0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
            new TblCollection
            {
                CollectionId=528374, ClientId=120226, DateReceived=DateTime.Parse("2018-08-21 09:42:51.413"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="train items sent", CommisionRateId=0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0200m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
             new TblCollection
            {
                CollectionId=528495, ClientId=81364, DateReceived=DateTime.Parse("2018-09-17 10:52:03.213"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="5 boxes of general toys and models plus a Hornby Train set as emailed list taken in at " +
                "Sandown", CommisionRateId=0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
              new TblCollection
            {
                CollectionId=528419, ClientId=85967, DateReceived=DateTime.Parse("2018-08-28 10:34:40.723"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="Cllection taken in at Witney by MD;- 1) Diecast, 2) Mainline '00' gauge, 3) Peco Track, 4) " +
                "Action Force Loose figiures ( some preproduction)", CommisionRateId=0,
                CommisionRate=(0.1250m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528519, ClientId=120888, DateReceived=DateTime.Parse("2018-09-17 16:40:44.127"),
                ForAuction="our next available appropriate sale",Comments="Please note a pick up charge of £50.00 will be deducted " +
                "from your vendor invoice.",
                InhouseComments ="Collection picked up by SJ and taken back to Witney;-  Bachman/Hornby/Hornby Dublo 108 Loco's, " +
                "112 Coaches, 234 Wagons mostly boxed. Quantity of unboxed buses, 22 banana boxes plus empty boxes. named collection ' " +
                "The Coventry Collection '", CommisionRateId=0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528544, ClientId=119790, DateReceived=DateTime.Parse("2018-09-25 09:37:27.633"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="Collection taken in at Witney by MD;- Lego Railway sets, track, controllers (unboxed) in 8 boxes. " +
                "6 Trays of Continental/American H0 Gauge. Qty empty loco rolling stock boxes, Qty boxed loco's rolling, stock. " +
                "G gauge - LGB boxed set; starter kit loose rolling stock", CommisionRateId=0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528480, ClientId=41895, DateReceived=DateTime.Parse("2018-09-13 11:22:12.460"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="1 box of meccano etc sent in", CommisionRateId=0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528294, ClientId=119594, DateReceived=DateTime.Parse("2018-07-23 09:30:51.543"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="Large collection picked up by SJ and taken back to Witney - 1) Hornby '0' gauge. 2) " +
                "Hornby Dublo pre - post war. 3) Diecast models.", CommisionRateId=0,
                CommisionRate=(0.1500m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528516, ClientId=120885, DateReceived=DateTime.Parse("2018-09-17 16:14:46.467"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="Collection taken in at Witney by MD ;- 1) Hornby Dublo - 4 boxes. 2) " +
                "Meccano - 1 box. 3) Dinky Toys - 1 box, playworn.", CommisionRateId=0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0200m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=527620, ClientId=14280, DateReceived=DateTime.Parse("2018-02-09 09:12:18.000"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="Collection of Lead and Trains Packed by RH, SC, JB & VW in Holland and " +
                "transported back via courier on 16/2/18", CommisionRateId=0,
                CommisionRate=(0.0840m),InsuranceRate=(0.0000m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528548, ClientId=121059, DateReceived=DateTime.Parse("2018-09-25 10:50:48.183"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="Collection taken in by MD at Witney ;- 1) Meccano, 1 box, 2 motors. 2) " +
                "Hornby '0' gauge, post war (see list)", CommisionRateId=0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528283, ClientId=119408, DateReceived=DateTime.Parse("2018-07-18 15:50:56.000"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="Collection of Diecast and Trains as per list and CD taken in by AR", CommisionRateId=0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0000m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528267, ClientId=118977, DateReceived=DateTime.Parse("2018-07-13 14:05:06.103"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="1 box of Dinky Military, 1 Box of Bayko, 1 box of assorted Commercials taken in by " +
                "AR", CommisionRateId=0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0200m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528398, ClientId=120295, DateReceived=DateTime.Parse("2018-08-23 14:49:29.570"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="Large Wooden box containing Meccano & Meccano Leaflets. Box of Dinky see list",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0200m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528403, ClientId=120298, DateReceived=DateTime.Parse("2018-08-23 16:19:51.630"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="4 boxes of Trains, Meccano, Tinplate, Dinky, Printing Press plus others taken " +
                "in by MC",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528354, ClientId=117847, DateReceived=DateTime.Parse("2018-08-13 12:15:22.000"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="silvercross pram, 1 x box hornbydublo 3 rail track & control boxes, 1 x box meccano," +
                " 1 x box hornby dublo loco, rolling stock,  acc's 1 x box mixed unboxed diecast ",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0200m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528488, ClientId=3177, DateReceived=DateTime.Parse("2018-09-17 10:10:36.687"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="train items taken to sandown",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528398, ClientId=120295, DateReceived=DateTime.Parse("2018-08-23 14:49:29.570"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="Large Wooden box containing Meccano & Meccano Leaflets. Box of Dinky see list",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0200m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528393, ClientId=108762, DateReceived=DateTime.Parse("2018-08-23 11:21:38.503"),
                ForAuction="our next available appropriate sale",Comments="Please note a pick up charge of £50.00 " +
                "will be deducted from your vendor invoice.",
                InhouseComments ="Large Collection of Hornby '0' gauge picked up by SJ and taken to Witney.",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0000m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528215, ClientId=3624, DateReceived=DateTime.Parse("2018-06-27 13:16:23.453"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="Quantity of Hornby '0' gauge",
                CommisionRateId =0,
                CommisionRate=(0.1000m),InsuranceRate=(0.0000m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528606, ClientId=4937, DateReceived=DateTime.Parse("2018-10-05 13:05:04.043"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="Collection received by MD at Witney ;-  3 1/2 inch gauge 4-4-2 Alantic," +
                " G1 Rocket boxed damaged tender, box '00 gauge triang etc.. Buglife Bug  & talking Alien " +
                "boxed, framed Railway cigarette cards,.",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528600, ClientId=121301, DateReceived=DateTime.Parse("2018-10-05 13:05:04.043"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="Collection taken in by MD at Witney ;- 1) Hornby '0' gauge, E220 LMS tank, " +
                "T20 Transformer. 2) 2 x Boxes '00' gauge train sets. 3) 1 x box MOY.",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528579, ClientId=48890, DateReceived=DateTime.Parse("2018-10-02 13:09:46.763"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="mixed quantity misc toys, diecast and action figures. taken by IM",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=527353, ClientId=6589, DateReceived=DateTime.Parse("2017-11-13 11:09:07.677"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="taken in at Sandown, dolls/teddies, diecast, Lead as per list",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528115, ClientId=26473, DateReceived=DateTime.Parse("2018-06-01 15:47:33.833"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="'O' Gauge collection, trains, coches,wagons, building and accessories " +
                "etc... collected by RH",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528446, ClientId=30035, DateReceived=DateTime.Parse("2018-09-04 14:14:33.027"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="kits and train items sent in ",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0200m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528417, ClientId=120397, DateReceived=DateTime.Parse("2018-08-28 10:14:01.100"),
                ForAuction="our next available appropriate sale",Comments="",
                InhouseComments ="Collection picked up by SJ and taken to Witney ;- 2 x finescale locos in " +
                "presentation cases ",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528530, ClientId=120925, DateReceived=DateTime.Parse("2018-09-19 13:40:23.160"),
                ForAuction="our next available appropriate sale",Comments="A collection charge of £50 will be deducted " +
                "from the proceeds of your sale.",
                InhouseComments ="collection of trains and lead picked up by Richie ",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528606, ClientId=4937, DateReceived=DateTime.Parse("2018-10-05 13:05:04.043"),
                ForAuction="",
                InhouseComments ="Collection received by MD at Witney ;-  3 1/2 inch gauge 4-4-2 Alantic," +
                " G1 Rocket boxed damaged tender, box '00 gauge triang etc.. Buglife Bug  & talking Alien " +
                "boxed, framed Railway cigarette cards,.",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528120, ClientId=2603, DateReceived=DateTime.Parse("2018-06-04 09:21:45.383"),
                ForAuction="",
                InhouseComments ="Small collection found at Witney, the vendor is unknown, photos of the items are " +
                "in the 'Booking In' electronic file. Includes:- wooden half built kit boats, Medallion 'M' series Radio" +
                " controlled hand set, Matchbox Peterbuilt 1:43 plastic kit in box, small box of lead animals and figures," +
                " including some railway items, Instructions for a Mamod Locomotive Radio Control Kit and a tin of " +
                "cigarette cards, see photos",
                CommisionRateId =0,
                CommisionRate=(0.0000m),InsuranceRate=(0.0000m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528489, ClientId=120870, DateReceived=DateTime.Parse("2018-09-17 10:14:32.380"),
                ForAuction="",
                InhouseComments ="train diecast and general items taken to sandown",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528367, ClientId=120200, DateReceived=DateTime.Parse("2018-08-20 12:11:34.277"),
                ForAuction="",
                InhouseComments ="train related items sent in one small box",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0200m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528367, ClientId=120200, DateReceived=DateTime.Parse("2018-08-20 12:11:34.277"),
                ForAuction="",
                InhouseComments ="train related items sent in one small box",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0200m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528341, ClientId=119889, DateReceived=DateTime.Parse("2018-08-07 15:48:46.517"),
                ForAuction="",
                InhouseComments ="'00' gauge locomotives, rolling stock various manufacturers including kits, " +
                "track points & motors, tken in by MB",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0000m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },
                new TblCollection
            {
                CollectionId=528426, ClientId=61410, DateReceived=DateTime.Parse("2018-08-29 15:24:59.070"),
                ForAuction="",
                InhouseComments ="Train collection as per list including Wrenn, H/D, Hornby Lima. taken in by Andrea",
                CommisionRateId =0,
                CommisionRate=(0.1750m),InsuranceRate=(0.0100m),MiscCost=(0.0000m),StoragePoint="",LogBookNumber=0,
                ReceiptPrinted=null,LetterPrinted=null,UnsoldItemCharge=(0.0000m),MinimumVendorCommision=(0.0000m),
                CatalogueCharge=(0.0000m)
            },

            };
            foreach (TblCollection tc in collections)
            {
                context.TblCollections.Add(tc);
            }
            context.SaveChanges();

            var paddles = new TblPaddle[]
           {
            new TblPaddle
            {
                PaddleId=8459,AuctionId=691, DayNo=1, ClientId=2046, PaddleNo=3, PaddleType=1,
                AccountSettled =false,
                Lots = "3260,3261,3262,3263,3264,3265,3266,3269,3270,3271,3272,3274,3275,3281,3359,3392,3396,3403,3404",
                Deleted=false
            },
            new TblPaddle
            {
                PaddleId=8462,AuctionId=691, DayNo=1, ClientId=3217, PaddleNo=4, PaddleType=1,
                AccountSettled =false,
                Lots = "3511,",
                Deleted=false
            },
            new TblPaddle
            {
                PaddleId=8467,AuctionId=691, DayNo=1, ClientId=23452, PaddleNo=51, PaddleType=0,
                AccountSettled =false,
                Lots = "null",
                Deleted=false
            },
            new TblPaddle
            {
                PaddleId=8473,AuctionId=691, DayNo=1, ClientId=108000, PaddleNo=5, PaddleType=1,
                AccountSettled =false,
                Lots = "3041,3057,3081,3147,",
                Deleted=false
            },
            new TblPaddle
            {
                PaddleId=8474,AuctionId=691, DayNo=1, ClientId=11994, PaddleNo=6, PaddleType=1,
                AccountSettled =false,
                Lots = "3322,3323,3324,3325,3326,",
                Deleted=false
            },
             new TblPaddle
            {
                PaddleId=8475,AuctionId=691, DayNo=1, ClientId=109916, PaddleNo=7, PaddleType=1,
                AccountSettled =false,
                Lots = "3029,3081,3088,3089,3189,3190,3191,3192,3193,3215,",
                Deleted=false
            },
              new TblPaddle
            {
                PaddleId=8476,AuctionId=691, DayNo=1, ClientId=8459, PaddleNo=8, PaddleType=1,
                AccountSettled =false,
                Lots = "3257,3261,3262,3263,3264,3265,3266,3270,3271,3272,3273,3274,3275,3278," +
                "3279,3280,3349,3353,3355,3356,3369,3377,3380,3382,3387,3388,3389,3390,3425,3426," +
                "3518,3519,3546,3548,3558,3561,",
                Deleted=false
            },
              new TblPaddle
            {
                PaddleId=8478,AuctionId=691, DayNo=1, ClientId=4219, PaddleNo=9, PaddleType=1,
                AccountSettled =false,
                Lots = "3255,3256,3257,3258,3259,3260,3261,3262,3263,3264,3265,3266,3267,3268,3269," +
                "3270,3271,3272,3273,3274,3275,3276,3277,3278,3279,3280,3281,3282,3283,3284,3285," +
                "3286,3333,3334,3366,3367,3368,3385,3386,3387,3388,3389,3390,",
                Deleted=false
            },
              new TblPaddle
            {
                PaddleId=8479,AuctionId=691, DayNo=1, ClientId=86964, PaddleNo=10, PaddleType=1,
                AccountSettled =false,
                Lots = "3002,3004,3044,3055,3057,3059,3067,3064,3077,3087,3090,3102,3108,3110,3127,3148," +
                "3149,3151,3175,3181,3213,",
                Deleted=false
            },
               new TblPaddle
            {
                PaddleId=8481,AuctionId=691, DayNo=1, ClientId=3624, PaddleNo=11, PaddleType=1,
                AccountSettled =false,
                Lots = "3462,3502,3504,3515,",
                Deleted=false
            },
               new TblPaddle
            {
                PaddleId=8482,AuctionId=691, DayNo=1, ClientId=61410, PaddleNo=12, PaddleType=1,
                AccountSettled =false,
                Lots = "3513,3515,",
                Deleted=false
            },
               new TblPaddle
            {
                PaddleId=8483,AuctionId=691, DayNo=1, ClientId=17972, PaddleNo=13, PaddleType=1,
                AccountSettled =false,
                Lots = "3518,",
                Deleted=false
            },

           };
            foreach (TblPaddle p in paddles)
            {
                context.TblPaddles.Add(p);
            }
            context.SaveChanges();

            var bids = new TblBid[]
            {
            new TblBid
            {
                BidId=856722,AuctionId= 691,LotId=738911,BuyerId= 122043,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(90.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856740,AuctionId= 691,LotId=739855,BuyerId= 103996,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(100.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856907,AuctionId= 691,LotId=740730,BuyerId= 38284,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(160.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856909,AuctionId= 691,LotId=738419, BuyerId= 38284,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(120.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856910,AuctionId= 691,LotId=738467, BuyerId= 38284,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(70.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856911,AuctionId= 691,LotId=738538, BuyerId= 38284,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(160.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856913,AuctionId= 691,LotId=739183, BuyerId= 38284,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(150.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856914,AuctionId= 691,LotId=739184, BuyerId= 38284,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(120.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856915,AuctionId= 691,LotId=739199, BuyerId= 38284,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(100.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress=null
            },
            new TblBid
            {
                BidId=856916,AuctionId= 691,LotId=739204, BuyerId= 38284,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(160.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress=null
            },
            new TblBid
            {
                BidId=856917,AuctionId= 691,LotId=739222, BuyerId= 38284,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(160.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress=null
            },
            new TblBid
            {
                BidId=856918,AuctionId= 691,LotId=739239, BuyerId= 38284,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(120.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress=null
            },
            new TblBid
            {
                BidId=856930,AuctionId= 691,LotId=739788, BuyerId= 95429,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(60.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856938,AuctionId= 691,LotId=740127, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(110.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856944,AuctionId= 691,LotId=740189, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(90.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856959,AuctionId= 691,LotId=740425, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(80.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856960,AuctionId= 691,LotId=740428, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(120.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856961,AuctionId= 691,LotId=740431, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(100.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856962,AuctionId= 691,LotId=740461, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(160.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856963,AuctionId= 691,LotId=740434, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(100.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856964,AuctionId= 691,LotId=740462, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(100.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856965,AuctionId= 691,LotId=740463, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(140.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856966,AuctionId= 691,LotId=740464, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(110.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856967,AuctionId= 691,LotId=740465, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(130.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856968,AuctionId= 691,LotId=740466, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(110.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856969,AuctionId= 691,LotId=740467, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(110.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856971,AuctionId= 691,LotId=740469, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(110.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856972,AuctionId= 691,LotId=740472, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(110.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856973,AuctionId= 691,LotId=740474, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(90.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856974,AuctionId= 691,LotId=740475, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(90.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856976,AuctionId= 691,LotId=740477, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(90.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856980,AuctionId= 691,LotId=740479, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(100.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856983,AuctionId= 691,LotId=740493, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(200.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856984,AuctionId= 691,LotId=740495, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(190.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856986,AuctionId= 691,LotId=740624, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(90.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=856987,AuctionId= 691,LotId=740662, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(120.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=857043,AuctionId= 691,LotId=741831, BuyerId= 71275,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(100.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=857340,AuctionId= 691,LotId=739797, BuyerId= 115473,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(70.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=857348,AuctionId= 691,LotId=739856, BuyerId= 115473,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(100.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=857350,AuctionId= 691,LotId=740130, BuyerId= 115473,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(90.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=857368,AuctionId= 691,LotId=740562, BuyerId= 113406,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(220.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=857398,AuctionId= 691,LotId=739803, BuyerId= 33133,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(180.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=857399,AuctionId= 691,LotId=739839, BuyerId= 113951,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(130.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=857400,AuctionId= 691,LotId=739853, BuyerId= 113951,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(110.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=857401,AuctionId= 691,LotId=740413, BuyerId= 113951,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(150.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=857403,AuctionId= 691,LotId=739037, BuyerId= 3790,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(220.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress=null
            },
            new TblBid
            {
                BidId=857404,AuctionId= 691,LotId=740199, BuyerId= 122073,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(260.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=857412,AuctionId= 691,LotId=738366, BuyerId= 8902,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(150.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=857422,AuctionId= 691,LotId=741743, BuyerId= 19319,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(130.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=857423,AuctionId= 691,LotId=741758, BuyerId= 19319,
                BidDate=DateTime.Parse("2018-11-06 21:23:13.657"),BidValue=(90.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=862137,AuctionId= 691,LotId=738912, BuyerId= 122043,
                BidDate=DateTime.Parse("2018-11-16 06:44:22.673"),BidValue=(120.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            new TblBid
            {
                BidId=855777,AuctionId= 691,LotId=741830, BuyerId= 103996,
                BidDate=DateTime.Parse("2018-11-05 21:23:21.810"),BidValue=(20.0000m),CommisionBid=true,
                Deleted=false,DeletedReason="",Active=true,Winning=true,BidIpaddress="217.160.107.24"
            },
            };
            foreach (TblBid b in bids)
            {
                context.TblBids.Add(b);
            }
            context.SaveChanges();

            var lots = new TblLot[]
            {
            new TblLot
            {
                LotId=738911, AuctionId= auction.Single( a => a.AuctionId == 691).AuctionId,
                CatAuxId=null,ImportedToMain=true,DayNo=null,
                CatSectionId = 5836,
                LotNumber=3482,Description="Hornby O Gauge group of Goods Wagons consisting of Petrol " +
                "Tankers 'Power Ethyl', 'Pratts', 'Motor Spirit' and 'Shell' Tankers together with a " +
                "'Meccano' Coal Wagon. Fair to Good Plus.  (4)",
                Reserve=(0.00m),BottomPrice=(80.00m),TopPrice=(120.00m),StartingPrice=(90.00m),
                CollectionId=528393, BuyerId=122043, HammerPrice=(90.0000m), WinningBuyer=122043, NextBuyer=null,
                AbsMinPrice=(0.0000m), DateLastAmended=DateTime.Parse("2018-10-15 10:15:40.040"),
                LastAmendedWho ="Pat McKnight", ParentLotId=0,
                SaleType=2, Checked=true, UnsoldRef="",BuyerPaddleId=0, BuyerPaddleNo=0, WinningBid=(90.0000m),
                NextBid= (0.0000m), VectisCode="",BuyerInvoiceId=489103, VendorInvoiceId=737183,
                Withdrawn=false, BidEnteredWhileBookOpen=true,
                WebLotTitle ="Hornby O Gauge group of Goods Wagons consisting of Petrol Tankers",
                Keywords="Meccano,Hornby"
            },
            new TblLot
            {
                LotId=738912, AuctionId= auction.Single( a => a.AuctionId == 691).AuctionId,
                CatAuxId=null,ImportedToMain=true,DayNo=null,
                CatSectionId = 5836,
                LotNumber=3483,Description="Hornby O Gauge group of Goods Wagons consisting of 'United Dairies' " +
                "Milk Tanker, 'Colas' Bitumen Tanker, 'Hornby Railway Company' Coal Wagon. All have been expertly " +
                "repainted, lined and transferred together with an overpainted Private Owner Van 'Palethorpes' " +
                "Sausage Van.  (4)",
                Reserve=(0.00m),BottomPrice=(100.0000m),TopPrice=(150.0000m),StartingPrice=(120.0000m),
                CollectionId=528393, BuyerId=117379, HammerPrice=(130.0000m), WinningBuyer=122043, NextBuyer=null,
                AbsMinPrice=(0.0000m), DateLastAmended=DateTime.Parse("2018-10-15 10:15:40.040"),
                LastAmendedWho ="Pat McKnight", ParentLotId=0,
                SaleType=2, Checked=true, UnsoldRef="",BuyerPaddleId=0, BuyerPaddleNo=0, WinningBid=(120.0000m),
                NextBid= (110.0000m), VectisCode="",BuyerInvoiceId=489118, VendorInvoiceId=737184,
                Withdrawn=false, BidEnteredWhileBookOpen=true,
                WebLotTitle ="Hornby O Gauge group of Goods Wagons consisting of",
                Keywords="Meccano,Hornby"
            },
            new TblLot
            {
                LotId=739855, AuctionId= auction.Single( a => a.AuctionId == 691).AuctionId,
                CatAuxId=null,ImportedToMain=true,DayNo=null,
                CatSectionId = 10256, LotNumber=3085,
                Description="Hornby (China) LNER 4-6-2 Steam Locos comprising R2338 NE Wartime black " +
                "livery A4 Class 4901 'Sir Charles Newton', R2405 Apple green livery A1 Class 1470 " +
                "'Great Northern' conditions are Mint and still tissue wrapped in Mint and Excellent Plus " +
                "boxes respectively with both having pictured outer sleeves.  (2)",
                Reserve=(0.00m),BottomPrice=(100.0000m),TopPrice=(140.0000m),StartingPrice=(100.0000m),
                CollectionId=528376, BuyerId=23452, HammerPrice=(110.0000m), WinningBuyer=103996, NextBuyer=115473,
                AbsMinPrice=(0.0000m), DateLastAmended=DateTime.Parse("2018-10-19 16:02:15.110"),
                LastAmendedWho ="Pat McKnight", ParentLotId=0,
                SaleType=3, Checked=true, UnsoldRef="",BuyerPaddleId=8467,BuyerPaddleNo=51, WinningBid=(100.0000m),
                NextBid= (100.0000m), VectisCode="",BuyerInvoiceId=0, VendorInvoiceId=736990,
                Withdrawn=false, BidEnteredWhileBookOpen=true,
                WebLotTitle ="Hornby",
                Keywords="Hornby"
            },
            new TblLot
            {
                LotId=740730, AuctionId= auction.Single( a => a.AuctionId == 691).AuctionId,
                CatAuxId=null,ImportedToMain=true,DayNo=null,
                CatSectionId = 198, LotNumber=3576,
                Description="Hornby/Bachmann and other commercial manufacturers OO Gauge Passenger Rolling " +
                "Stock and empty boxes a large quantity consisting of Southern x 10, LMS/BR maroon x 15 and " +
                "14 others together with an incomplete R2032 The Midlothian Train Pack limited edition with " +
                "a 4-6-2 Loco and Tender A4 Class 'Guillemot' BR green 60020, missing coaches with certificate" +
                " 1100 of 3000 produced. Included with this lot are a quantity of varying manufacturers empty " +
                "boxes for locomotives, coaches and rolling stock. Condition varies throughout from fair to " +
                "Excellent.  (lg qty)",
                Reserve=(0.00m),BottomPrice=(100.0000m),TopPrice=(150.0000m),StartingPrice=(160.0000m),
                CollectionId=528519, BuyerId=19734, HammerPrice=(170.0000m), WinningBuyer=38284, NextBuyer=31132,
                AbsMinPrice=(0.0000m), DateLastAmended=DateTime.Parse("2018-10-26 14:36:20.933"),
                LastAmendedWho ="Pat McKnight", ParentLotId=0,
                SaleType=5, Checked=true, UnsoldRef="",BuyerPaddleId=0,BuyerPaddleNo=2, WinningBid=(160.0000m),
                NextBid= (150.0000m), VectisCode="",BuyerInvoiceId=489284, VendorInvoiceId=736894,
                Withdrawn=false, BidEnteredWhileBookOpen=true,
                WebLotTitle ="Hornby/Bachmann and other commercial manufacturers OO Gauge Passenger",
                Keywords="Bachmann,Hornby"
            },
            new TblLot
            {
                LotId=738419, AuctionId= auction.Single( a => a.AuctionId == 691).AuctionId,
                CatAuxId=null,ImportedToMain=true,DayNo=null,
                CatSectionId = 10257, LotNumber=3356,
                Description="Fulgurex O Gauge Wagons-Lits Grand European Express blue and cream Baggage " +
                "Car 1263M. One of a limited production of 80 produced in 1991 by Elettren. Some " +
                "deterioration to transfers on coach sides otherwise Good Plus.",
                Reserve=(0.00m),BottomPrice=(60.0000m),TopPrice=(90.0000m),StartingPrice=(100.0000m),
                CollectionId=527620, BuyerId=8459, HammerPrice=(170.0000m), WinningBuyer=38284, NextBuyer=71275,
                AbsMinPrice=(0.0000m), DateLastAmended=DateTime.Parse("2018-10-11 13:24:42.017"),
                LastAmendedWho ="Pat McKnight", ParentLotId=0,
                SaleType=2, Checked=true, UnsoldRef="",BuyerPaddleId=0,BuyerPaddleNo=0, WinningBid=(120.0000m),
                NextBid= (90.0000m), VectisCode="",BuyerInvoiceId=489312, VendorInvoiceId=737271,
                Withdrawn=false, BidEnteredWhileBookOpen=true,
                WebLotTitle ="Fulgurex O Gauge Wagons-Lits Grand European Express blue and",
                Keywords=""
            },
            new TblLot
            {
                LotId=738467, AuctionId= auction.Single( a => a.AuctionId == 691).AuctionId,
                CatAuxId=null,ImportedToMain=true,DayNo=null,
                CatSectionId = 10258, LotNumber=3398,
                Description="Polar Maxi and modified group of O Gauge Continental Goods Wagons consisting " +
                "of DR (B) Prost DB Beer Wagon together with 3 x DR Flat Cars and a DR Lidded Wagon. Condition " +
                "varies generally Good to Good Plus.  (5)",
                Reserve=(0.00m),BottomPrice=(50.0000m),TopPrice=(80.0000m),StartingPrice=(70.0000m),
                CollectionId=527620, BuyerId=77567, HammerPrice=(110.0000m), WinningBuyer=38284, NextBuyer=31132,
                AbsMinPrice=(0.0000m), DateLastAmended=DateTime.Parse("2018-10-18 13:28:24.263"),
                LastAmendedWho ="Pat McKnight", ParentLotId=0,
                SaleType=1, Checked=true, UnsoldRef="",BuyerPaddleId=0,BuyerPaddleNo=1, WinningBid=(70.0000m),
                NextBid= (60.0000m), VectisCode="",BuyerInvoiceId=489489, VendorInvoiceId=737313,
                Withdrawn=false, BidEnteredWhileBookOpen=true,
                WebLotTitle ="Polar Maxi and modified group of O Gauge Continental Goods Wagons",
                Keywords=""
            },
            new TblLot
            {
                LotId=738538, AuctionId= auction.Single( a => a.AuctionId == 691).AuctionId,
                CatAuxId=null,ImportedToMain=true,DayNo=null,
                CatSectionId = 10259, LotNumber=3413,
                Description="Atlas O Gauge quantity of 2-rail points and accessories consisting of " +
                "7024/25 right and left hand point, 7070 Wye turnout, 792 single track Pratts Truss " +
                "Bridge Kit, Near Mint in Excellent boxes together with part boxed 7021 left hand " +
                "points x 2 and 7025 right hand point x 1. Excellent in box bases.  (7)",
                Reserve=(0.00m),BottomPrice=(100.0000m),TopPrice=(140.0000m),StartingPrice=(140.0000m),
                CollectionId=527620, BuyerId=26963, HammerPrice=(170.0000m), WinningBuyer=38284, NextBuyer=null,
                AbsMinPrice=(0.0000m), DateLastAmended=DateTime.Parse("2018-10-11 16:16:34.220"),
                LastAmendedWho ="Pat McKnight", ParentLotId=0,
                SaleType=5, Checked=true, UnsoldRef="",BuyerPaddleId=0,BuyerPaddleNo=2, WinningBid=(160.0000m),
                NextBid= null, VectisCode="",BuyerInvoiceId=489246, VendorInvoiceId=737328,
                Withdrawn=false, BidEnteredWhileBookOpen=true,
                WebLotTitle ="Atlas O Gauge quantity of 2-rail points and accessories consisting",
                Keywords=""
            },
            new TblLot
            {
                LotId=739183, AuctionId= auction.Single( a => a.AuctionId == 691).AuctionId,
                CatAuxId=null,ImportedToMain=true,DayNo=null,
                CatSectionId = 10266, LotNumber=3531,
                Description="Acorn O Gauge group of etched brass kits including BR2 Tender, BR10 Tender, " +
                "GE and BR1 together with 9F Loco castings, set of Slaters wheels and 9F etched brass kit" +
                " with wheels. All kits unchecked, generally Good Plus to Excellent.  (6)",
                Reserve=(0.00m),BottomPrice=(80.0000m),TopPrice=(120.0000m),StartingPrice=(130.0000m),
                CollectionId=528530, BuyerId=71275, HammerPrice=(160.0000m), WinningBuyer=38284, NextBuyer=null,
                AbsMinPrice=(0.0000m), DateLastAmended=DateTime.Parse("2018-10-16 09:49:35.193"),
                LastAmendedWho ="Pat McKnight", ParentLotId=0,
                SaleType=5, Checked=true, UnsoldRef="",BuyerPaddleId=0,BuyerPaddleNo=2, WinningBid=(160.0000m),
                NextBid= null, VectisCode="",BuyerInvoiceId=489191, VendorInvoiceId=736816,
                Withdrawn=false, BidEnteredWhileBookOpen=true,
                WebLotTitle ="Acorn O Gauge group of etched brass kits",
                Keywords=""
            },
            new TblLot
            {
                LotId=739184, AuctionId= auction.Single( a => a.AuctionId == 691).AuctionId,
                CatAuxId=null,ImportedToMain=true,DayNo=null,
                CatSectionId = 10266, LotNumber=3532,
                Description="Acorn/College Models and other commercial manufacturers O Gauge etched brass " +
                "kits including a Ivatt 4F, Stanier 2-6-4, both with tenders and a small quantity of others. " +
                "Kits are loose and unchecked, generally Good Plus to Excellent.  (qty)",
                Reserve=(0.00m),BottomPrice=(60.0000m),TopPrice=(80.0000m),StartingPrice=(100.0000m),
                CollectionId=528530, BuyerId=86168, HammerPrice=(130.0000m), WinningBuyer=38284, NextBuyer=null,
                AbsMinPrice=(0.0000m), DateLastAmended=DateTime.Parse("2018-10-16 10:45:02.293"),
                LastAmendedWho ="Pat McKnight", ParentLotId=0,
                SaleType=5, Checked=true, UnsoldRef="",BuyerPaddleId=0,BuyerPaddleNo=2, WinningBid=(120.0000m),
                NextBid= null, VectisCode="",BuyerInvoiceId=489162, VendorInvoiceId=736817,
                Withdrawn=false, BidEnteredWhileBookOpen=true,
                WebLotTitle ="Acorn/College Models and other commercial manufacturers O Gauge",
                Keywords=""
            },
            new TblLot
            {
                LotId=739199, AuctionId= auction.Single( a => a.AuctionId == 691).AuctionId,
                CatAuxId=null,ImportedToMain=true,DayNo=null,
                CatSectionId = 10266, LotNumber=3537,
                Description="Shed Master and other commercial manufactures O Gauge group of Locomotive Kits " +
                "consisting of Ref LK216 Stanier 2-6-0 Loco and Tender, BR Standard Class 5 4-6-0 Caprotti " +
                "valve gear, Lorry Griffin Queen Mary Express Bogie Brake Van Kit. Unchecked for completeness, " +
                "contents Excellent.  (3)",
                Reserve=(0.00m),BottomPrice=(60.0000m),TopPrice=(90.0000m),StartingPrice=(80.0000m),
                CollectionId=528530, BuyerId=86168, HammerPrice=(130.0000m), WinningBuyer=38284, NextBuyer=null,
                AbsMinPrice=(0.0000m), DateLastAmended=DateTime.Parse("2018-10-16 10:00:18.673"),
                LastAmendedWho ="Pat McKnight", ParentLotId=0,
                SaleType=5, Checked=true, UnsoldRef="",BuyerPaddleId=0,BuyerPaddleNo=2, WinningBid=(100.0000m),
                NextBid= null, VectisCode="",BuyerInvoiceId=489163, VendorInvoiceId=736822,
                Withdrawn=false, BidEnteredWhileBookOpen=true,
                WebLotTitle ="Shed Master and other commercial manufactures O Gauge group of",
                Keywords=""
            },
            new TblLot
            {
                LotId=739204, AuctionId= auction.Single( a => a.AuctionId == 691).AuctionId,
                CatAuxId=null,ImportedToMain=true,DayNo=null,
                CatSectionId = 10266, LotNumber=3538,
                Description="Unknown make mixed group of O Gauge Locomotive Kits and part built kits, " +
                "motors and associated items including a part built M7, Britannia or similar, unbuilt " +
                "Midland Spinner, black 5 and others all in need of some work, parts unchecked. " +
                "Included with this lot are a quantity of motors. Condition varies throughout from " +
                "Fair to Good, an ideal lot for the O Gauge modeller.  (qty)",
                Reserve=(0.00m),BottomPrice=(100.0000m),TopPrice=(200.0000m),StartingPrice=(120.0000m),
                CollectionId=528530, BuyerId=54571, HammerPrice=(170.0000m), WinningBuyer=38284, NextBuyer=31132,
                AbsMinPrice=(0.0000m), DateLastAmended=DateTime.Parse("2018-10-16 10:21:40.563"),
                LastAmendedWho ="Pat McKnight", ParentLotId=0,
                SaleType=5, Checked=true, UnsoldRef="",BuyerPaddleId=0,BuyerPaddleNo=2, WinningBid=(160.0000m),
                NextBid= (80.0000m), VectisCode="",BuyerInvoiceId=489207, VendorInvoiceId=736823,
                Withdrawn=false, BidEnteredWhileBookOpen=true,
                WebLotTitle ="Unknown make mixed group of O Gauge Locomotive Kits and part",
                Keywords=""
            },
            new TblLot
            {
                LotId=739222, AuctionId= auction.Single( a => a.AuctionId == 691).AuctionId,
                CatAuxId=null,ImportedToMain=true,DayNo=null,
                CatSectionId = 10266, LotNumber=3544,
                Description="Unknown make O Gauge part built kits including a 0-6-0 Loco and Tender LMS " +
                "black 3795, 2-rail electric, body for a 4F or similar in black with LMS lettered tender, " +
                "part built 4-6-0 Loco chassis with other parts, together with an incomplete Stanier high " +
                "sided tender and other items. An ideal lot for the O Gauge model railway builder, " +
                "Fair to Good.  (6)",
                Reserve=(0.00m),BottomPrice=(60.0000m),TopPrice=(90.0000m),StartingPrice=(160.0000m),
                CollectionId=528530, BuyerId=31132, HammerPrice=(170.0000m), WinningBuyer=38284, NextBuyer=31132,
                AbsMinPrice=(0.0000m), DateLastAmended=DateTime.Parse("2018-10-16 10:21:20.900"),
                LastAmendedWho ="Pat McKnight", ParentLotId=0,
                SaleType=5, Checked=true, UnsoldRef="",BuyerPaddleId=0,BuyerPaddleNo=2, WinningBid=(160.0000m),
                NextBid= (150.0000m), VectisCode="",BuyerInvoiceId=489239, VendorInvoiceId=736829,
                Withdrawn=false, BidEnteredWhileBookOpen=true,
                WebLotTitle ="Unknown make O Gauge part built kits",
                Keywords=""
            },
            new TblLot
            {
                LotId=739239, AuctionId= auction.Single( a => a.AuctionId == 691).AuctionId,
                CatAuxId=null,ImportedToMain=true,DayNo=null,
                CatSectionId = 10266, LotNumber=3549,
                Description="Mixed group of Locomotive and Coach and other O Gauge Kits consisting " +
                "of a 4A 4-6-2 Stanier Tank Loco, body only, LNER Class A 242 Locomotive Kit, 2 x " +
                "Coach Kits and a quantity of other items. All unchecked, an ideal lot for the O " +
                "Gauge modeller, Fair to Good Plus.  (qty)",
                Reserve=(0.00m),BottomPrice=(80.0000m),TopPrice=(120.0000m),StartingPrice=(100.0000m),
                CollectionId=528530, BuyerId=86168, HammerPrice=(130.0000m), WinningBuyer=38284, NextBuyer=54224,
                AbsMinPrice=(0.0000m), DateLastAmended=DateTime.Parse("2018-10-16 10:49:13.363"),
                LastAmendedWho ="Pat McKnight", ParentLotId=0,
                SaleType=5, Checked=true, UnsoldRef="",BuyerPaddleId=0,BuyerPaddleNo=2, WinningBid=(120.0000m),
                NextBid= (70.0000m), VectisCode="",BuyerInvoiceId=489164, VendorInvoiceId=736834,
                Withdrawn=false, BidEnteredWhileBookOpen=true,
                WebLotTitle ="Mixed group of Locomotive and Coach and other O Gauge Kits consisting",
                Keywords=""
            },
            new TblLot
            {
                LotId=739788, AuctionId= auction.Single( a => a.AuctionId == 691).AuctionId,
                CatAuxId=null,ImportedToMain=true,DayNo=null,
                CatSectionId = 10256, LotNumber=3041,
                Description="Hornby (China) R2215 4-6-2 LMS crimson Princess Royal Class 6201 " +
                "'Princess Elizabeth' complete with certificate 2063, this is a special edition " +
                "with all metal parts gold plated to commemorate The Queen's Golden Jubilee, condition" +
                " Mint in Near Mint to Mint box and complete with special presentation box, length of " +
                "rail and information band.",
                Reserve=(0.00m),BottomPrice=(80.0000m),TopPrice=(120.0000m),StartingPrice=(60.0000m),
                CollectionId=528376, BuyerId=108000, HammerPrice=(80.0000m), WinningBuyer=95429, NextBuyer=null,
                AbsMinPrice=(0.0000m), DateLastAmended=DateTime.Parse("2018-10-16 10:49:13.363"),
                LastAmendedWho ="Pat McKnight", ParentLotId=0,
                SaleType=2, Checked=true, UnsoldRef="",BuyerPaddleId=0,BuyerPaddleNo=0, WinningBid=(60.0000m),
                NextBid= null, VectisCode="",BuyerInvoiceId=489417, VendorInvoiceId=736946,
                Withdrawn=false, BidEnteredWhileBookOpen=true,
                WebLotTitle ="Hornby",
                Keywords="Hornby"
            },
            new TblLot
            {
                LotId=741830, AuctionId= auction.Single( a => a.AuctionId == 691).AuctionId,
                CatAuxId=null,ImportedToMain=true,DayNo=null,
                CatSectionId = 198, LotNumber=3579,
                Description="Hornby Railways R357 4-6-0 LMS crimson Patriot Class 5541 'Duke of Sutherland', " +
                "condition Good Plus to Excellent in Fair to Good box.",
                Reserve=(0.00m),BottomPrice=(30.0000m),TopPrice=(50.0000m),StartingPrice=(20.0000m),
                CollectionId=528489, BuyerId=23452, HammerPrice=(25.0000m), WinningBuyer=103996, NextBuyer=115555,
                AbsMinPrice=(0.0000m), DateLastAmended=DateTime.Parse("2018-11-02 10:30:45.543"),
                LastAmendedWho ="Pat McKnight", ParentLotId=0,
                SaleType=3, Checked=true, UnsoldRef="",BuyerPaddleId=8467,BuyerPaddleNo=51, WinningBid=(20.0000m),
                NextBid= (20.0000m), VectisCode="",BuyerInvoiceId=0, VendorInvoiceId=736899,
                Withdrawn=false, BidEnteredWhileBookOpen=true,
                WebLotTitle ="Hornby Railways R357 4-6-0 LMS crimson Patriot Class 5541",
                Keywords="Hornby"
            },


            };
            foreach (TblLot l in lots)
            {
                context.TblLots.Add(l);
            }
            context.SaveChanges();

            var buyer = new TblSaleBuyer[]
            {
            new TblSaleBuyer
            {
                BuyerInvoiceId=489103, InvoiceNumberId=184152, BuyerId=122043,
                BoughtDate =DateTime.Parse("2018-11-16 15:41:29.333"), HammerPrice=(90.0000m),
                CommissionRate=(0.2083m), VatRate=(0.2000m), Commission=(18.7470m), ComVat=(3.7494m),
                TotalPrice=(112.4964m), InvoicePrinted=false, InvoicePrintDate=null, SaleType=2,
                LotNumber=3482, AuctionId=691, DateAmended=DateTime.Parse("2018-11-16 15:41:29.333"),
                DateCreated=DateTime.Parse("2018-11-16 15:41:29.333"), AmendedWho=null
            },
            new TblSaleBuyer
            {
                BuyerInvoiceId=489104, InvoiceNumberId=184152, BuyerId=122043,
                BoughtDate =DateTime.Parse("2018-11-16 15:41:29.333"), HammerPrice=(60.0000m),
                CommissionRate=(0.2083m), VatRate=(0.2000m), Commission=(12.4980m), ComVat=(2.4996m),
                TotalPrice=(74.9976m), InvoicePrinted=false, InvoicePrintDate=null, SaleType=5,
                LotNumber=3477, AuctionId=691, DateAmended=DateTime.Parse("2018-11-16 15:41:29.333"),
                DateCreated=DateTime.Parse("2018-11-16 15:41:29.333"), AmendedWho=null
            },
            new TblSaleBuyer
            {
                BuyerInvoiceId=489105, InvoiceNumberId=184152, BuyerId=122043,
                BoughtDate =DateTime.Parse("2018-11-16 15:41:29.333"), HammerPrice=(60.0000m),
                CommissionRate=(0.2083m), VatRate=(0.2000m), Commission=(12.4980m), ComVat=(2.4996m),
                TotalPrice=(74.9976m), InvoicePrinted=false, InvoicePrintDate=null, SaleType=5,
                LotNumber=3480, AuctionId=691, DateAmended=DateTime.Parse("2018-11-16 15:41:29.333"),
                DateCreated=DateTime.Parse("2018-11-16 15:41:29.333"), AmendedWho=null
            },
            };
            foreach (TblSaleBuyer sb in buyer)
            {
                context.TblSaleBuyers.Add(sb);
            }
            context.SaveChanges();

            var saleInvoices = new TblSaleInvoice[]
            {
            new TblSaleInvoice
            {
                SaleInvoiceId=184152, InvoiceNumber="VTS192261",ClientId=122043, AuctionId=691, DayNo=1,
                InvoiceType="B", TotalItems=3, TotalPrice=(274.4916m),Cctype=3, Ccno="************9126",
                CcholderName="Peter Horst Faulstr", Ccexpiry="0120",Ccstart=null, CcsecurityNo=null,
                CcissueNo=null, Ccamount=(262.4916m), Postage=(10.0000m),PostVat=(2.0000m),DespatchDate=null,
                DespatchNumber=null,DespatchService=null,CreditCharge=(0.0000m),
                FileName="\\HAM-APPS'\'InfoComp_L'\'Data'\'Vectis2008'\'Invoices'\'16_11_2018 - Trains- Day 1'\'Buyers'\'VTS192261.pdf",
                DateGenerated=DateTime.Parse("2018-11-16 15:41:29.330"),DateAmended=DateTime.Parse("2018-11-26 14:42:35.500"),
                DateEmailed=null, DatePrinted=DateTime.Parse("2018-11-26 14:42:57.937"),IsHammerPaid=true,IsFeesPaid=true,
                CreditCardChargeRate=(0.0000m),PostageCccharge=(0.0000m),HammerPayment=(262.4916m), CreditChargeOn=(262.4916m),
                IsOnlineSaleIncluded=false
            },

            };
            foreach (TblSaleInvoice si in saleInvoices)
            {
                context.TblSaleInvoices.Add(si);
            }
            context.SaveChanges();
			
			  var Client = new TblClient[]
            {
            new TblClient
            {
                ClientID=122043, TitleID=null, Forename=Peter, Surname=Faulstroh, PrimaryAddID=132536, DeliveryAddID=132537, BillingAddID=132538   ,TelephoneOther=null,
				TelephoneMobile=07437430349, Email=pfaulstroh@hotmail.com, Fax=null, Comments=null, FreeCatalogue-0, SageBuyerID=null, SageVendorID=null,
				OnlineVectisID=null, OnlineEbayID=null, ContactEmail=1, ContactPost=0, contactTelephone=0, ContactSMS=0, DefaultCommBuyer=20.8300,
				DefaultCommVendor=17.5000, DefaultVatRate=1, UsePrimaryForBilling=1, UsePrimaryForDelivery=1, Deleted=0, Sendnewsletter=1, BidLiveChecked=1,
				BidProxyChecked=1
            },
			 new TblClient
            {
                ClientID=117379, TitleID=null, Forename=Stephen, Surname=Foster, PrimaryAddID=128515, DeliveryAddID=128516, BillingAddID=128517, TelephoneOther=01386871239,
				TelephoneMobile=07768415609, Email=sfoster@harvington.org, Fax=null, Comments=POSTAGE COST BTF, FreeCatalogue-0, SageBuyerID=null, SageVendorID=null,
				OnlineVectisID=null, OnlineEbayID=null, ContactEmail=0, ContactPost=0, contactTelephone=0, ContactSMS=0, DefaultCommBuyer=20.8300,
				DefaultCommVendor=17.5000, DefaultVatRate=1, UsePrimaryForBilling=1, UsePrimaryForDelivery=1, Deleted=0, Sendnewsletter=1, BidLiveChecked=1,
				BidProxyChecked=1
            },
			 new TblClient
            {
                ClientID=23452, TitleID=null, Forename=null, Surname=Room Bidder, PrimaryAddID=23455, DeliveryAddID=0, BillingAddID=0, TelephoneOther=null,
				TelephoneMobile=null, Email=null, Fax=null, Comments=null, FreeCatalogue-0, SageBuyerID=null, SageVendorID=null,
				OnlineVectisID=null, OnlineEbayID=null, ContactEmail=0, ContactPost=0, contactTelephone=0, ContactSMS=0, DefaultCommBuyer=20.8300,
				DefaultCommVendor=17.5000, DefaultVatRate=1, UsePrimaryForBilling=1, UsePrimaryForDelivery=1, Deleted=0, Sendnewsletter=1, BidLiveChecked=1,
				BidProxyChecked=1
            },
			 new TblClient
            {
               ClientID=19734, TitleID=Mr, Forename=james alistair, Surname=Crampton, PrimaryAddID=19734, DeliveryAddID=0, BillingAddID=0, TelephoneOther=01912577410,
				TelephoneMobile=null, Email=jac@jacmac.eclipse.co.uk, Fax=null, Comments=null, FreeCatalogue-0, SageBuyerID=null, SageVendorID=null,
				OnlineVectisID=null, OnlineEbayID=null, ContactEmail=0, ContactPost=0, contactTelephone=0, ContactSMS=0, DefaultCommBuyer=20.8300,
				DefaultCommVendor=17.5000, DefaultVatRate=1, UsePrimaryForBilling=1, UsePrimaryForDelivery=1, Deleted=0, Sendnewsletter=1, BidLiveChecked=1,
				BidProxyChecked=1
            },
			 new TblClient
            {
              ClientID=8459, TitleID=Mr, Forename=G, Surname=Poulter, PrimaryAddID=8459, DeliveryAddID=0, BillingAddID=0, TelephoneOther=01912577410,
				TelephoneMobile=null, Email=alisonpoulter@btinternet.com, Fax=null, Comments=null, FreeCatalogue-0, SageBuyerID=null, SageVendorID=null,
				OnlineVectisID=null, OnlineEbayID=null, ContactEmail=0, ContactPost=0, contactTelephone=0, ContactSMS=0, DefaultCommBuyer=20.8300,
				DefaultCommVendor=17.5000, DefaultVatRate=1, UsePrimaryForBilling=1, UsePrimaryForDelivery=1, Deleted=0, Sendnewsletter=0, BidLiveChecked=1,
				BidProxyChecked=1  
            },
			 new TblClient
            {
               ClientID=77567, TitleID=null, Forename=Ellis, Surname=Clark, PrimaryAddID=83415, DeliveryAddID=125244, BillingAddID=125245, TelephoneOther=01274809317,
				TelephoneMobile=07799554491, Email=ellis@ellisclarktrains.com, Fax=null, Comments=TO COLLECT, FreeCatalogue-0, SageBuyerID=null, SageVendorID=null,
				OnlineVectisID=null, OnlineEbayID=null, ContactEmail=1, ContactPost=0, contactTelephone=0, ContactSMS=0, DefaultCommBuyer=20.8300,
				DefaultCommVendor=17.5000, DefaultVatRate=1, UsePrimaryForBilling=1, UsePrimaryForDelivery=1, Deleted=0, Sendnewsletter=0, BidLiveChecked=1,
				BidProxyChecked=1
            },
			 new TblClient
            {
                ClientID=86168, TitleID=Christopher, Forename=Ellis, Surname=Handforth, PrimaryAddID=93134, DeliveryAddID=0, BillingAddID=0, TelephoneOther=01977689774,
				TelephoneMobile=null, Email=para4man@gmx.co.uk, Fax=null, Comments=TO COLLECT, FreeCatalogue-0, SageBuyerID=null, SageVendorID=null,
				OnlineVectisID=null, OnlineEbayID=null, ContactEmail=1, ContactPost=0, contactTelephone=0, ContactSMS=0, DefaultCommBuyer=20.8300,
				DefaultCommVendor=17.5000, DefaultVatRate=1, UsePrimaryForBilling=1, UsePrimaryForDelivery=1, Deleted=0, Sendnewsletter=1, BidLiveChecked=1,
				BidProxyChecked=1
            },

            };
            foreach (TblClient c in Client)
            {
           /    context.TblClient.Add(c);
            }
            //context.SaveChanges();

            //var saleVendors = new TblSaleVendor[]
            //{
            //new TblSaleVendor
            //{
                
            //},

            //};
            //foreach (TblSaleVendor sv in saleVendors)
            //{
            //    context.TblSaleVendor.Add(sv);
            //}
            //context.SaveChanges();



        }
    }
}
