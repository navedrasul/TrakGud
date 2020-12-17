using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fm__VehicleCapacity")]
    public partial class FmVehicleCapacity
    {
        [Key]
        [Column("vehicleId")]
        public int VehicleId { get; set; }
        [Key]
        [Column("capacityUnitId")]
        public int CapacityUnitId { get; set; }
        [Column("capacity")]
        public float Capacity { get; set; }

        [ForeignKey(nameof(CapacityUnitId))]
        [InverseProperty(nameof(FmVehicleCapacityUnit.FmVehicleCapacities))]
        public virtual FmVehicleCapacityUnit CapacityUnit { get; set; }
        [ForeignKey(nameof(VehicleId))]
        [InverseProperty(nameof(FmVehicle.FmVehicleCapacities))]
        public virtual FmVehicle Vehicle { get; set; }
    }
}
