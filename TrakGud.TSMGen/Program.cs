using System;
using TrakGud.API.Models;
using TrakGud.DAL.Models;
using TypeScriptBuilder;

namespace TrakGud.TSMGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converting C# Models to TypeScript Models:\n");

            TypeScriptGeneratorOptions ops = new TypeScriptGeneratorOptions()
            {
                EmitIinInterface = false
            };
            var ts = new TypeScriptGenerator(ops);

            Console.WriteLine("Converting C# models to TypeScript model in file api-models.ts ...");

            // add types you need (dependant types will be added automatically)
            #region Add C# Types

            ts.AddCSType(typeof(CmAddress));
            ts.AddCSType(typeof(CmAddressContactField));
            ts.AddCSType(typeof(CmCity));
            ts.AddCSType(typeof(CmCompanyInfo));
            ts.AddCSType(typeof(CmContact));
            ts.AddCSType(typeof(CmContactConnection));
            ts.AddCSType(typeof(CmContactField));
            ts.AddCSType(typeof(CmContactFieldType));
            ts.AddCSType(typeof(CmContactMerger));
            ts.AddCSType(typeof(CmContactType));
            ts.AddCSType(typeof(CmContinent));
            ts.AddCSType(typeof(CmCountry));
            ts.AddCSType(typeof(CmCountryContinent));
            ts.AddCSType(typeof(CmEmail));
            ts.AddCSType(typeof(CmFax));
            ts.AddCSType(typeof(CmLocationInfo));
            ts.AddCSType(typeof(CmNote));
            ts.AddCSType(typeof(CmPersonalInfo));
            ts.AddCSType(typeof(CmPhone));
            ts.AddCSType(typeof(CmProfessionalInfo));
            ts.AddCSType(typeof(CmRegion));
            ts.AddCSType(typeof(CmStateProvince));
            ts.AddCSType(typeof(DBuyer));
            ts.AddCSType(typeof(DBuyerType));
            ts.AddCSType(typeof(DComment));
            ts.AddCSType(typeof(DCommentsThread));
            ts.AddCSType(typeof(DItem));
            ts.AddCSType(typeof(DItemBatch));
            ts.AddCSType(typeof(DItemBatchAgr));
            ts.AddCSType(typeof(DItemBatchSourceType));
            ts.AddCSType(typeof(DItemBatchType));
            ts.AddCSType(typeof(DItemItemBatch));
            ts.AddCSType(typeof(DItemRemovalHistory));
            ts.AddCSType(typeof(DProduct));
            ts.AddCSType(typeof(DProductCategory));
            ts.AddCSType(typeof(DProductStock));
            ts.AddCSType(typeof(DProductUnit));
            ts.AddCSType(typeof(DProductUnitConvertion));
            ts.AddCSType(typeof(DProductWarehouseStock));
            ts.AddCSType(typeof(DReceivedItemBatch));
            ts.AddCSType(typeof(DRelativeCountryType));
            ts.AddCSType(typeof(DRelativeStateProvType));
            ts.AddCSType(typeof(DRemovedItemBatch));
            ts.AddCSType(typeof(DSeller));
            ts.AddCSType(typeof(DSellerType));
            ts.AddCSType(typeof(DStoredItemBatch));
            ts.AddCSType(typeof(DWarehouse));
            ts.AddCSType(typeof(FimBank));
            ts.AddCSType(typeof(FimBankBranch));
            ts.AddCSType(typeof(FimBankBranchPoc));
            ts.AddCSType(typeof(FimCashPayment));
            ts.AddCSType(typeof(FimCheque));
            ts.AddCSType(typeof(FimChequePayment));
            ts.AddCSType(typeof(FimCreditPayment));
            ts.AddCSType(typeof(FimCurrency));
            ts.AddCSType(typeof(FimPayment));
            ts.AddCSType(typeof(FimPaymentAmount));
            ts.AddCSType(typeof(FimPaymentPart));
            ts.AddCSType(typeof(FimPaymentPartType));
            ts.AddCSType(typeof(FimPaymentType));
            ts.AddCSType(typeof(FimTransaction));
            ts.AddCSType(typeof(FimTransactionAmount));
            ts.AddCSType(typeof(FimTransactionItem));
            ts.AddCSType(typeof(FimTransactionItemAgr));
            ts.AddCSType(typeof(FimTransactionType));
            ts.AddCSType(typeof(FmVehicle));
            ts.AddCSType(typeof(FmVehicleCapacity));
            ts.AddCSType(typeof(FmVehicleCapacityUnit));
            ts.AddCSType(typeof(FmVehicleCapacityUnitConvertion));
            ts.AddCSType(typeof(FmVehicleCapacityUnitType));
            ts.AddCSType(typeof(FmVehicleLocation));
            ts.AddCSType(typeof(FmVehicleStatus));
            ts.AddCSType(typeof(FmVehicleType));
            ts.AddCSType(typeof(GsApp));
            ts.AddCSType(typeof(GsAppSetting));
            ts.AddCSType(typeof(GsAppType));
            ts.AddCSType(typeof(GsTheme));
            ts.AddCSType(typeof(GsUserSetting));
            ts.AddCSType(typeof(HrmEmployee));
            ts.AddCSType(typeof(HrmEmployeeEmployeeGroup));
            ts.AddCSType(typeof(HrmEmployeeGroup));
            ts.AddCSType(typeof(HrmEmployeeGroupOrganisation));
            ts.AddCSType(typeof(HrmEmployeeOrganisation));
            ts.AddCSType(typeof(HrmOrganisation));
            ts.AddCSType(typeof(NmNotification));
            ts.AddCSType(typeof(NmNotificationCategory));
            ts.AddCSType(typeof(NmNotificationCategoryAgr));
            ts.AddCSType(typeof(NmNotificationNotificationCategory));
            ts.AddCSType(typeof(NmNotificationSourceType));
            ts.AddCSType(typeof(SProductOffer));
            ts.AddCSType(typeof(SProductOfferItem));
            ts.AddCSType(typeof(SShop));
            ts.AddCSType(typeof(SShopEmployee));
            ts.AddCSType(typeof(SmDestinationItemBatch));
            ts.AddCSType(typeof(SmMovingItemBatch));
            ts.AddCSType(typeof(SmShipment));
            ts.AddCSType(typeof(SmShipmentLocation));
            ts.AddCSType(typeof(SmShipmentLocationType));
            ts.AddCSType(typeof(SmShipmentVehicle));
            ts.AddCSType(typeof(SmShippedItemBatch));
            ts.AddCSType(typeof(SmSourceItemBatch));
            ts.AddCSType(typeof(UmRight));
            ts.AddCSType(typeof(UmRightRightsSection));
            ts.AddCSType(typeof(UmRightsSection));
            ts.AddCSType(typeof(UmRole));
            ts.AddCSType(typeof(UmRoleRight));
            ts.AddCSType(typeof(UmUser));
            ts.AddCSType(typeof(UmUserGroup));
            ts.AddCSType(typeof(UmUserRight));
            ts.AddCSType(typeof(UmUserRole));
            ts.AddCSType(typeof(UmUserUserGroup));

            // Models from TrakGud.API.
            // NOTE: Add the base class after the derived classes (to maintain the required sequence in the generated TypeScript file).

            ts.AddCSType(typeof(ApiDItem));

            ts.AddCSType(typeof(ApiDItemBatch));
            ts.AddCSType(typeof(ApiDReceivedItemBatch));
            ts.AddCSType(typeof(ApiDItemBatchBase));

            ts.AddCSType(typeof(ApiDSeller));

            #endregion

            // get generated code as string
            ts.ToString();

            // or write to file
            ts.Store("api-models.ts");
        }
    }
}
