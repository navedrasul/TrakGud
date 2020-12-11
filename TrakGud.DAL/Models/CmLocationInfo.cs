using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__LocationInfo")]
    public partial class CmLocationInfo
    {
        public CmLocationInfo()
        {
            DWarehouses = new HashSet<DWarehouse>();
            SShops = new HashSet<SShop>();
            SmShipmentLocations = new HashSet<SmShipmentLocation>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("isMerged")]
        public bool? IsMerged { get; set; }
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
        [Required]
        [Column("type")]
        [StringLength(25)]
        public string Type { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("addressId")]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.CmLocationInfoAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(AddressId))]
        [InverseProperty(nameof(CmAddress.CmLocationInfos))]
        public virtual CmAddress Address { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.CmLocationInfoModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(Type))]
        [InverseProperty(nameof(CmContactType.CmLocationInfos))]
        public virtual CmContactType TypeNavigation { get; set; }
        [InverseProperty(nameof(DWarehouse.Location))]
        public virtual ICollection<DWarehouse> DWarehouses { get; set; }
        [InverseProperty(nameof(SShop.Location))]
        public virtual ICollection<SShop> SShops { get; set; }
        [InverseProperty(nameof(SmShipmentLocation.LocationInfo))]
        public virtual ICollection<SmShipmentLocation> SmShipmentLocations { get; set; }
    }
}
