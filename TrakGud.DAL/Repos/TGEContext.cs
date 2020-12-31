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
            modelBuilder.Entity<CmAddressContactField>(entity =>
            {
                entity.HasKey(e => new { e.AddressId, e.ContactFieldId })
                    .HasName("cm__Address_ContactField_pkey");
            });

            modelBuilder.Entity<CmCompanyInfo>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"cm__Contact_id_seq\"'::regclass)");
            });

            modelBuilder.Entity<CmContact>(entity =>
            {
                entity.Property(e => e.IsMerged).HasComment("'yes' if this contact has been merged into another contact");
            });

            modelBuilder.Entity<CmContactConnection>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"cm__ContactField_id_seq\"'::regclass)");
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
            });

            modelBuilder.Entity<CmContactType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("cm__ContactType_pkey");
            });

            modelBuilder.Entity<CmCountryContinent>(entity =>
            {
                entity.HasKey(e => new { e.CountryId, e.ContinentId })
                    .HasName("cm__Country_Continent_pkey");
            });

            modelBuilder.Entity<CmEmail>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"cm__ContactField_id_seq\"'::regclass)");
            });

            modelBuilder.Entity<CmFax>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"cm__ContactField_id_seq\"'::regclass)");
            });

            modelBuilder.Entity<CmLocationInfo>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"cm__Contact_id_seq\"'::regclass)");
            });

            modelBuilder.Entity<CmNote>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<CmPersonalInfo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<CmPhone>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"cm__ContactField_id_seq\"'::regclass)");
            });

            modelBuilder.Entity<DBuyerType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("d__BuyerType_pkey");
            });

            modelBuilder.Entity<DItem>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"Item_id_seq\"'::regclass)");
            });

            modelBuilder.Entity<DItemBatch>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"ItemBatch_id_seq\"'::regclass)");

                entity.Property(e => e.SourceId).HasComment("This column will not have a FK constraint because it references multiple tables");
            });

            modelBuilder.Entity<DItemBatchAgr>(entity =>
            {
                entity.HasComment("'Pre-aggregated table in DB' or 'contained object in the app' with derived values against ItemBatch > id");

                entity.Property(e => e.Id).ValueGeneratedNever();
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
            });

            modelBuilder.Entity<DItemRemovalHistory>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("d__ItemRemovalHistory_pkey");

                entity.Property(e => e.ItemId).ValueGeneratedNever();
            });

            modelBuilder.Entity<DProduct>(entity =>
            {
                entity.Property(e => e.BarCode).IsFixedLength(true);
            });

            modelBuilder.Entity<DProductUnit>(entity =>
            {
                entity.Property(e => e.IsDefault).HasComment("'true' if current unit is the default unit for the product.");
            });

            modelBuilder.Entity<DProductUnitConvertion>(entity =>
            {
                entity.HasKey(e => new { e.SourceUnitId, e.DestinationUnitId })
                    .HasName("d__ProductUnitConvertion_pkey");
            });

            modelBuilder.Entity<DReceivedItemBatch>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"ItemBatch_id_seq\"'::regclass)");
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
            });

            modelBuilder.Entity<DSellerType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("d__SellerType_pkey");
            });

            modelBuilder.Entity<DStoredItemBatch>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"ItemBatch_id_seq\"'::regclass)");
            });

            modelBuilder.Entity<FimBankBranchPoc>(entity =>
            {
                entity.HasKey(e => new { e.BankBranchId, e.ContactId })
                    .HasName("fim__BankBranchPOC_pkey");
            });

            modelBuilder.Entity<FimCashPayment>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"fim__Payment_id_seq\"'::regclass)");
            });

            modelBuilder.Entity<FimChequePayment>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"fim__Payment_id_seq\"'::regclass)");
            });

            modelBuilder.Entity<FimCreditPayment>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"fim__Payment_id_seq\"'::regclass)");
            });

            modelBuilder.Entity<FimCurrency>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("fim_Currency_pkey");

                entity.Property(e => e.Value).IsFixedLength(true);
            });

            modelBuilder.Entity<FimPaymentAmount>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
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

            modelBuilder.Entity<FimTransactionAmount>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<FimTransactionItemAgr>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<FimTransactionType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("fim__TransactionType_pkey");
            });

            modelBuilder.Entity<FmVehicleCapacity>(entity =>
            {
                entity.HasKey(e => new { e.VehicleId, e.CapacityUnitId })
                    .HasName("fm__VehicleCapacity_pkey");
            });

            modelBuilder.Entity<FmVehicleCapacityUnitConvertion>(entity =>
            {
                entity.HasKey(e => new { e.SourceUnitId, e.DestinationUnitId })
                    .HasName("fm__VehicleCapacityUnitConvertion_pkey");
            });

            modelBuilder.Entity<FmVehicleCapacityUnitType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("fm__VehicleCapacityUnitType_pkey");
            });

            modelBuilder.Entity<FmVehicleLocation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
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

            modelBuilder.Entity<GsAppSetting>(entity =>
            {
                entity.HasKey(e => e.AppId)
                    .HasName("gs__AppSettings_pkey");

                entity.Property(e => e.AppId).ValueGeneratedNever();
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
            });

            modelBuilder.Entity<HrmEmployeeEmployeeGroup>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.EmployeeGroupId })
                    .HasName("hrm__Employee_EmployeeGroup_pkey");
            });

            modelBuilder.Entity<HrmEmployeeGroupOrganisation>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeGroupId, e.OrganisationId })
                    .HasName("hrm__EmployeeGroup_Organisation_pkey");
            });

            modelBuilder.Entity<HrmEmployeeOrganisation>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.OrganisationId })
                    .HasName("hrm__Employee_Organisation_pkey");
            });

            modelBuilder.Entity<NmNotificationCategoryAgr>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<NmNotificationNotificationCategory>(entity =>
            {
                entity.HasKey(e => new { e.NotificationId, e.NotificationCategoryId })
                    .HasName("nm__Notification_NotificationCategory_pkey");
            });

            modelBuilder.Entity<NmNotificationSourceType>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("nm__NotificationSourceType_pkey");
            });

            modelBuilder.Entity<SmDestinationItemBatch>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"ItemBatch_id_seq\"'::regclass)");
            });

            modelBuilder.Entity<SmMovingItemBatch>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"ItemBatch_id_seq\"'::regclass)");
            });

            modelBuilder.Entity<SmShipmentLocation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
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
            });

            modelBuilder.Entity<SmShippedItemBatch>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"ItemBatch_id_seq\"'::regclass)");
            });

            modelBuilder.Entity<SmSourceItemBatch>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"ItemBatch_id_seq\"'::regclass)");
            });

            modelBuilder.Entity<UmRightRightsSection>(entity =>
            {
                entity.HasKey(e => new { e.RightId, e.RightsSectionId })
                    .HasName("um__Right_RightsSection_pkey");
            });

            modelBuilder.Entity<UmRoleRight>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"um__Right_id_seq\"'::regclass)");
            });

            modelBuilder.Entity<UmUserRight>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"um__Right_id_seq\"'::regclass)");
            });

            modelBuilder.Entity<UmUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("um___User_Role_pkey");
            });

            modelBuilder.Entity<UmUserUserGroup>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.UserGroupId })
                    .HasName("um__User_UserGroup_pkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
