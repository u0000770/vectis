﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VectisDB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TestVectis2008Entities : DbContext
    {
        public TestVectis2008Entities()
            : base("name=TestVectis2008Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<EmailAccount> EmailAccounts { get; set; }
        public virtual DbSet<LotKeyword> LotKeywords { get; set; }
        public virtual DbSet<MessageTemplate> MessageTemplates { get; set; }
        public virtual DbSet<QNRGroup> QNRGroups { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }
        public virtual DbSet<QuestionOption> QuestionOptions { get; set; }
        public virtual DbSet<Response> Responses { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<SagePayPayment> SagePayPayments { get; set; }
        public virtual DbSet<SagePayToken> SagePayTokens { get; set; }
        public virtual DbSet<StateProvince> StateProvinces { get; set; }
        public virtual DbSet<tblActivityLog> tblActivityLogs { get; set; }
        public virtual DbSet<tblAddress> tblAddresses { get; set; }
        public virtual DbSet<tblAuction> tblAuctions { get; set; }
        public virtual DbSet<tblAuctionDay> tblAuctionDays { get; set; }
        public virtual DbSet<tblAudit> tblAudits { get; set; }
        public virtual DbSet<tblBid> tblBids { get; set; }
        public virtual DbSet<tblCatAux> tblCatAuxes { get; set; }
        public virtual DbSet<tblCatSection> tblCatSections { get; set; }
        public virtual DbSet<tblClient> tblClients { get; set; }
        public virtual DbSet<tblCollection> tblCollections { get; set; }
        public virtual DbSet<tblConfigSettingsDev> tblConfigSettingsDevs { get; set; }
        public virtual DbSet<tblDataFeed> tblDataFeeds { get; set; }
        public virtual DbSet<tblEmail_Alerts> tblEmail_Alerts { get; set; }
        public virtual DbSet<tbllAuctionView> tbllAuctionViews { get; set; }
        public virtual DbSet<tblLot> tblLots { get; set; }
        public virtual DbSet<tblNewsletterClient> tblNewsletterClients { get; set; }
        public virtual DbSet<tblPaddle> tblPaddles { get; set; }
        public virtual DbSet<tblPayment> tblPayments { get; set; }
        public virtual DbSet<tblRefAuctionType> tblRefAuctionTypes { get; set; }
        public virtual DbSet<tblRefCatalogueType> tblRefCatalogueTypes { get; set; }
        public virtual DbSet<tblRefCategoryType> tblRefCategoryTypes { get; set; }
        public virtual DbSet<tblRefCollectionType> tblRefCollectionTypes { get; set; }
        public virtual DbSet<tblRefCommissionRate> tblRefCommissionRates { get; set; }
        public virtual DbSet<tblRefCreditCardType> tblRefCreditCardTypes { get; set; }
        public virtual DbSet<tblRefSaleType> tblRefSaleTypes { get; set; }
        public virtual DbSet<tblRefTitle> tblRefTitles { get; set; }
        public virtual DbSet<tblRefVatRate> tblRefVatRates { get; set; }
        public virtual DbSet<tblReportInfo> tblReportInfoes { get; set; }
        public virtual DbSet<tblSaleBuyer> tblSaleBuyers { get; set; }
        public virtual DbSet<tblSaleInvoice> tblSaleInvoices { get; set; }
        public virtual DbSet<tblSaleVendor> tblSaleVendors { get; set; }
        public virtual DbSet<tblSayuFeedAuction> tblSayuFeedAuctions { get; set; }
        public virtual DbSet<tblSayuFeedBid> tblSayuFeedBids { get; set; }
        public virtual DbSet<tblSayuFeedCode> tblSayuFeedCodes { get; set; }
        public virtual DbSet<tblSayuFeedUser> tblSayuFeedUsers { get; set; }
        public virtual DbSet<tblSession> tblSessions { get; set; }
        public virtual DbSet<tblWebsiteSubscriptionRate> tblWebsiteSubscriptionRates { get; set; }
        public virtual DbSet<web_tblCurrency> web_tblCurrency { get; set; }
        public virtual DbSet<web_tblMessage> web_tblMessage { get; set; }
        public virtual DbSet<web_tblWebUsers> web_tblWebUsers { get; set; }
        public virtual DbSet<WebsiteSubscription> WebsiteSubscriptions { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<tblAuctionDayRange> tblAuctionDayRanges { get; set; }
        public virtual DbSet<tblClientCategory> tblClientCategories { get; set; }
        public virtual DbSet<tblCollectionType> tblCollectionTypes { get; set; }
        public virtual DbSet<tblConfigSetting> tblConfigSettings { get; set; }
        public virtual DbSet<tblLotBid> tblLotBids { get; set; }
        public virtual DbSet<tblRefBidIncrement> tblRefBidIncrements { get; set; }
        public virtual DbSet<tblRefDayRange> tblRefDayRanges { get; set; }
        public virtual DbSet<tblSecFunction> tblSecFunctions { get; set; }
        public virtual DbSet<tblSecGroup> tblSecGroups { get; set; }
        public virtual DbSet<tblSecGroupFunction> tblSecGroupFunctions { get; set; }
        public virtual DbSet<tblSecUserFunction> tblSecUserFunctions { get; set; }
        public virtual DbSet<tblSecUser> tblSecUsers { get; set; }
        public virtual DbSet<tblSubscription> tblSubscriptions { get; set; }
        public virtual DbSet<tblTelephoneLotInterest> tblTelephoneLotInterests { get; set; }
        public virtual DbSet<web_tblClientSession> web_tblClientSession { get; set; }
    }
}
