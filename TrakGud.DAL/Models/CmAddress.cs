using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__Address")]
    public partial class CmAddress
    {
        public CmAddress()
        {
            CmAddressContactFields = new HashSet<CmAddressContactField>();
            CmLocationInfos = new HashSet<CmLocationInfo>();
            FimBankBranches = new HashSet<FimBankBranch>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("line1")]
        [StringLength(100)]
        public string Line1 { get; set; }
        [Column("line2")]
        [StringLength(100)]
        public string Line2 { get; set; }
        [Column("cityId")]
        public int? CityId { get; set; }
        [Column("zip")]
        public int? Zip { get; set; }
        [Column("latitude")]
        public float? Latitude { get; set; }
        [Column("longitude")]
        public float? Longitude { get; set; }

        [ForeignKey(nameof(CityId))]
        [InverseProperty(nameof(CmCity.CmAddresses))]
        public virtual CmCity City { get; set; }
        [InverseProperty(nameof(CmAddressContactField.Address))]
        public virtual ICollection<CmAddressContactField> CmAddressContactFields { get; set; }
        [InverseProperty(nameof(CmLocationInfo.Address))]
        public virtual ICollection<CmLocationInfo> CmLocationInfos { get; set; }
        [InverseProperty(nameof(FimBankBranch.Address))]
        public virtual ICollection<FimBankBranch> FimBankBranches { get; set; }
    }
}
