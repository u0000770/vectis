using TestBuildPacker4.Models;
using Microsoft.EntityFrameworkCore;

namespace TestBuildPacker4.Data
{
    public class PackersContext : DbContext
 
    {
        public PackersContext(DbContextOptions<PackersContext> options) : base(options)
        {
        }

        public DbSet<TblAuction> TblAuctions { get; set; }
        public DbSet<TblBid> TblBids { get; set; }
        public DbSet<TblCatAux> TblCatAuxs { get; set; }
        public DbSet<TblCatSection> TblCatSections { get; set; }
        public DbSet<TblClient> TblClients { get; set; }
        public DbSet<TblCollection> TblCollections { get; set; }
        public DbSet<TblLot> TblLots { get; set; }
        public DbSet<TblPaddle> TblPaddles { get; set; }
        public DbSet<TblPayment> TblPayments { get; set; }
        public DbSet<TblRefAuctionType> TblRefAuctionTypes { get; set; }
        public DbSet<TblRefVatRates> TblRefVatRatess { get; set; }
        public DbSet<TblSaleBuyer> TblSaleBuyers { get; set; }
        public DbSet<TblSaleInvoice> TblSaleInvoices { get; set; }
        public DbSet<TblSaleVendor> TblSaleVendors { get; set; }
        public DbSet<WebsiteSubscription> WebsiteSubscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAuction>().ToTable("TblAuction");
            modelBuilder.Entity<TblBid>().ToTable("TblBid");
            modelBuilder.Entity<TblCatAux>().ToTable("TblCatAux");
            modelBuilder.Entity<TblCatSection>().ToTable("TblCatSection");
            modelBuilder.Entity<TblClient>().ToTable("TblClient");
            modelBuilder.Entity<TblCollection>().ToTable("TblCollection");
            modelBuilder.Entity<TblLot>().ToTable("TblLot");
            modelBuilder.Entity<TblPaddle>().ToTable("TblPaddle");
            modelBuilder.Entity<TblPayment>().ToTable("TblPayment");
            modelBuilder.Entity<TblRefAuctionType>().ToTable("TblRefAuctionType");
            modelBuilder.Entity<TblRefVatRates>().ToTable("TblRefVatRates");
            modelBuilder.Entity<TblSaleBuyer>().ToTable("TblSaleBuyer");
            modelBuilder.Entity<TblSaleInvoice>().ToTable("TblSaleInvoice");
            modelBuilder.Entity<TblSaleVendor>().ToTable("TblSaleVendor");
            modelBuilder.Entity<WebsiteSubscription>().ToTable("WebsiteSubscription");
        }

    }
}
