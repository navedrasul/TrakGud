using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fm__VehicleCapacityUnitConvertion")]
    public partial class FmVehicleCapacityUnitConvertion
    {
        [Key]
        [Column("sourceUnitId")]
        public int SourceUnitId { get; set; }
        [Key]
        [Column("destinationUnitId")]
        public int DestinationUnitId { get; set; }
        [Column("multiplier")]
        public float Multiplier { get; set; }
        [Column("addTS", TypeName = "timestamp with time zone")]
        public DateTime AddTs { get; set; }
        [Column("adderId")]
        public int AdderId { get; set; }
        [Column("modderId")]
        public int? ModderId { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.FmVehicleCapacityUnitConvertionAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(DestinationUnitId))]
        [InverseProperty(nameof(FmVehicleCapacityUnit.FmVehicleCapacityUnitConvertionDestinationUnits))]
        public virtual FmVehicleCapacityUnit DestinationUnit { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.FmVehicleCapacityUnitConvertionModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(SourceUnitId))]
        [InverseProperty(nameof(FmVehicleCapacityUnit.FmVehicleCapacityUnitConvertionSourceUnits))]
        public virtual FmVehicleCapacityUnit SourceUnit { get; set; }
    }
}
