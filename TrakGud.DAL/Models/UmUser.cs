using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("um__User")]
    public partial class UmUser
    {
        public UmUser()
        {
            CmCompanyInfoAdders = new HashSet<CmCompanyInfo>();
            CmCompanyInfoModders = new HashSet<CmCompanyInfo>();
            CmContactAdders = new HashSet<CmContact>();
            CmContactFieldAdders = new HashSet<CmContactField>();
            CmContactFieldModders = new HashSet<CmContactField>();
            CmContactMergers = new HashSet<CmContactMerger>();
            CmContactModders = new HashSet<CmContact>();
            CmEmailAdders = new HashSet<CmEmail>();
            CmEmailModders = new HashSet<CmEmail>();
            CmFaxAdders = new HashSet<CmFax>();
            CmFaxModders = new HashSet<CmFax>();
            CmLocationInfoAdders = new HashSet<CmLocationInfo>();
            CmLocationInfoModders = new HashSet<CmLocationInfo>();
            CmPhoneAdders = new HashSet<CmPhone>();
            CmPhoneModders = new HashSet<CmPhone>();
            DBuyerAdders = new HashSet<DBuyer>();
            DBuyerModders = new HashSet<DBuyer>();
            DCommentAdders = new HashSet<DComment>();
            DCommentModders = new HashSet<DComment>();
            DItemAdders = new HashSet<DItem>();
            DItemBatchAdders = new HashSet<DItemBatch>();
            DItemBatchModders = new HashSet<DItemBatch>();
            DItemModders = new HashSet<DItem>();
            DItemRemovalHistories = new HashSet<DItemRemovalHistory>();
            DProductAdders = new HashSet<DProduct>();
            DProductCategoryAdders = new HashSet<DProductCategory>();
            DProductCategoryModders = new HashSet<DProductCategory>();
            DProductModders = new HashSet<DProduct>();
            DProductUnitAdders = new HashSet<DProductUnit>();
            DProductUnitConvertionAdders = new HashSet<DProductUnitConvertion>();
            DProductUnitConvertionModders = new HashSet<DProductUnitConvertion>();
            DProductUnitModders = new HashSet<DProductUnit>();
            DReceivedItemBatchAdders = new HashSet<DReceivedItemBatch>();
            DReceivedItemBatchModders = new HashSet<DReceivedItemBatch>();
            DRemovedItemBatchAdders = new HashSet<DRemovedItemBatch>();
            DRemovedItemBatchModders = new HashSet<DRemovedItemBatch>();
            DSellerAdders = new HashSet<DSeller>();
            DSellerModders = new HashSet<DSeller>();
            DStoredItemBatchAdders = new HashSet<DStoredItemBatch>();
            DStoredItemBatchModders = new HashSet<DStoredItemBatch>();
            DWarehouseAdders = new HashSet<DWarehouse>();
            DWarehouseModders = new HashSet<DWarehouse>();
            FimTransactionAdders = new HashSet<FimTransaction>();
            FimTransactionModders = new HashSet<FimTransaction>();
            FmVehicleAdders = new HashSet<FmVehicle>();
            FmVehicleCapacityUnitAdders = new HashSet<FmVehicleCapacityUnit>();
            FmVehicleCapacityUnitConvertionAdders = new HashSet<FmVehicleCapacityUnitConvertion>();
            FmVehicleCapacityUnitConvertionModders = new HashSet<FmVehicleCapacityUnitConvertion>();
            FmVehicleCapacityUnitModders = new HashSet<FmVehicleCapacityUnit>();
            FmVehicleModders = new HashSet<FmVehicle>();
            HrmEmployeeAdders = new HashSet<HrmEmployee>();
            HrmEmployeeEmployeeGroupAdders = new HashSet<HrmEmployeeEmployeeGroup>();
            HrmEmployeeEmployeeGroupModders = new HashSet<HrmEmployeeEmployeeGroup>();
            HrmEmployeeGroupAdders = new HashSet<HrmEmployeeGroup>();
            HrmEmployeeGroupModders = new HashSet<HrmEmployeeGroup>();
            HrmEmployeeModders = new HashSet<HrmEmployee>();
            HrmEmployeeOrganisationAdders = new HashSet<HrmEmployeeOrganisation>();
            HrmEmployeeOrganisationModders = new HashSet<HrmEmployeeOrganisation>();
            HrmOrganisationAdders = new HashSet<HrmOrganisation>();
            HrmOrganisationModders = new HashSet<HrmOrganisation>();
            InverseAdder = new HashSet<UmUser>();
            InverseModder = new HashSet<UmUser>();
            NmNotifications = new HashSet<NmNotification>();
            SProductOfferAdders = new HashSet<SProductOffer>();
            SProductOfferModders = new HashSet<SProductOffer>();
            SmDestinationItemBatchAdders = new HashSet<SmDestinationItemBatch>();
            SmDestinationItemBatchModders = new HashSet<SmDestinationItemBatch>();
            SmMovingItemBatchAdders = new HashSet<SmMovingItemBatch>();
            SmMovingItemBatchModders = new HashSet<SmMovingItemBatch>();
            SmShipmentAdders = new HashSet<SmShipment>();
            SmShipmentModders = new HashSet<SmShipment>();
            SmShipmentSuppervisors = new HashSet<SmShipment>();
            SmShippedItemBatchAdders = new HashSet<SmShippedItemBatch>();
            SmShippedItemBatchModders = new HashSet<SmShippedItemBatch>();
            SmSourceItemBatchAdders = new HashSet<SmSourceItemBatch>();
            SmSourceItemBatchModders = new HashSet<SmSourceItemBatch>();
            UmRightAdders = new HashSet<UmRight>();
            UmRightModders = new HashSet<UmRight>();
            UmRoleAdders = new HashSet<UmRole>();
            UmRoleModders = new HashSet<UmRole>();
            UmRoleRightAdders = new HashSet<UmRoleRight>();
            UmRoleRightModders = new HashSet<UmRoleRight>();
            UmUserGroupAdders = new HashSet<UmUserGroup>();
            UmUserGroupModders = new HashSet<UmUserGroup>();
            UmUserRightAdders = new HashSet<UmUserRight>();
            UmUserRightModders = new HashSet<UmUserRight>();
            UmUserRightUsers = new HashSet<UmUserRight>();
            UmUserRoleAdders = new HashSet<UmUserRole>();
            UmUserRoleModders = new HashSet<UmUserRole>();
            UmUserRoleUsers = new HashSet<UmUserRole>();
            UmUserUserGroupAdders = new HashSet<UmUserUserGroup>();
            UmUserUserGroupModders = new HashSet<UmUserUserGroup>();
            UmUserUserGroupUsers = new HashSet<UmUserUserGroup>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("username")]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [Column("passwordHash")]
        [StringLength(128)]
        public string PasswordHash { get; set; }
        [Column("isDisabled")]
        public bool? IsDisabled { get; set; }
        [Column("fullName")]
        [StringLength(150)]
        public string FullName { get; set; }
        [Column("employeeId")]
        public int? EmployeeId { get; set; }
        [Column("addTS", TypeName = "timestamp with time zone")]
        public DateTime AddTs { get; set; }
        [Column("adderId")]
        public int AdderId { get; set; }
        [Column("modderId")]
        public int? ModderId { get; set; }
        [Column("isRemoved")]
        public bool? IsRemoved { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.InverseAdder))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty(nameof(HrmEmployee.UmUsers))]
        public virtual HrmEmployee Employee { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.InverseModder))]
        public virtual UmUser Modder { get; set; }
        [InverseProperty("User")]
        public virtual GsUserSetting GsUserSetting { get; set; }
        [InverseProperty(nameof(CmCompanyInfo.Adder))]
        public virtual ICollection<CmCompanyInfo> CmCompanyInfoAdders { get; set; }
        [InverseProperty(nameof(CmCompanyInfo.Modder))]
        public virtual ICollection<CmCompanyInfo> CmCompanyInfoModders { get; set; }
        [InverseProperty(nameof(CmContact.Adder))]
        public virtual ICollection<CmContact> CmContactAdders { get; set; }
        [InverseProperty(nameof(CmContactField.Adder))]
        public virtual ICollection<CmContactField> CmContactFieldAdders { get; set; }
        [InverseProperty(nameof(CmContactField.Modder))]
        public virtual ICollection<CmContactField> CmContactFieldModders { get; set; }
        [InverseProperty(nameof(CmContactMerger.Adder))]
        public virtual ICollection<CmContactMerger> CmContactMergers { get; set; }
        [InverseProperty(nameof(CmContact.Modder))]
        public virtual ICollection<CmContact> CmContactModders { get; set; }
        [InverseProperty(nameof(CmEmail.Adder))]
        public virtual ICollection<CmEmail> CmEmailAdders { get; set; }
        [InverseProperty(nameof(CmEmail.Modder))]
        public virtual ICollection<CmEmail> CmEmailModders { get; set; }
        [InverseProperty(nameof(CmFax.Adder))]
        public virtual ICollection<CmFax> CmFaxAdders { get; set; }
        [InverseProperty(nameof(CmFax.Modder))]
        public virtual ICollection<CmFax> CmFaxModders { get; set; }
        [InverseProperty(nameof(CmLocationInfo.Adder))]
        public virtual ICollection<CmLocationInfo> CmLocationInfoAdders { get; set; }
        [InverseProperty(nameof(CmLocationInfo.Modder))]
        public virtual ICollection<CmLocationInfo> CmLocationInfoModders { get; set; }
        [InverseProperty(nameof(CmPhone.Adder))]
        public virtual ICollection<CmPhone> CmPhoneAdders { get; set; }
        [InverseProperty(nameof(CmPhone.Modder))]
        public virtual ICollection<CmPhone> CmPhoneModders { get; set; }
        [InverseProperty(nameof(DBuyer.Adder))]
        public virtual ICollection<DBuyer> DBuyerAdders { get; set; }
        [InverseProperty(nameof(DBuyer.Modder))]
        public virtual ICollection<DBuyer> DBuyerModders { get; set; }
        [InverseProperty(nameof(DComment.Adder))]
        public virtual ICollection<DComment> DCommentAdders { get; set; }
        [InverseProperty(nameof(DComment.Modder))]
        public virtual ICollection<DComment> DCommentModders { get; set; }
        [InverseProperty(nameof(DItem.Adder))]
        public virtual ICollection<DItem> DItemAdders { get; set; }
        [InverseProperty(nameof(DItemBatch.Adder))]
        public virtual ICollection<DItemBatch> DItemBatchAdders { get; set; }
        [InverseProperty(nameof(DItemBatch.Modder))]
        public virtual ICollection<DItemBatch> DItemBatchModders { get; set; }
        [InverseProperty(nameof(DItem.Modder))]
        public virtual ICollection<DItem> DItemModders { get; set; }
        [InverseProperty(nameof(DItemRemovalHistory.Remover))]
        public virtual ICollection<DItemRemovalHistory> DItemRemovalHistories { get; set; }
        [InverseProperty(nameof(DProduct.Adder))]
        public virtual ICollection<DProduct> DProductAdders { get; set; }
        [InverseProperty(nameof(DProductCategory.Adder))]
        public virtual ICollection<DProductCategory> DProductCategoryAdders { get; set; }
        [InverseProperty(nameof(DProductCategory.Modder))]
        public virtual ICollection<DProductCategory> DProductCategoryModders { get; set; }
        [InverseProperty(nameof(DProduct.Modder))]
        public virtual ICollection<DProduct> DProductModders { get; set; }
        [InverseProperty(nameof(DProductUnit.Adder))]
        public virtual ICollection<DProductUnit> DProductUnitAdders { get; set; }
        [InverseProperty(nameof(DProductUnitConvertion.Adder))]
        public virtual ICollection<DProductUnitConvertion> DProductUnitConvertionAdders { get; set; }
        [InverseProperty(nameof(DProductUnitConvertion.Modder))]
        public virtual ICollection<DProductUnitConvertion> DProductUnitConvertionModders { get; set; }
        [InverseProperty(nameof(DProductUnit.Modder))]
        public virtual ICollection<DProductUnit> DProductUnitModders { get; set; }
        [InverseProperty(nameof(DReceivedItemBatch.Adder))]
        public virtual ICollection<DReceivedItemBatch> DReceivedItemBatchAdders { get; set; }
        [InverseProperty(nameof(DReceivedItemBatch.Modder))]
        public virtual ICollection<DReceivedItemBatch> DReceivedItemBatchModders { get; set; }
        [InverseProperty(nameof(DRemovedItemBatch.Adder))]
        public virtual ICollection<DRemovedItemBatch> DRemovedItemBatchAdders { get; set; }
        [InverseProperty(nameof(DRemovedItemBatch.Modder))]
        public virtual ICollection<DRemovedItemBatch> DRemovedItemBatchModders { get; set; }
        [InverseProperty(nameof(DSeller.Adder))]
        public virtual ICollection<DSeller> DSellerAdders { get; set; }
        [InverseProperty(nameof(DSeller.Modder))]
        public virtual ICollection<DSeller> DSellerModders { get; set; }
        [InverseProperty(nameof(DStoredItemBatch.Adder))]
        public virtual ICollection<DStoredItemBatch> DStoredItemBatchAdders { get; set; }
        [InverseProperty(nameof(DStoredItemBatch.Modder))]
        public virtual ICollection<DStoredItemBatch> DStoredItemBatchModders { get; set; }
        [InverseProperty(nameof(DWarehouse.Adder))]
        public virtual ICollection<DWarehouse> DWarehouseAdders { get; set; }
        [InverseProperty(nameof(DWarehouse.Modder))]
        public virtual ICollection<DWarehouse> DWarehouseModders { get; set; }
        [InverseProperty(nameof(FimTransaction.Adder))]
        public virtual ICollection<FimTransaction> FimTransactionAdders { get; set; }
        [InverseProperty(nameof(FimTransaction.Modder))]
        public virtual ICollection<FimTransaction> FimTransactionModders { get; set; }
        [InverseProperty(nameof(FmVehicle.Adder))]
        public virtual ICollection<FmVehicle> FmVehicleAdders { get; set; }
        [InverseProperty(nameof(FmVehicleCapacityUnit.Adder))]
        public virtual ICollection<FmVehicleCapacityUnit> FmVehicleCapacityUnitAdders { get; set; }
        [InverseProperty(nameof(FmVehicleCapacityUnitConvertion.Adder))]
        public virtual ICollection<FmVehicleCapacityUnitConvertion> FmVehicleCapacityUnitConvertionAdders { get; set; }
        [InverseProperty(nameof(FmVehicleCapacityUnitConvertion.Modder))]
        public virtual ICollection<FmVehicleCapacityUnitConvertion> FmVehicleCapacityUnitConvertionModders { get; set; }
        [InverseProperty(nameof(FmVehicleCapacityUnit.Modder))]
        public virtual ICollection<FmVehicleCapacityUnit> FmVehicleCapacityUnitModders { get; set; }
        [InverseProperty(nameof(FmVehicle.Modder))]
        public virtual ICollection<FmVehicle> FmVehicleModders { get; set; }
        [InverseProperty(nameof(HrmEmployee.Adder))]
        public virtual ICollection<HrmEmployee> HrmEmployeeAdders { get; set; }
        [InverseProperty(nameof(HrmEmployeeEmployeeGroup.Adder))]
        public virtual ICollection<HrmEmployeeEmployeeGroup> HrmEmployeeEmployeeGroupAdders { get; set; }
        [InverseProperty(nameof(HrmEmployeeEmployeeGroup.Modder))]
        public virtual ICollection<HrmEmployeeEmployeeGroup> HrmEmployeeEmployeeGroupModders { get; set; }
        [InverseProperty(nameof(HrmEmployeeGroup.Adder))]
        public virtual ICollection<HrmEmployeeGroup> HrmEmployeeGroupAdders { get; set; }
        [InverseProperty(nameof(HrmEmployeeGroup.Modder))]
        public virtual ICollection<HrmEmployeeGroup> HrmEmployeeGroupModders { get; set; }
        [InverseProperty(nameof(HrmEmployee.Modder))]
        public virtual ICollection<HrmEmployee> HrmEmployeeModders { get; set; }
        [InverseProperty(nameof(HrmEmployeeOrganisation.Adder))]
        public virtual ICollection<HrmEmployeeOrganisation> HrmEmployeeOrganisationAdders { get; set; }
        [InverseProperty(nameof(HrmEmployeeOrganisation.Modder))]
        public virtual ICollection<HrmEmployeeOrganisation> HrmEmployeeOrganisationModders { get; set; }
        [InverseProperty(nameof(HrmOrganisation.Adder))]
        public virtual ICollection<HrmOrganisation> HrmOrganisationAdders { get; set; }
        [InverseProperty(nameof(HrmOrganisation.Modder))]
        public virtual ICollection<HrmOrganisation> HrmOrganisationModders { get; set; }
        [InverseProperty(nameof(UmUser.Adder))]
        public virtual ICollection<UmUser> InverseAdder { get; set; }
        [InverseProperty(nameof(UmUser.Modder))]
        public virtual ICollection<UmUser> InverseModder { get; set; }
        [InverseProperty(nameof(NmNotification.Deletor))]
        public virtual ICollection<NmNotification> NmNotifications { get; set; }
        [InverseProperty(nameof(SProductOffer.Adder))]
        public virtual ICollection<SProductOffer> SProductOfferAdders { get; set; }
        [InverseProperty(nameof(SProductOffer.Modder))]
        public virtual ICollection<SProductOffer> SProductOfferModders { get; set; }
        [InverseProperty(nameof(SmDestinationItemBatch.Adder))]
        public virtual ICollection<SmDestinationItemBatch> SmDestinationItemBatchAdders { get; set; }
        [InverseProperty(nameof(SmDestinationItemBatch.Modder))]
        public virtual ICollection<SmDestinationItemBatch> SmDestinationItemBatchModders { get; set; }
        [InverseProperty(nameof(SmMovingItemBatch.Adder))]
        public virtual ICollection<SmMovingItemBatch> SmMovingItemBatchAdders { get; set; }
        [InverseProperty(nameof(SmMovingItemBatch.Modder))]
        public virtual ICollection<SmMovingItemBatch> SmMovingItemBatchModders { get; set; }
        [InverseProperty(nameof(SmShipment.Adder))]
        public virtual ICollection<SmShipment> SmShipmentAdders { get; set; }
        [InverseProperty(nameof(SmShipment.Modder))]
        public virtual ICollection<SmShipment> SmShipmentModders { get; set; }
        [InverseProperty(nameof(SmShipment.Suppervisor))]
        public virtual ICollection<SmShipment> SmShipmentSuppervisors { get; set; }
        [InverseProperty(nameof(SmShippedItemBatch.Adder))]
        public virtual ICollection<SmShippedItemBatch> SmShippedItemBatchAdders { get; set; }
        [InverseProperty(nameof(SmShippedItemBatch.Modder))]
        public virtual ICollection<SmShippedItemBatch> SmShippedItemBatchModders { get; set; }
        [InverseProperty(nameof(SmSourceItemBatch.Adder))]
        public virtual ICollection<SmSourceItemBatch> SmSourceItemBatchAdders { get; set; }
        [InverseProperty(nameof(SmSourceItemBatch.Modder))]
        public virtual ICollection<SmSourceItemBatch> SmSourceItemBatchModders { get; set; }
        [InverseProperty(nameof(UmRight.Adder))]
        public virtual ICollection<UmRight> UmRightAdders { get; set; }
        [InverseProperty(nameof(UmRight.Modder))]
        public virtual ICollection<UmRight> UmRightModders { get; set; }
        [InverseProperty(nameof(UmRole.Adder))]
        public virtual ICollection<UmRole> UmRoleAdders { get; set; }
        [InverseProperty(nameof(UmRole.Modder))]
        public virtual ICollection<UmRole> UmRoleModders { get; set; }
        [InverseProperty(nameof(UmRoleRight.Adder))]
        public virtual ICollection<UmRoleRight> UmRoleRightAdders { get; set; }
        [InverseProperty(nameof(UmRoleRight.Modder))]
        public virtual ICollection<UmRoleRight> UmRoleRightModders { get; set; }
        [InverseProperty(nameof(UmUserGroup.Adder))]
        public virtual ICollection<UmUserGroup> UmUserGroupAdders { get; set; }
        [InverseProperty(nameof(UmUserGroup.Modder))]
        public virtual ICollection<UmUserGroup> UmUserGroupModders { get; set; }
        [InverseProperty(nameof(UmUserRight.Adder))]
        public virtual ICollection<UmUserRight> UmUserRightAdders { get; set; }
        [InverseProperty(nameof(UmUserRight.Modder))]
        public virtual ICollection<UmUserRight> UmUserRightModders { get; set; }
        [InverseProperty(nameof(UmUserRight.User))]
        public virtual ICollection<UmUserRight> UmUserRightUsers { get; set; }
        [InverseProperty(nameof(UmUserRole.Adder))]
        public virtual ICollection<UmUserRole> UmUserRoleAdders { get; set; }
        [InverseProperty(nameof(UmUserRole.Modder))]
        public virtual ICollection<UmUserRole> UmUserRoleModders { get; set; }
        [InverseProperty(nameof(UmUserRole.User))]
        public virtual ICollection<UmUserRole> UmUserRoleUsers { get; set; }
        [InverseProperty(nameof(UmUserUserGroup.Adder))]
        public virtual ICollection<UmUserUserGroup> UmUserUserGroupAdders { get; set; }
        [InverseProperty(nameof(UmUserUserGroup.Modder))]
        public virtual ICollection<UmUserUserGroup> UmUserUserGroupModders { get; set; }
        [InverseProperty(nameof(UmUserUserGroup.User))]
        public virtual ICollection<UmUserUserGroup> UmUserUserGroupUsers { get; set; }
    }
}
