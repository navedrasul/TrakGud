using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fm__VehicleLocation")]
    public partial class FmVehicleLocation
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("latitude")]
        public float? Latitude { get; set; }
        [Column("longitude")]
        public float? Longitude { get; set; }

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(FmVehicle.FmVehicleLocation))]
        public virtual FmVehicle IdNavigation { get; set; }
    }
}
