using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fm__VehicleStatus")]
    public partial class FmVehicleStatus
    {
        public FmVehicleStatus()
        {
            FmVehicles = new HashSet<FmVehicle>();
        }

        [Key]
        [Column("value")]
        [StringLength(25)]
        public string Value { get; set; }
        [Required]
        [Column("text")]
        [StringLength(25)]
        public string Text { get; set; }

        [InverseProperty(nameof(FmVehicle.StatusNavigation))]
        public virtual ICollection<FmVehicle> FmVehicles { get; set; }
    }
}
