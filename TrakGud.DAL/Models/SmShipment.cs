using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("sm__Shipment")]
    [Index(nameof(DestinationId), Name = "fki_destinationId_fkey")]
    [Index(nameof(DestinationItemBatchId), Name = "fki_destinationItemBatchId_fkey")]
    [Index(nameof(SourceId), Name = "fki_sourceId_fkey")]
    [Index(nameof(SourceItemBatchId), Name = "fki_sourceItemBatchId_fkey")]
    [Index(nameof(SuppervisorId), Name = "fki_suppervisorId_fkey")]
    public partial class SmShipment
    {
        public SmShipment()
        {
            SmMovingItemBatches = new HashSet<SmMovingItemBatch>();
            SmShipmentVehicles = new HashSet<SmShipmentVehicle>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("sourceId")]
        public int SourceId { get; set; }
        [Column("destinationId")]
        public int DestinationId { get; set; }
        [Column("isShipmentComplete")]
        public bool? IsShipmentComplete { get; set; }
        [Column("sourceItemBatchId")]
        public int SourceItemBatchId { get; set; }
        [Column("destinationItemBatchId")]
        public int DestinationItemBatchId { get; set; }
        [Column("suppervisorId")]
        public int SuppervisorId { get; set; }
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
        [InverseProperty(nameof(UmUser.SmShipmentAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(DestinationId))]
        [InverseProperty(nameof(SmShipmentLocation.SmShipmentDestinations))]
        public virtual SmShipmentLocation Destination { get; set; }
        [ForeignKey(nameof(DestinationItemBatchId))]
        [InverseProperty(nameof(SmDestinationItemBatch.SmShipments))]
        public virtual SmDestinationItemBatch DestinationItemBatch { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.SmShipmentModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(SourceId))]
        [InverseProperty(nameof(SmShipmentLocation.SmShipmentSources))]
        public virtual SmShipmentLocation Source { get; set; }
        [ForeignKey(nameof(SourceItemBatchId))]
        [InverseProperty(nameof(SmSourceItemBatch.SmShipments))]
        public virtual SmSourceItemBatch SourceItemBatch { get; set; }
        [ForeignKey(nameof(SuppervisorId))]
        [InverseProperty(nameof(UmUser.SmShipmentSuppervisors))]
        public virtual UmUser Suppervisor { get; set; }
        [InverseProperty(nameof(SmMovingItemBatch.Shipment))]
        public virtual ICollection<SmMovingItemBatch> SmMovingItemBatches { get; set; }
        [InverseProperty(nameof(SmShipmentVehicle.Shipment))]
        public virtual ICollection<SmShipmentVehicle> SmShipmentVehicles { get; set; }
    }
}
