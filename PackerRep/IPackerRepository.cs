using System;
using System.Collections.Generic;
using VectisPackers;

namespace PackerRep
{
    public interface IPackerRepository : IDisposable
    {
        IEnumerable<PackingStaff> GetPackingStaff();

        IEnumerable<mockRefAuctionType> GetRefAuctionType();

        IEnumerable<MockAuction> GetAuctionByDateRange(DateTime fromDate, DateTime toDate);

        IEnumerable<mockLot> GetClientLotsForAuction(int AuctionID, int ClientId);

        MockAuction GetAuctionById(int Id);
        mockClient GetClientById(int Id);
        PackingStaff GetPackerById(int id);

        mockLot GetLotById(int id);
        void InsertPackingStaff(PackingStaff packingStaff);
        void DeletePackingStaff(int id);
        void UpdatePackingStaff(PackingStaff packingStaff);
        void Save();
    }

}
