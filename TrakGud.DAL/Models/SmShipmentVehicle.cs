using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("sm__Shipment_Vehicle")]
    [Index(nameof(VehicleId), Name = "fki_vehicleId_fkey")]
    public partial class SmShipmentVehicle
    {
        [Key]
        [Column("shipmentId")]
        public int ShipmentId { get; set; }
        [Key]
        [Column("vehicleId")]
        public int VehicleId { get; set; }
        [Column("assignmentTS", TypeName = "timestamp with time zone")]
        public DateTime? AssignmentTs { get; set; }

        [ForeignKey(nameof(ShipmentId))]
        [InverseProperty(nameof(SmShipment.SmShipmentVehicles))]
        public virtual SmShipment Shipment { get; set; }
        [ForeignKey(nameof(VehicleId))]
        [InverseProperty(nameof(FmVehicle.SmShipmentVehicles))]
        public virtual FmVehicle Vehicle { get; set; }
    }
}
