using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__City")]
    [Index(nameof(StateProvinceId), Name = "fki_stateProvinceId_fkey")]
    public partial class CmCity
    {
        public CmCity()
        {
            CmAddresses = new HashSet<CmAddress>();
            CmFaxes = new HashSet<CmFax>();
            CmPhones = new HashSet<CmPhone>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(25)]
        public string Name { get; set; }
        [Column("stateProvinceId")]
        public int StateProvinceId { get; set; }
        [Column("dialingCode")]
        public int DialingCode { get; set; }

        [ForeignKey(nameof(StateProvinceId))]
        [InverseProperty(nameof(CmStateProvince.CmCities))]
        public virtual CmStateProvince StateProvince { get; set; }
        [InverseProperty(nameof(CmAddress.City))]
        public virtual ICollection<CmAddress> CmAddresses { get; set; }
        [InverseProperty(nameof(CmFax.City))]
        public virtual ICollection<CmFax> CmFaxes { get; set; }
        [InverseProperty(nameof(CmPhone.City))]
        public virtual ICollection<CmPhone> CmPhones { get; set; }
    }
}
