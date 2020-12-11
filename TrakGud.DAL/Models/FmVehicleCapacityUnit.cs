using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fm__VehicleCapacityUnit")]
    [Index(nameof(VehicleUnitType), Name = "fki_vehicleUnitType_fkey")]
    public partial class FmVehicleCapacityUnit
    {
        public FmVehicleCapacityUnit()
        {
            FmVehicleCapacities = new HashSet<FmVehicleCapacity>();
            FmVehicleCapacityUnitConvertionDestinationUnits = new HashSet<FmVehicleCapacityUnitConvertion>();
            FmVehicleCapacityUnitConvertionSourceUnits = new HashSet<FmVehicleCapacityUnitConvertion>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
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
        [Required]
        [Column("vehicleUnitType")]
        [StringLength(25)]
        public string VehicleUnitType { get; set; }
        [Column("vehicleType")]
        [StringLength(25)]
        public string VehicleType { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.FmVehicleCapacityUnitAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.FmVehicleCapacityUnitModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(VehicleType))]
        [InverseProperty(nameof(FmVehicleType.FmVehicleCapacityUnits))]
        public virtual FmVehicleType VehicleTypeNavigation { get; set; }
        [ForeignKey(nameof(VehicleUnitType))]
        [InverseProperty(nameof(FmVehicleCapacityUnitType.FmVehicleCapacityUnits))]
        public virtual FmVehicleCapacityUnitType VehicleUnitTypeNavigation { get; set; }
        [InverseProperty(nameof(FmVehicleCapacity.CapacityUnit))]
        public virtual ICollection<FmVehicleCapacity> FmVehicleCapacities { get; set; }
        [InverseProperty(nameof(FmVehicleCapacityUnitConvertion.DestinationUnit))]
        public virtual ICollection<FmVehicleCapacityUnitConvertion> FmVehicleCapacityUnitConvertionDestinationUnits { get; set; }
        [InverseProperty(nameof(FmVehicleCapacityUnitConvertion.SourceUnit))]
        public virtual ICollection<FmVehicleCapacityUnitConvertion> FmVehicleCapacityUnitConvertionSourceUnits { get; set; }
    }
}
