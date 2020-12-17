using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__Continent")]
    public partial class CmContinent
    {
        public CmContinent()
        {
            CmCountryContinents = new HashSet<CmCountryContinent>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(25)]
        public string Name { get; set; }

        [InverseProperty(nameof(CmCountryContinent.Continent))]
        public virtual ICollection<CmCountryContinent> CmCountryContinents { get; set; }
    }
}
