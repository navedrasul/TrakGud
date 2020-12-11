using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__ProfessionalInfo")]
    [Index(nameof(CompanyInfoId), Name = "fki_companyInfoId_fkey")]
    public partial class CmProfessionalInfo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("designation")]
        [StringLength(50)]
        public string Designation { get; set; }
        [Column("department")]
        [StringLength(50)]
        public string Department { get; set; }
        [Column("moreInfo")]
        public string MoreInfo { get; set; }
        [Column("companyInfoId")]
        public int? CompanyInfoId { get; set; }

        [ForeignKey(nameof(CompanyInfoId))]
        [InverseProperty(nameof(CmCompanyInfo.CmProfessionalInfos))]
        public virtual CmCompanyInfo CompanyInfo { get; set; }
        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(CmContact.CmProfessionalInfo))]
        public virtual CmContact IdNavigation { get; set; }
    }
}
