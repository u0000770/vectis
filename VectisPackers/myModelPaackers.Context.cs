﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VectisPackers
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class myPackingEntities : DbContext
    {
        public myPackingEntities()
            : base("name=myPackingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<mockAddress> mockAddresses { get; set; }
        public virtual DbSet<MockAuction> MockAuctions { get; set; }
        public virtual DbSet<mockClient> mockClients { get; set; }
        public virtual DbSet<mockRefAuctionType> mockRefAuctionTypes { get; set; }
        public virtual DbSet<PackingStaff> PackingStaffs { get; set; }
        public virtual DbSet<mockLot> mockLots { get; set; }
    }
}
