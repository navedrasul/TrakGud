using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrakGud.DAL.Models.Domain;

namespace TrakGud.DAL.Repos
{
    public class DomainContext : DbContext
    {
        public DomainContext(DbContextOptions<DomainContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        //public DbSet<ItemBatch> ItemBatches { get; set; }
        //public DbSet<ItemBatchSourceType> ItemBatchSourceTypes { get; set; }
        //public DbSet<ItemBatchType> ItemBatchTypes { get; set; }
        //public DbSet<ItemBatch_agr> ItemBatch_agrs { get; set; }
        //public DbSet<Item_ItemBatch> Item_ItemBatches { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<ProductUnit> ProductUnits { get; set; }
        //public DbSet<ProductCategory> ProductCategories { get; set; }
        //public DbSet<ProductWarehouseStock> ProductWarehouseStocks { get; set; }
        //public DbSet<ProductStock> ProductStocks { get; set; }
        //public DbSet<ProductUnitConvertion> ProductUnitConvertions { get; set; }
        //public DbSet<Warehouse> Warehouses { get; set; }
        //public DbSet<RemovedItemBatch> RemovedItemBatches { get; set; }
        //public DbSet<Buyer> Buyers { get; set; }
        //public DbSet<ItemRemovalHistory> ItemRemovalHistories { get; set; }
        //public DbSet<SellerType> SellerTypes { get; set; }
        //public DbSet<BuyerType> BuyerTypes { get; set; }
        //public DbSet<RelativeCountryType> RelativeCountryTypes { get; set; }
        //public DbSet<RelativeStateProvType> RelativeStateProvTypes { get; set; }
        //public DbSet<CommentsThread> CommentsThreads { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<Seller> Sellers { get; set; }
        //public DbSet<ReceivedItemBatch> ReceivedItemBatches { get; set; }
        //public DbSet<StoredItemBatch> StoredItemBatches { get; set; }
    }
}
