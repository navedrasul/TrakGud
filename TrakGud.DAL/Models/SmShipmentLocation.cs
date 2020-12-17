using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("sm__ShipmentLocation")]
    [Index(nameof(LocationInfoId), Name = "fki_locationInfoId_fkey")]
    public partial class SmShipmentLocation
    {
        public SmShipmentLocation()
        {
            SmShipmentDestinations = new HashSet<SmShipment>();
            SmShipmentSources = new HashSet<SmShipment>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("type")]
        [StringLength(25)]
        public string Type { get; set; }
        [Column("locationInfoId")]
        public int LocationInfoId { get; set; }

        [ForeignKey(nameof(LocationInfoId))]
        [InverseProperty(nameof(CmLocationInfo.SmShipmentLocations))]
        public virtual CmLocationInfo LocationInfo { get; set; }
        [ForeignKey(nameof(Type))]
        [InverseProperty(nameof(SmShipmentLocationType.SmShipmentLocations))]
        public virtual SmShipmentLocationType TypeNavigation { get; set; }
        [InverseProperty(nameof(SmShipment.Destination))]
        public virtual ICollection<SmShipment> SmShipmentDestinations { get; set; }
        [InverseProperty(nameof(SmShipment.Source))]
        public virtual ICollection<SmShipment> SmShipmentSources { get; set; }
    }
}
