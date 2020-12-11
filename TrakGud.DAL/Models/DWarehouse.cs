using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__Warehouse")]
    [Index(nameof(LocationId), Name = "fki_locationId_fkey")]
    public partial class DWarehouse
    {
        public DWarehouse()
        {
            DProductWarehouseStocks = new HashSet<DProductWarehouseStock>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("locationId")]
        public int LocationId { get; set; }
        [Column("addTS", TypeName = "timestamp with time zone")]
        public DateTime AddTs { get; set; }
        [Column("adderId")]
        public int AdderId { get; set; }
        [Column("modderId")]
        public int? ModderId { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.DWarehouseAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(LocationId))]
        [InverseProperty(nameof(CmLocationInfo.DWarehouses))]
        public virtual CmLocationInfo Location { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.DWarehouseModders))]
        public virtual UmUser Modder { get; set; }
        [InverseProperty(nameof(DProductWarehouseStock.Warehouse))]
        public virtual ICollection<DProductWarehouseStock> DProductWarehouseStocks { get; set; }
    }
}
