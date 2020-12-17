using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__CompanyInfo")]
    public partial class CmCompanyInfo
    {
        public CmCompanyInfo()
        {
            CmProfessionalInfos = new HashSet<CmProfessionalInfo>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("isMerged")]
        public bool? IsMerged { get; set; }
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
        [Required]
        [Column("type")]
        [StringLength(25)]
        public string Type { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.CmCompanyInfoAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.CmCompanyInfoModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(Type))]
        [InverseProperty(nameof(CmContactType.CmCompanyInfos))]
        public virtual CmContactType TypeNavigation { get; set; }
        [InverseProperty(nameof(CmProfessionalInfo.CompanyInfo))]
        public virtual ICollection<CmProfessionalInfo> CmProfessionalInfos { get; set; }
    }
}
