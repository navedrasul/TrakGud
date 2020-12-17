using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__PersonalInfo")]
    public partial class CmPersonalInfo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("firstName")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column("middleName")]
        [StringLength(50)]
        public string MiddleName { get; set; }
        [Column("lastName")]
        [StringLength(25)]
        public string LastName { get; set; }
        [Column("salutation")]
        [StringLength(15)]
        public string Salutation { get; set; }
        [Column("moreInfo")]
        public string MoreInfo { get; set; }

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(CmContact.CmPersonalInfo))]
        public virtual CmContact IdNavigation { get; set; }
    }
}
