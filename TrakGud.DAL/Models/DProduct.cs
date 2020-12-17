using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__Product")]
    [Index(nameof(ProductCategoryId), Name = "fki_productCategoryId_fkey")]
    public partial class DProduct
    {
        public DProduct()
        {
            DItemBatches = new HashSet<DItemBatch>();
            DItems = new HashSet<DItem>();
            DProductStocks = new HashSet<DProductStock>();
            DProductUnits = new HashSet<DProductUnit>();
            DProductWarehouseStocks = new HashSet<DProductWarehouseStock>();
            DReceivedItemBatches = new HashSet<DReceivedItemBatch>();
            DRemovedItemBatches = new HashSet<DRemovedItemBatch>();
            DStoredItemBatches = new HashSet<DStoredItemBatch>();
            SProductOfferItems = new HashSet<SProductOfferItem>();
            SmDestinationItemBatches = new HashSet<SmDestinationItemBatch>();
            SmMovingItemBatches = new HashSet<SmMovingItemBatch>();
            SmShippedItemBatches = new HashSet<SmShippedItemBatch>();
            SmSourceItemBatches = new HashSet<SmSourceItemBatch>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("desc")]
        [StringLength(150)]
        public string Desc { get; set; }
        [Column("productCategoryId")]
        public int? ProductCategoryId { get; set; }
        [Column("barCode")]
        [StringLength(13)]
        public string BarCode { get; set; }
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
        [InverseProperty(nameof(UmUser.DProductAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.DProductModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(ProductCategoryId))]
        [InverseProperty(nameof(DProductCategory.DProducts))]
        public virtual DProductCategory ProductCategory { get; set; }
        [InverseProperty(nameof(DItemBatch.Product))]
        public virtual ICollection<DItemBatch> DItemBatches { get; set; }
        [InverseProperty(nameof(DItem.Prod))]
        public virtual ICollection<DItem> DItems { get; set; }
        [InverseProperty(nameof(DProductStock.Product))]
        public virtual ICollection<DProductStock> DProductStocks { get; set; }
        [InverseProperty(nameof(DProductUnit.Product))]
        public virtual ICollection<DProductUnit> DProductUnits { get; set; }
        [InverseProperty(nameof(DProductWarehouseStock.Product))]
        public virtual ICollection<DProductWarehouseStock> DProductWarehouseStocks { get; set; }
        [InverseProperty(nameof(DReceivedItemBatch.Product))]
        public virtual ICollection<DReceivedItemBatch> DReceivedItemBatches { get; set; }
        [InverseProperty(nameof(DRemovedItemBatch.Product))]
        public virtual ICollection<DRemovedItemBatch> DRemovedItemBatches { get; set; }
        [InverseProperty(nameof(DStoredItemBatch.Product))]
        public virtual ICollection<DStoredItemBatch> DStoredItemBatches { get; set; }
        [InverseProperty(nameof(SProductOfferItem.Product))]
        public virtual ICollection<SProductOfferItem> SProductOfferItems { get; set; }
        [InverseProperty(nameof(SmDestinationItemBatch.Product))]
        public virtual ICollection<SmDestinationItemBatch> SmDestinationItemBatches { get; set; }
        [InverseProperty(nameof(SmMovingItemBatch.Product))]
        public virtual ICollection<SmMovingItemBatch> SmMovingItemBatches { get; set; }
        [InverseProperty(nameof(SmShippedItemBatch.Product))]
        public virtual ICollection<SmShippedItemBatch> SmShippedItemBatches { get; set; }
        [InverseProperty(nameof(SmSourceItemBatch.Product))]
        public virtual ICollection<SmSourceItemBatch> SmSourceItemBatches { get; set; }
    }
}
