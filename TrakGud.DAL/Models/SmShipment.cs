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
    }
}
