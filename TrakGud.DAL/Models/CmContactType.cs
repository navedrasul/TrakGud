using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__ContactType")]
    public partial class CmContactType
    {
        public CmContactType()
        {
            CmCompanyInfos = new HashSet<CmCompanyInfo>();
            CmContacts = new HashSet<CmContact>();
            CmLocationInfos = new HashSet<CmLocationInfo>();
        }

        [Key]
        [Column("value")]
        [StringLength(25)]
        public string Value { get; set; }
        [Required]
        [Column("text")]
        [StringLength(25)]
        public string Text { get; set; }

        [InverseProperty(nameof(CmCompanyInfo.TypeNavigation))]
        public virtual ICollection<CmCompanyInfo> CmCompanyInfos { get; set; }
        [InverseProperty(nameof(CmContact.TypeNavigation))]
        public virtual ICollection<CmContact> CmContacts { get; set; }
        [InverseProperty(nameof(CmLocationInfo.TypeNavigation))]
        public virtual ICollection<CmLocationInfo> CmLocationInfos { get; set; }
    }
}
