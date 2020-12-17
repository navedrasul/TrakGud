using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TrakGud.DAL.Models;

#nullable disable

namespace TrakGud.DAL.Repos
{
    public partial class TGEContext : DbContext
    {
        public TGEContext()
        {
        }

        public TGEContext(DbContextOptions<TGEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CmAddress> CmAddresses { get; set; }
        public virtual DbSet<CmAddressContactField> CmAddressContactFields { get; set; }
        public virtual DbSet<CmCity> CmCities { get; set; }
        public virtual DbSet<CmCompanyInfo> CmCompanyInfos { get; set; }
        public virtual DbSet<CmContact> CmContacts { get; set; }
        public virtual DbSet<CmContactConnection> CmContactConnections { get; set; }
        public virtual DbSet<CmContactField> CmContactFields { get; set; }
        public virtual DbSet<CmContactFieldType> CmContactFieldTypes { get; set; }
        public virtual DbSet<CmContactMerger> CmContactMergers { get; set; }
        public virtual DbSet<CmContactType> CmContactTypes { get; set; }
        public virtual DbSet<CmContinent> CmContinents { get; set; }
        public virtual DbSet<CmCountry> CmCountries { get; set; }
        public virtual DbSet<CmCountryContinent> CmCountryContinents { get; set; }
        public virtual DbSet<CmEmail> CmEmails { get; set; }
        public virtual DbSet<CmFax> CmFaxes { get; set; }
        public virtual DbSet<CmLocationInfo> CmLocationInfos { get; set; }
        public virtual DbSet<CmNote> CmNotes { get; set; }
        public virtual DbSet<CmPersonalInfo> CmPersonalInfos { get; set; }
        public virtual DbSet<CmPhone> CmPhones { get; set; }
        public virtual DbSet<CmProfessionalInfo> CmProfessionalInfos { get; set; }
        public virtual DbSet<CmRegion> CmRegions { get; set; }
        public virtual DbSet<CmStateProvince> CmStateProvinces { get; set; }
        public virtual DbSet<DBuyer> DBuyers { get; set; }
        public virtual DbSet<DBuyerType> DBuyerTypes { get; set; }
        public virtual DbSet<DComment> DComments { get; set; }
        public virtual DbSet<DCommentsThread> DCommentsThreads { get; set; }
        public virtual DbSet<DItem> DItems { get; set; }
        public virtual DbSet<DItemBatch> DItemBatches { get; set; }
        public virtual DbSet<DItemBatchAgr> DItemBatchAgrs { get; set; }
        public virtual DbSet<DItemBatchSourceType> DItemBatchSourceTypes { get; set; }
        public virtual DbSet<DItemBatchType> DItemBatchTypes { get; set; }
        public virtual DbSet<DItemItemBatch> DItemItemBatches { get; set; }
        public virtual DbSet<DItemRemovalHistory> DItemRemovalHistories { get; set; }
        public virtual DbSet<DProduct> DProducts { get; set; }
        public virtual DbSet<DProductCategory> DProductCategories { get; set; }
        public virtual DbSet<DProductStock> DProductStocks { get; set; }
        public virtual DbSet<DProductUnit> DProductUnits { get; set; }
        public virtual DbSet<DProductUnitConvertion> DProductUnitConvertions { get; set; }
        public virtual DbSet<DProductWarehouseStock> DProductWarehouseStocks { get; set; }
        public virtual DbSet<DReceivedItemBatch> DReceivedItemBatches { get; set; }
        public virtual DbSet<DRelativeCountryType> DRelativeCountryTypes { get; set; }
        public virtual DbSet<DRelativeStateProvType> DRelativeStateProvTypes { get; set; }
        public virtual DbSet<DRemovedItemBatch> DRemovedItemBatches { get; set; }
        public virtual DbSet<DSeller> DSellers { get; set; }
        public virtual DbSet<DSellerType> DSellerTypes { get; set; }
        public virtual DbSet<DStoredItemBatch> DStoredItemBatches { get; set; }
        public virtual DbSet<DWarehouse> DWarehouses { get; set; }
        public virtual DbSet<FimBank> FimBanks { get; set; }
        public virtual DbSet<FimBankBranch> FimBankBranches { get; set; }
        public virtual DbSet<FimBankBranchPoc> FimBankBranchPocs { get; set; }
        public virtual DbSet<FimCashPayment> FimCashPayments { get; set; }
        public virtual DbSet<FimCheque> FimCheques { get; set; }
        public virtual DbSet<FimChequePayment> FimChequePayments { get; set; }
        public virtual DbSet<FimCreditPayment> FimCreditPayments { get; set; }
        public virtual DbSet<FimCurrency> FimCurrencies { get; set; }
        public virtual DbSet<FimPayment> FimPayments { get; set; }
        public virtual DbSet<FimPaymentAmount> FimPaymentAmounts { get; set; }
        public virtual DbSet<FimPaymentPart> FimPaymentParts { get; set; }
        public virtual DbSet<FimPaymentPartType> FimPaymentPartTypes { get; set; }
        public virtual DbSet<FimPaymentType> FimPaymentTypes { get; set; }
        public virtual DbSet<FimTransaction> FimTransactions { get; set; }
        public virtual DbSet<FimTransactionAmount> FimTransactionAmounts { get; set; }
        public virtual DbSet<FimTransactionItem> FimTransactionItems { get; set; }
        public virtual DbSet<FimTransactionItemAgr> FimTransactionItemAgrs { get; set; }
        public virtual DbSet<FimTransactionType> FimTransactionTypes { get; set; }
        public virtual DbSet<FmVehicle> FmVehicles { get; set; }
        public virtual DbSet<FmVehicleCapacity> FmVehicleCapacities { get; set; }
        public virtual DbSet<FmVehicleCapacityUnit> FmVehicleCapacityUnits { get; set; }
        public virtual DbSet<FmVehicleCapacityUnitConvertion> FmVehicleCapacityUnitConvertions { get; set; }
        public virtual DbSet<FmVehicleCapacityUnitType> FmVehicleCapacityUnitTypes { get; set; }
        public virtual DbSet<FmVehicleLocation> FmVehicleLocations { get; set; }
        public virtual DbSet<FmVehicleStatus> FmVehicleStatuses { get; set; }
        public virtual DbSet<FmVehicleType> FmVehicleTypes { get; set; }
        public virtual DbSet<GsApp> GsApps { get; set; }
        public virtual DbSet<GsAppSetting> GsAppSettings { get; set; }
        public virtual DbSet<GsAppType> GsAppTypes { get; set; }
        public virtual DbSet<GsTheme> GsThemes { get; set; }
        public virtual DbSet<GsUserSetting> GsUserSettings { get; set; }
        public virtual DbSet<HrmEmployee> HrmEmployees { get; set; }
        public virtual DbSet<HrmEmployeeEmployeeGroup> HrmEmployeeEmployeeGroups { get; set; }
        public virtual DbSet<HrmEmployeeGroup> HrmEmployeeGroups { get; set; }
        public virtual DbSet<HrmEmployeeGroupOrganisation> HrmEmployeeGroupOrganisations { get; set; }
        public virtual DbSet<HrmEmployeeOrganisation> HrmEmployeeOrganisations { get; set; }
        public virtual DbSet<HrmOrganisation> HrmOrganisations { get; set; }
        public virtual DbSet<NmNotification> NmNotifications { get; set; }
        public virtual DbSet<NmNotificationCategory> NmNotificationCategories { get; set; }
        public virtual DbSet<NmNotificationCategoryAgr> NmNotificationCategoryAgrs { get; set; }
        public virtual DbSet<NmNotificationNotificationCategory> NmNotificationNotificationCategories { get; set; }
        public virtual DbSet<NmNotificationSourceType> NmNotificationSourceTypes { get; set; }
        public virtual DbSet<SProductOffer> SProductOffers { get; set; }
        public virtual DbSet<SProductOfferItem> SProductOfferItems { get; set; }
        public virtual DbSet<SShop> SShops { get; set; }
        public virtual DbSet<SShopEmployee> SShopEmployees { get; set; }
        public virtual DbSet<SmDestinationItemBatch> SmDestinationItemBatches { get; set; }
        public virtual DbSet<SmMovingItemBatch> SmMovingItemBatches { get; set; }
        public virtual DbSet<SmShipment> SmShipments { get; set; }
        public virtual DbSet<SmShipmentLocation> SmShipmentLocations { get; set; }
        public virtual DbSet<SmShipmentLocationType> SmShipmentLocationTypes { get; set; }
        public virtual DbSet<SmShipmentVehicle> SmShipmentVehicles { get; set; }
        public virtual DbSet<SmShippedItemBatch> SmShippedItemBatches { get; set; }
        public virtual DbSet<SmSourceItemBatch> SmSourceItemBatches { get; set; }
        public virtual DbSet<UmRight> UmRights { get; set; }
        public virtual DbSet<UmRightRightsSection> UmRightRightsSections { get; set; }
        public virtual DbSet<UmRightsSection> UmRightsSections { get; set; }
        public virtual DbSet<UmRole> UmRoles { get; set; }
        public virtual DbSet<UmRoleRight> UmRoleRights { get; set; }
        public virtual DbSet<UmUser> UmUsers { get; set; }
        public virtual DbSet<UmUserGroup> UmUserGroups { get; set; }
        public virtual DbSet<UmUserRight> UmUserRights { get; set; }
        public virtual DbSet<UmUserRole> UmUserRoles { get; set; }
        public virtual DbSet<UmUserUserGroup> UmUserUserGroups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("User ID=tgEUsr2;Password=tgEUsr0;Server=localhost;Port=5433;Database=TGE1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmAddress>(entity =>
            {
                entity.HasOne(d => d.City)
                    .WithMany(p => p.CmAddresses)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("cityId_fkey");
            });

            modelBuilder.Entity<CmAddressContactField>(entity =>
            {
                entity.HasKey(e => new { e.AddressId, e.ContactFieldId })
                    .HasName("cm__Address_ContactField_pkey");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.CmAddressContactFields)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("addressId_fkey");

                entity.HasOne(d => d.ContactField)
                    .WithMany(p => p.CmAddressContactFields)
                    .HasForeignKey(d => d.ContactFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contactFieldId_fkey");
            });

            modelBuilder.Entity<CmCity>(entity =>
            {
                entity.HasOne(d => d.StateProvince)
                    .WithMany(p => p.CmCities)
                    .HasForeignKey(d => d.StateProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("stateProvinceId_fkey");
            });

            modelBuilder.Entity<CmCompanyInfo>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"cm__Contact_id_seq\"'::regclass)");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.CmCompanyInfoAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.CmCompanyInfoModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.CmCompanyInfos)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("type_fkey");
            });

            modelBuilder.Entity<CmContact>(entity =>
            {
                entity.Property(e => e.IsMerged).HasComment("'yes' if this contact has been merged into another contact");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.CmContactAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.CmContactModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.CmContacts)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("type_fkey");
            });

            modelBuilder.Entity<CmContactConnection>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"cm__ContactField_id_seq\"'::regclass)");

                entity.HasOne(d => d.Adder)
                    .WithMany()
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Connection)
                    .WithMany()
                    .HasForeignKey(d => d.ConnectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("connectionId_fkey");

                entity.HasOne(d => d.FieldTypeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.FieldType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fieldType_fkey");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany()
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<CmContactField>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.CmContactFieldAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.CmContactFields)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("contactId_fkey");

                entity.HasOne(d => d.FieldTypeNavigation)
                    .WithMany(p => p.CmContactFields)
                    .HasForeignKey(d => d.FieldType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fieldType_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.CmContactFieldModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<CmContactFieldType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("cm__ContactFieldType_pkey");
            });

            modelBuilder.Entity<CmContactMerger>(entity =>
            {
                entity.HasKey(e => new { e.MainContactId, e.MergedContactId })
                    .HasName("cm__ContactMerger_pkey");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.CmContactMergers)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.MainContact)
                    .WithMany(p => p.CmContactMergerMainContacts)
                    .HasForeignKey(d => d.MainContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mainContactId_fkey");

                entity.HasOne(d => d.MergedContact)
                    .WithMany(p => p.CmContactMergerMergedContacts)
                    .HasForeignKey(d => d.MergedContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mergedContactId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.CmContactMergers)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<CmContactType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("cm__ContactType_pkey");
            });

            modelBuilder.Entity<CmCountry>(entity =>
            {
                entity.HasOne(d => d.Region)
                    .WithMany(p => p.CmCountries)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("regionId_fkey");
            });

            modelBuilder.Entity<CmCountryContinent>(entity =>
            {
                entity.HasKey(e => new { e.CountryId, e.ContinentId })
                    .HasName("cm__Country_Continent_pkey");

                entity.HasOne(d => d.Continent)
                    .WithMany(p => p.CmCountryContinents)
                    .HasForeignKey(d => d.ContinentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("continentId_fkey");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CmCountryContinents)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("countryId_fkey");
            });

            modelBuilder.Entity<CmEmail>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"cm__ContactField_id_seq\"'::regclass)");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.CmEmailAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.CmEmails)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("contactId_fkey");

                entity.HasOne(d => d.FieldTypeNavigation)
                    .WithMany(p => p.CmEmails)
                    .HasForeignKey(d => d.FieldType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fieldType_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.CmEmailModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<CmFax>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"cm__ContactField_id_seq\"'::regclass)");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.CmFaxAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.CmFaxes)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cityId_fkey");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.CmFaxes)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("contactId_fkey");

                entity.HasOne(d => d.FieldTypeNavigation)
                    .WithMany(p => p.CmFaxes)
                    .HasForeignKey(d => d.FieldType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fieldType_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.CmFaxModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<CmLocationInfo>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"cm__Contact_id_seq\"'::regclass)");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.CmLocationInfoAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.CmLocationInfos)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("addressId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.CmLocationInfoModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.CmLocationInfos)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("type_fkey");
            });

            modelBuilder.Entity<CmNote>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.CmNote)
                    .HasForeignKey<CmNote>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_fkey");
            });

            modelBuilder.Entity<CmPersonalInfo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.CmPersonalInfo)
                    .HasForeignKey<CmPersonalInfo>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_fkey");
            });

            modelBuilder.Entity<CmPhone>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"cm__ContactField_id_seq\"'::regclass)");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.CmPhoneAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.CmPhones)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cityId_fkey");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.CmPhones)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("contactId_fkey");

                entity.HasOne(d => d.FieldTypeNavigation)
                    .WithMany(p => p.CmPhones)
                    .HasForeignKey(d => d.FieldType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fieldType_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.CmPhoneModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<CmProfessionalInfo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.CmProfessionalInfos)
                    .HasForeignKey(d => d.CompanyInfoId)
                    .HasConstraintName("companyInfoId_fkey");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.CmProfessionalInfo)
                    .HasForeignKey<CmProfessionalInfo>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_fkey");
            });

            modelBuilder.Entity<CmStateProvince>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CmStateProvinces)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("countryId_fkey");
            });

            modelBuilder.Entity<DBuyer>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.DBuyerAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.BuyerTypeNavigation)
                    .WithMany(p => p.DBuyers)
                    .HasForeignKey(d => d.BuyerType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("buyerType_fkey");

                entity.HasOne(d => d.CommentsThread)
                    .WithMany(p => p.DBuyers)
                    .HasForeignKey(d => d.CommentsThreadId)
                    .HasConstraintName("commentsThreadId_fkey");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.DBuyers)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("contactId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.DBuyerModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.RctNavigation)
                    .WithMany(p => p.DBuyers)
                    .HasForeignKey(d => d.Rct)
                    .HasConstraintName("RCT_fkey");

                entity.HasOne(d => d.RstNavigation)
                    .WithMany(p => p.DBuyers)
                    .HasForeignKey(d => d.Rst)
                    .HasConstraintName("RST_fkey");
            });

            modelBuilder.Entity<DBuyerType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("d__BuyerType_pkey");
            });

            modelBuilder.Entity<DComment>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.DCommentAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.CommentsThread)
                    .WithMany(p => p.DComments)
                    .HasForeignKey(d => d.CommentsThreadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("commentsThreadId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.DCommentModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<DItem>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"Item_id_seq\"'::regclass)");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.DItemAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.DItemModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.DItems)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prodId_fkey");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.DItems)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("unitId_fkey");
            });

            modelBuilder.Entity<DItemBatch>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"ItemBatch_id_seq\"'::regclass)");

                entity.Property(e => e.SourceId).HasComment("This column will not have a FK constraint because it references multiple tables");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.DItemBatchAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.ItemBatchTypeNavigation)
                    .WithMany(p => p.DItemBatches)
                    .HasForeignKey(d => d.ItemBatchType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("itemBatchType_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.DItemBatchModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DItemBatches)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productId_fkey");

                entity.HasOne(d => d.SourceTypeNavigation)
                    .WithMany(p => p.DItemBatches)
                    .HasForeignKey(d => d.SourceType)
                    .HasConstraintName("sourceType_fkey");
            });

            modelBuilder.Entity<DItemBatchAgr>(entity =>
            {
                entity.HasComment("'Pre-aggregated table in DB' or 'contained object in the app' with derived values against ItemBatch > id");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.DItemBatchAgr)
                    .HasForeignKey<DItemBatchAgr>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_fkey");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.DItemBatchAgrs)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("unitId_fkey");
            });

            modelBuilder.Entity<DItemBatchSourceType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("ItemBatchSourceType_pkey");

                entity.HasComment("To be maintained by the System Developer.");
            });

            modelBuilder.Entity<DItemBatchType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("ItemBatchType_pkey");

                entity.HasComment("To be maintained by the System Developer.");
            });

            modelBuilder.Entity<DItemItemBatch>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.BatchId })
                    .HasName("Item_ItemBatch_pkey");

                entity.HasComment("Relationship between Item and ItemBatch.");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.DItemItemBatches)
                    .HasForeignKey(d => d.BatchId)
                    .HasConstraintName("batchId_fkey");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.DItemItemBatches)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("itemId_fkey");
            });

            modelBuilder.Entity<DItemRemovalHistory>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("d__ItemRemovalHistory_pkey");

                entity.Property(e => e.ItemId).ValueGeneratedNever();

                entity.HasOne(d => d.Item)
                    .WithOne(p => p.DItemRemovalHistory)
                    .HasForeignKey<DItemRemovalHistory>(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("itemId_fkey");

                entity.HasOne(d => d.Remover)
                    .WithMany(p => p.DItemRemovalHistories)
                    .HasForeignKey(d => d.RemoverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("removerId_fkey");
            });

            modelBuilder.Entity<DProduct>(entity =>
            {
                entity.Property(e => e.BarCode).IsFixedLength(true);

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.DProductAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.DProductModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.DProducts)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .HasConstraintName("productCategoryId_fkey");
            });

            modelBuilder.Entity<DProductCategory>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.DProductCategoryAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.DProductCategoryModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<DProductStock>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DProductStocks)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productId_fkey");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.DProductStocks)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("unitId_fkey");
            });

            modelBuilder.Entity<DProductUnit>(entity =>
            {
                entity.Property(e => e.IsDefault).HasComment("'true' if current unit is the default unit for the product.");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.DProductUnitAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.DProductUnitModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DProductUnits)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productId_fkey");
            });

            modelBuilder.Entity<DProductUnitConvertion>(entity =>
            {
                entity.HasKey(e => new { e.SourceUnitId, e.DestinationUnitId })
                    .HasName("d__ProductUnitConvertion_pkey");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.DProductUnitConvertionAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.DestinationUnit)
                    .WithMany(p => p.DProductUnitConvertionDestinationUnits)
                    .HasForeignKey(d => d.DestinationUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("destinationUnitId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.DProductUnitConvertionModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.SourceUnit)
                    .WithMany(p => p.DProductUnitConvertionSourceUnits)
                    .HasForeignKey(d => d.SourceUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sourceUnitId_fkey");
            });

            modelBuilder.Entity<DProductWarehouseStock>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DProductWarehouseStocks)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productId_fkey");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.DProductWarehouseStocks)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("unitId_fkey");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.DProductWarehouseStocks)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("warehouseId_fkey");
            });

            modelBuilder.Entity<DReceivedItemBatch>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"ItemBatch_id_seq\"'::regclass)");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.DReceivedItemBatchAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.ItemBatchTypeNavigation)
                    .WithMany(p => p.DReceivedItemBatches)
                    .HasForeignKey(d => d.ItemBatchType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("itemBatchType_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.DReceivedItemBatchModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DReceivedItemBatches)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productId_fkey");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.DReceivedItemBatches)
                    .HasForeignKey(d => d.SellerId)
                    .HasConstraintName("sellerId_fkey");

                entity.HasOne(d => d.SourceTypeNavigation)
                    .WithMany(p => p.DReceivedItemBatches)
                    .HasForeignKey(d => d.SourceType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sourceType_fkey");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.DReceivedItemBatches)
                    .HasForeignKey(d => d.TransactionId)
                    .HasConstraintName("transactionId_fkey");
            });

            modelBuilder.Entity<DRelativeCountryType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("d__RelativeCountryType_pkey");
            });

            modelBuilder.Entity<DRelativeStateProvType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("d__RelativeStateProvType_pkey");
            });

            modelBuilder.Entity<DRemovedItemBatch>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"ItemBatch_id_seq\"'::regclass)");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.DRemovedItemBatchAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.ItemBatchTypeNavigation)
                    .WithMany(p => p.DRemovedItemBatches)
                    .HasForeignKey(d => d.ItemBatchType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("itemBatchType_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.DRemovedItemBatchModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DRemovedItemBatches)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productId_fkey");

                entity.HasOne(d => d.SourceTypeNavigation)
                    .WithMany(p => p.DRemovedItemBatches)
                    .HasForeignKey(d => d.SourceType)
                    .HasConstraintName("sourceType_fkey");
            });

            modelBuilder.Entity<DSeller>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.DSellerAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.CommentsThread)
                    .WithMany(p => p.DSellers)
                    .HasForeignKey(d => d.CommentsThreadId)
                    .HasConstraintName("commentsThreadId_fkey");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.DSellers)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("contactId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.DSellerModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.RctNavigation)
                    .WithMany(p => p.DSellers)
                    .HasForeignKey(d => d.Rct)
                    .HasConstraintName("RCT_fkey");

                entity.HasOne(d => d.RstNavigation)
                    .WithMany(p => p.DSellers)
                    .HasForeignKey(d => d.Rst)
                    .HasConstraintName("RST_fkey");

                entity.HasOne(d => d.SellerTypeNavigation)
                    .WithMany(p => p.DSellers)
                    .HasForeignKey(d => d.SellerType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sellerType_fkey");
            });

            modelBuilder.Entity<DSellerType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("d__SellerType_pkey");
            });

            modelBuilder.Entity<DStoredItemBatch>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"ItemBatch_id_seq\"'::regclass)");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.DStoredItemBatchAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.ItemBatchTypeNavigation)
                    .WithMany(p => p.DStoredItemBatches)
                    .HasForeignKey(d => d.ItemBatchType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("itemBatchType_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.DStoredItemBatchModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DStoredItemBatches)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productId_fkey");

                entity.HasOne(d => d.ProductWarehouseStock)
                    .WithMany(p => p.DStoredItemBatches)
                    .HasForeignKey(d => d.ProductWarehouseStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productWarehouseStockId_fkey");

                entity.HasOne(d => d.SourceTypeNavigation)
                    .WithMany(p => p.DStoredItemBatches)
                    .HasForeignKey(d => d.SourceType)
                    .HasConstraintName("sourceType_fkey");
            });

            modelBuilder.Entity<DWarehouse>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.DWarehouseAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.DWarehouses)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("locationId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.DWarehouseModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<FimBankBranch>(entity =>
            {
                entity.HasOne(d => d.Address)
                    .WithMany(p => p.FimBankBranches)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("addressId_fkey");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.FimBankBranches)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bankId_fkey");
            });

            modelBuilder.Entity<FimBankBranchPoc>(entity =>
            {
                entity.HasKey(e => new { e.BankBranchId, e.ContactId })
                    .HasName("fim__BankBranchPOC_pkey");

                entity.HasOne(d => d.BankBranch)
                    .WithMany(p => p.FimBankBranchPocs)
                    .HasForeignKey(d => d.BankBranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bankBranchId_fkey");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.FimBankBranchPocs)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contactId_fkey");
            });

            modelBuilder.Entity<FimCashPayment>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"fim__Payment_id_seq\"'::regclass)");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.FimCashPayments)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("type_fkey");
            });

            modelBuilder.Entity<FimCheque>(entity =>
            {
                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.FimCheques)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bankId_fkey");

                entity.HasOne(d => d.IssuerContact)
                    .WithMany(p => p.FimCheques)
                    .HasForeignKey(d => d.IssuerContactId)
                    .HasConstraintName("issuerContactId_fkey");
            });

            modelBuilder.Entity<FimChequePayment>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"fim__Payment_id_seq\"'::regclass)");

                entity.HasOne(d => d.Cheque)
                    .WithMany(p => p.FimChequePayments)
                    .HasForeignKey(d => d.ChequeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("chequeId_fkey");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.FimChequePayments)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("type_fkey");
            });

            modelBuilder.Entity<FimCreditPayment>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"fim__Payment_id_seq\"'::regclass)");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.FimCreditPayments)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("type_fkey");
            });

            modelBuilder.Entity<FimCurrency>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("fim_Currency_pkey");

                entity.Property(e => e.Value).IsFixedLength(true);
            });

            modelBuilder.Entity<FimPayment>(entity =>
            {
                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.FimPayments)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("type_fkey");
            });

            modelBuilder.Entity<FimPaymentAmount>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<FimPaymentPart>(entity =>
            {
                entity.HasOne(d => d.PaymentPartTypeNavigation)
                    .WithMany(p => p.FimPaymentParts)
                    .HasForeignKey(d => d.PaymentPartType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("paymentPartType_fkey");
            });

            modelBuilder.Entity<FimPaymentPartType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("fim__PaymentPartType_pkey");
            });

            modelBuilder.Entity<FimPaymentType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("fim__PaymentType_pkey");
            });

            modelBuilder.Entity<FimTransaction>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.FimTransactionAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.FimTransactionModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.FimTransactions)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("paymentId_fkey");

                entity.HasOne(d => d.RctNavigation)
                    .WithMany(p => p.FimTransactions)
                    .HasForeignKey(d => d.Rct)
                    .HasConstraintName("RCT_fkey");

                entity.HasOne(d => d.RstNavigation)
                    .WithMany(p => p.FimTransactions)
                    .HasForeignKey(d => d.Rst)
                    .HasConstraintName("RST_fkey");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.FimTransactions)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("type_fkey");
            });

            modelBuilder.Entity<FimTransactionAmount>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.FimTransactionAmount)
                    .HasForeignKey<FimTransactionAmount>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_fkey");
            });

            modelBuilder.Entity<FimTransactionItem>(entity =>
            {
                entity.HasOne(d => d.ItemBatch)
                    .WithMany(p => p.FimTransactionItems)
                    .HasForeignKey(d => d.ItemBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("itemBatchId_fkey");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.FimTransactionItems)
                    .HasForeignKey(d => d.TransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("transactionId_fkey");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.FimTransactionItems)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("unitId_fkey");
            });

            modelBuilder.Entity<FimTransactionItemAgr>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.FimTransactionItemAgr)
                    .HasForeignKey<FimTransactionItemAgr>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_fkey");
            });

            modelBuilder.Entity<FimTransactionType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("fim__TransactionType_pkey");
            });

            modelBuilder.Entity<FmVehicle>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.FmVehicleAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.FmVehicle)
                    .HasForeignKey<FmVehicle>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("currentDriverId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.FmVehicleModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.FmVehicles)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("status_fkey");

                entity.HasOne(d => d.VehicleTypeNavigation)
                    .WithMany(p => p.FmVehicles)
                    .HasForeignKey(d => d.VehicleType)
                    .HasConstraintName("vehicleType_fkey");
            });

            modelBuilder.Entity<FmVehicleCapacity>(entity =>
            {
                entity.HasKey(e => new { e.VehicleId, e.CapacityUnitId })
                    .HasName("fm__VehicleCapacity_pkey");

                entity.HasOne(d => d.CapacityUnit)
                    .WithMany(p => p.FmVehicleCapacities)
                    .HasForeignKey(d => d.CapacityUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("capacityUnitId_fkey");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.FmVehicleCapacities)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicleId_fkey");
            });

            modelBuilder.Entity<FmVehicleCapacityUnit>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.FmVehicleCapacityUnitAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.FmVehicleCapacityUnitModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.VehicleTypeNavigation)
                    .WithMany(p => p.FmVehicleCapacityUnits)
                    .HasForeignKey(d => d.VehicleType)
                    .HasConstraintName("vehicleType_fkey");

                entity.HasOne(d => d.VehicleUnitTypeNavigation)
                    .WithMany(p => p.FmVehicleCapacityUnits)
                    .HasForeignKey(d => d.VehicleUnitType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicleUnitType_fkey");
            });

            modelBuilder.Entity<FmVehicleCapacityUnitConvertion>(entity =>
            {
                entity.HasKey(e => new { e.SourceUnitId, e.DestinationUnitId })
                    .HasName("fm__VehicleCapacityUnitConvertion_pkey");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.FmVehicleCapacityUnitConvertionAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.DestinationUnit)
                    .WithMany(p => p.FmVehicleCapacityUnitConvertionDestinationUnits)
                    .HasForeignKey(d => d.DestinationUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("destinationUnitId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.FmVehicleCapacityUnitConvertionModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.SourceUnit)
                    .WithMany(p => p.FmVehicleCapacityUnitConvertionSourceUnits)
                    .HasForeignKey(d => d.SourceUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sourceUnitId_fkey");
            });

            modelBuilder.Entity<FmVehicleCapacityUnitType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("fm__VehicleCapacityUnitType_pkey");
            });

            modelBuilder.Entity<FmVehicleLocation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.FmVehicleLocation)
                    .HasForeignKey<FmVehicleLocation>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_fkey");
            });

            modelBuilder.Entity<FmVehicleStatus>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("fm__VehicleStatus_pkey");
            });

            modelBuilder.Entity<FmVehicleType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("fm__VehicleType_pkey");
            });

            modelBuilder.Entity<GsApp>(entity =>
            {
                entity.HasOne(d => d.AppTypeNavigation)
                    .WithMany(p => p.GsApps)
                    .HasForeignKey(d => d.AppType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("appType_fkey");

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.GsApps)
                    .HasForeignKey(d => d.UserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userGroupId_fkey");
            });

            modelBuilder.Entity<GsAppSetting>(entity =>
            {
                entity.HasKey(e => e.AppId)
                    .HasName("gs__AppSettings_pkey");

                entity.Property(e => e.AppId).ValueGeneratedNever();

                entity.HasOne(d => d.App)
                    .WithOne(p => p.GsAppSetting)
                    .HasForeignKey<GsAppSetting>(d => d.AppId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("appId_fkey");

                entity.HasOne(d => d.DefaultCurrency)
                    .WithMany(p => p.GsAppSettings)
                    .HasForeignKey(d => d.DefaultCurrencyId)
                    .HasConstraintName("defaultCurrencyId_fkey");
            });

            modelBuilder.Entity<GsAppType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("gs__AppType_pkey");
            });

            modelBuilder.Entity<GsUserSetting>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("gs__UserSettings_pkey");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.CurrentTheme)
                    .WithMany(p => p.GsUserSettings)
                    .HasForeignKey(d => d.CurrentThemeId)
                    .HasConstraintName("currentThemeId_fkey");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.GsUserSetting)
                    .HasForeignKey<GsUserSetting>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userId_fkey");
            });

            modelBuilder.Entity<HrmEmployee>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.HrmEmployeeAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.InverseContact)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contactId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.HrmEmployeeModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<HrmEmployeeEmployeeGroup>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.EmployeeGroupId })
                    .HasName("hrm__Employee_EmployeeGroup_pkey");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.HrmEmployeeEmployeeGroupAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.EmployeeGroup)
                    .WithMany(p => p.HrmEmployeeEmployeeGroups)
                    .HasForeignKey(d => d.EmployeeGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employeeGroupId_fkey");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.HrmEmployeeEmployeeGroups)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employeeId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.HrmEmployeeEmployeeGroupModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<HrmEmployeeGroup>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.HrmEmployeeGroupAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.HrmEmployeeGroupModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<HrmEmployeeGroupOrganisation>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeGroupId, e.OrganisationId })
                    .HasName("hrm__EmployeeGroup_Organisation_pkey");

                entity.HasOne(d => d.EmployeeGroup)
                    .WithMany(p => p.HrmEmployeeGroupOrganisations)
                    .HasForeignKey(d => d.EmployeeGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employeeGroupId_fkey");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.HrmEmployeeGroupOrganisations)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("organisationId_fkey");
            });

            modelBuilder.Entity<HrmEmployeeOrganisation>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.OrganisationId })
                    .HasName("hrm__Employee_Organisation_pkey");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.HrmEmployeeOrganisationAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.HrmEmployeeOrganisations)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employeeId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.HrmEmployeeOrganisationModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.HrmEmployeeOrganisations)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("organisationId_fkey");
            });

            modelBuilder.Entity<HrmOrganisation>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.HrmOrganisationAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.HrmOrganisationModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<NmNotification>(entity =>
            {
                entity.HasOne(d => d.Deletor)
                    .WithMany(p => p.NmNotifications)
                    .HasForeignKey(d => d.DeletorId)
                    .HasConstraintName("deletorId_fkey");

                entity.HasOne(d => d.NotificationSourceTypeNavigation)
                    .WithMany(p => p.NmNotifications)
                    .HasForeignKey(d => d.NotificationSourceType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("notificationSourceType_fkey");
            });

            modelBuilder.Entity<NmNotificationCategoryAgr>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.NmNotificationCategoryAgr)
                    .HasForeignKey<NmNotificationCategoryAgr>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_fkey");
            });

            modelBuilder.Entity<NmNotificationNotificationCategory>(entity =>
            {
                entity.HasKey(e => new { e.NotificationId, e.NotificationCategoryId })
                    .HasName("nm__Notification_NotificationCategory_pkey");

                entity.HasOne(d => d.NotificationCategory)
                    .WithMany(p => p.NmNotificationNotificationCategories)
                    .HasForeignKey(d => d.NotificationCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("notificationCategoryId_fkey");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.NmNotificationNotificationCategories)
                    .HasForeignKey(d => d.NotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("notificationId_fkey");
            });

            modelBuilder.Entity<NmNotificationSourceType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("nm__NotificationSourceType_pkey");
            });

            modelBuilder.Entity<SProductOffer>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.SProductOfferAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.SProductOfferModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<SProductOfferItem>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SProductOfferItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productId_fkey");

                entity.HasOne(d => d.ProductOffer)
                    .WithMany(p => p.SProductOfferItems)
                    .HasForeignKey(d => d.ProductOfferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productOfferId_fkey");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.SProductOfferItems)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("unitId_fkey");
            });

            modelBuilder.Entity<SShop>(entity =>
            {
                entity.HasOne(d => d.Location)
                    .WithMany(p => p.SShops)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("locationId_fkey");
            });

            modelBuilder.Entity<SShopEmployee>(entity =>
            {
                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SShopEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employeeId_fkey");
            });

            modelBuilder.Entity<SmDestinationItemBatch>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"ItemBatch_id_seq\"'::regclass)");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.SmDestinationItemBatchAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.ItemBatchTypeNavigation)
                    .WithMany(p => p.SmDestinationItemBatches)
                    .HasForeignKey(d => d.ItemBatchType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("itemBatchType_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.SmDestinationItemBatchModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SmDestinationItemBatches)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productId_fkey");

                entity.HasOne(d => d.ReceivedUnit)
                    .WithMany(p => p.SmDestinationItemBatches)
                    .HasForeignKey(d => d.ReceivedUnitId)
                    .HasConstraintName("receivedUnitId_fkey");

                entity.HasOne(d => d.SourceTypeNavigation)
                    .WithMany(p => p.SmDestinationItemBatches)
                    .HasForeignKey(d => d.SourceType)
                    .HasConstraintName("sourceType_fkey");
            });

            modelBuilder.Entity<SmMovingItemBatch>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"ItemBatch_id_seq\"'::regclass)");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.SmMovingItemBatchAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.ItemBatchTypeNavigation)
                    .WithMany(p => p.SmMovingItemBatches)
                    .HasForeignKey(d => d.ItemBatchType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("itemBatchType_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.SmMovingItemBatchModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SmMovingItemBatches)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productId_fkey");

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.SmMovingItemBatches)
                    .HasForeignKey(d => d.ShipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("shipmentId_fkey");

                entity.HasOne(d => d.SourceTypeNavigation)
                    .WithMany(p => p.SmMovingItemBatches)
                    .HasForeignKey(d => d.SourceType)
                    .HasConstraintName("sourceType_fkey");
            });

            modelBuilder.Entity<SmShipment>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.SmShipmentAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Destination)
                    .WithMany(p => p.SmShipmentDestinations)
                    .HasForeignKey(d => d.DestinationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("destinationId_fkey");

                entity.HasOne(d => d.DestinationItemBatch)
                    .WithMany(p => p.SmShipments)
                    .HasForeignKey(d => d.DestinationItemBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("destinationItemBatchId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.SmShipmentModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.SmShipmentSources)
                    .HasForeignKey(d => d.SourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sourceId_fkey");

                entity.HasOne(d => d.SourceItemBatch)
                    .WithMany(p => p.SmShipments)
                    .HasForeignKey(d => d.SourceItemBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sourceItemBatchId_fkey");

                entity.HasOne(d => d.Suppervisor)
                    .WithMany(p => p.SmShipmentSuppervisors)
                    .HasForeignKey(d => d.SuppervisorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("suppervisorId_fkey");
            });

            modelBuilder.Entity<SmShipmentLocation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.LocationInfo)
                    .WithMany(p => p.SmShipmentLocations)
                    .HasForeignKey(d => d.LocationInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("locationInfoId_fkey");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.SmShipmentLocations)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("type_fkey");
            });

            modelBuilder.Entity<SmShipmentLocationType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("sm__ShipmentLocationType_pkey");
            });

            modelBuilder.Entity<SmShipmentVehicle>(entity =>
            {
                entity.HasKey(e => new { e.ShipmentId, e.VehicleId })
                    .HasName("sm__Shipment_Vehicle_pkey");

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.SmShipmentVehicles)
                    .HasForeignKey(d => d.ShipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("shipmentId_fkey");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.SmShipmentVehicles)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicleId_fkey");
            });

            modelBuilder.Entity<SmShippedItemBatch>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"ItemBatch_id_seq\"'::regclass)");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.SmShippedItemBatchAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.ItemBatchTypeNavigation)
                    .WithMany(p => p.SmShippedItemBatches)
                    .HasForeignKey(d => d.ItemBatchType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("itemBatchType_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.SmShippedItemBatchModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SmShippedItemBatches)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productId_fkey");

                entity.HasOne(d => d.SourceTypeNavigation)
                    .WithMany(p => p.SmShippedItemBatches)
                    .HasForeignKey(d => d.SourceType)
                    .HasConstraintName("sourceType_fkey");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.SmShippedItemBatches)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("vehicleId_fkey");
            });

            modelBuilder.Entity<SmSourceItemBatch>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"ItemBatch_id_seq\"'::regclass)");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.SmSourceItemBatchAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.ItemBatchTypeNavigation)
                    .WithMany(p => p.SmSourceItemBatches)
                    .HasForeignKey(d => d.ItemBatchType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("itemBatchType_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.SmSourceItemBatchModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SmSourceItemBatches)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productId_fkey");

                entity.HasOne(d => d.ShippedUnit)
                    .WithMany(p => p.SmSourceItemBatches)
                    .HasForeignKey(d => d.ShippedUnitId)
                    .HasConstraintName("shippedUnitId_fkey");

                entity.HasOne(d => d.SourceTypeNavigation)
                    .WithMany(p => p.SmSourceItemBatches)
                    .HasForeignKey(d => d.SourceType)
                    .HasConstraintName("sourceType_fkey");
            });

            modelBuilder.Entity<UmRight>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.UmRightAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.UmRightModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<UmRightRightsSection>(entity =>
            {
                entity.HasKey(e => new { e.RightId, e.RightsSectionId })
                    .HasName("um__Right_RightsSection_pkey");

                entity.HasOne(d => d.Right)
                    .WithMany(p => p.UmRightRightsSections)
                    .HasForeignKey(d => d.RightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rightId_fkey");

                entity.HasOne(d => d.RightsSection)
                    .WithMany(p => p.UmRightRightsSections)
                    .HasForeignKey(d => d.RightsSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rightsSectionId_fkey");
            });

            modelBuilder.Entity<UmRole>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.UmRoleAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.UmRoleModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<UmRoleRight>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"um__Right_id_seq\"'::regclass)");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.UmRoleRightAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.UmRoleRightModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UmRoleRights)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("roleId_fkey");
            });

            modelBuilder.Entity<UmUser>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.InverseAdder)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.UmUsers)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("employeeId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.InverseModder)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<UmUserGroup>(entity =>
            {
                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.UmUserGroupAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.UmUserGroupModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");
            });

            modelBuilder.Entity<UmUserRight>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"um__Right_id_seq\"'::regclass)");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.UmUserRightAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.UmUserRightModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UmUserRightUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userId_fkey");
            });

            modelBuilder.Entity<UmUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("um___User_Role_pkey");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.UmUserRoleAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.UmUserRoleModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UmUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("roleId_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UmUserRoleUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userId_fkey");
            });

            modelBuilder.Entity<UmUserUserGroup>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.UserGroupId })
                    .HasName("um__User_UserGroup_pkey");

                entity.HasOne(d => d.Adder)
                    .WithMany(p => p.UmUserUserGroupAdders)
                    .HasForeignKey(d => d.AdderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adderId_fkey");

                entity.HasOne(d => d.Modder)
                    .WithMany(p => p.UmUserUserGroupModders)
                    .HasForeignKey(d => d.ModderId)
                    .HasConstraintName("modderId_fkey");

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.UmUserUserGroups)
                    .HasForeignKey(d => d.UserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userGroupId_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UmUserUserGroupUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userId_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
