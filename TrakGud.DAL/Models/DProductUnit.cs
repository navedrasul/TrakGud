using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__ProductUnit")]
    public partial class DProductUnit
    {
        public DProductUnit()
        {
            DItemBatchAgrs = new HashSet<DItemBatchAgr>();
            DItems = new HashSet<DItem>();
            DProductStocks = new HashSet<DProductStock>();
            DProductUnitConvertionDestinationUnits = new HashSet<DProductUnitConvertion>();
            DProductUnitConvertionSourceUnits = new HashSet<DProductUnitConvertion>();
            DProductWarehouseStocks = new HashSet<DProductWarehouseStock>();
            FimTransactionItems = new HashSet<FimTransactionItem>();
            SProductOfferItems = new HashSet<SProductOfferItem>();
            SmDestinationItemBatches = new HashSet<SmDestinationItemBatch>();
            SmSourceItemBatches = new HashSet<SmSourceItemBatch>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(25)]
        public string Name { get; set; }
        [Column("productId")]
        public int ProductId { get; set; }
        [Column("addTS", TypeName = "timestamp with time zone")]
        public DateTime AddTs { get; set; }
        [Column("adderId")]
        public int AdderId { get; set; }
        [Column("modderId")]
        public int? ModderId { get; set; }
        [Column("isDefault")]
        public bool? IsDefault { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.DProductUnitAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.DProductUnitModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(DProduct.DProductUnits))]
        public virtual DProduct Product { get; set; }
        [InverseProperty(nameof(DItemBatchAgr.Unit))]
        public virtual ICollection<DItemBatchAgr> DItemBatchAgrs { get; set; }
        [InverseProperty(nameof(DItem.Unit))]
        public virtual ICollection<DItem> DItems { get; set; }
        [InverseProperty(nameof(DProductStock.Unit))]
        public virtual ICollection<DProductStock> DProductStocks { get; set; }
        [InverseProperty(nameof(DProductUnitConvertion.DestinationUnit))]
        public virtual ICollection<DProductUnitConvertion> DProductUnitConvertionDestinationUnits { get; set; }
        [InverseProperty(nameof(DProductUnitConvertion.SourceUnit))]
        public virtual ICollection<DProductUnitConvertion> DProductUnitConvertionSourceUnits { get; set; }
        [InverseProperty(nameof(DProductWarehouseStock.Unit))]
        public virtual ICollection<DProductWarehouseStock> DProductWarehouseStocks { get; set; }
        [InverseProperty(nameof(FimTransactionItem.Unit))]
        public virtual ICollection<FimTransactionItem> FimTransactionItems { get; set; }
        [InverseProperty(nameof(SProductOfferItem.Unit))]
        public virtual ICollection<SProductOfferItem> SProductOfferItems { get; set; }
        [InverseProperty(nameof(SmDestinationItemBatch.ReceivedUnit))]
        public virtual ICollection<SmDestinationItemBatch> SmDestinationItemBatches { get; set; }
        [InverseProperty(nameof(SmSourceItemBatch.ShippedUnit))]
        public virtual ICollection<SmSourceItemBatch> SmSourceItemBatches { get; set; }
    }
}
