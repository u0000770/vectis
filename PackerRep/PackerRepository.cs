using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using VectisPackers;

namespace PackerRep
{
    class PackerRepository: IPackerRepository, IDisposable
    {

        //private PackingEntities context;

        private myPackingEntities context;

            public PackerRepository(myPackingEntities context)
            {
                this.context = context;
            }

            public IEnumerable<PackingStaff> GetPackingStaff()
            {
                return context.PackingStaffs.Where(p => p.Active);
            }

            public IEnumerable<mockRefAuctionType> GetRefAuctionType()
            {
                return context.mockRefAuctionTypes.Where(a => a.AuctionTypeDeleted == false);
            }

        public mockClient GetClientById(int Id)
        {
            return context.mockClients.SingleOrDefault(c => c.ClientID == Id);
        }

        public MockAuction GetAuctionById(int Id)
        {
            return context.MockAuctions.Find(Id);
        }


        public mockLot GetLotById(int id)
        {
            return context.mockLots.Find(id);
        }


        // Vdb.tblLots.Where(l => l.AuctionID == Aid && l.BuyerID == Cid);

        public IEnumerable<mockLot> GetClientLotsForAuction(int AuctionID, int ClientId)
        {
            return context.mockLots.Where(l => l.AuctionID == AuctionID && l.BuyerID == ClientId);
        }


        public IEnumerable<MockAuction> GetAuctionByDateRange(DateTime fromDate,DateTime toDate)
        {
            return context.MockAuctions.Where(a => a.AuctionDate >= fromDate && a.AuctionDate <= toDate);
        }




        public PackingStaff GetPackerById(int id)
            {
                return context.PackingStaffs.Find(id);
            }

            public void InsertPackingStaff(PackingStaff packingStaff)
            {
                context.PackingStaffs.Add(packingStaff);
            }

            public void DeletePackingStaff(int id)
            {
                PackingStaff packingStaff = context.PackingStaffs.Find(id);
                context.PackingStaffs.Remove(packingStaff);
            }

            public void UpdatePackingStaff(PackingStaff packingStaff)
            {
                context.Entry(packingStaff).State = EntityState.Modified;
            }

            public void Save()
            {
                context.SaveChanges();
            }

            private bool disposed = false;

            protected virtual void Dispose(bool disposing)
            {
                if (!this.disposed)
                {
                    if (disposing)
                    {
                        context.Dispose();
                    }
                }
                this.disposed = true;
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }
    }


