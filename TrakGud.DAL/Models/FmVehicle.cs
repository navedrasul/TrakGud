using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fm__Vehicle")]
    [Index(nameof(Status), Name = "fki_status_fkey")]
    [Index(nameof(VehicleType), Name = "fki_vehicleType_fkey")]
    public partial class FmVehicle
    {
        public FmVehicle()
        {
            FmVehicleCapacities = new HashSet<FmVehicleCapacity>();
            SmShipmentVehicles = new HashSet<SmShipmentVehicle>();
            SmShippedItemBatches = new HashSet<SmShippedItemBatch>();
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
        [Required]
        [Column("regNumber")]
        [StringLength(50)]
        public string RegNumber { get; set; }
        [Column("currentDriverId")]
        public int? CurrentDriverId { get; set; }
        [Column("isInService")]
        public bool? IsInService { get; set; }
        [Required]
        [Column("status")]
        [StringLength(25)]
        public string Status { get; set; }
        [Column("addTS", TypeName = "timestamp with time zone")]
        public DateTime AddTs { get; set; }
        [Column("adderId")]
        public int AdderId { get; set; }
        [Column("modderId")]
        public int? ModderId { get; set; }
        [Column("isRemoved")]
        public bool? IsRemoved { get; set; }
        [Column("driverAssignmentTS", TypeName = "timestamp with time zone")]
        public DateTime? DriverAssignmentTs { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }
        [Column("vehicleType")]
        [StringLength(25)]
        public string VehicleType { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.FmVehicleAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(CmContact.FmVehicle))]
        public virtual CmContact IdNavigation { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.FmVehicleModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(Status))]
        [InverseProperty(nameof(FmVehicleStatus.FmVehicles))]
        public virtual FmVehicleStatus StatusNavigation { get; set; }
        [ForeignKey(nameof(VehicleType))]
        [InverseProperty(nameof(FmVehicleType.FmVehicles))]
        public virtual FmVehicleType VehicleTypeNavigation { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual FmVehicleLocation FmVehicleLocation { get; set; }
        [InverseProperty(nameof(FmVehicleCapacity.Vehicle))]
        public virtual ICollection<FmVehicleCapacity> FmVehicleCapacities { get; set; }
        [InverseProperty(nameof(SmShipmentVehicle.Vehicle))]
        public virtual ICollection<SmShipmentVehicle> SmShipmentVehicles { get; set; }
        [InverseProperty(nameof(SmShippedItemBatch.Vehicle))]
        public virtual ICollection<SmShippedItemBatch> SmShippedItemBatches { get; set; }
    }
}
