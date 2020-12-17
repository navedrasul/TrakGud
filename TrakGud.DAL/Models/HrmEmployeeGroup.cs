using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("hrm__EmployeeGroup")]
    public partial class HrmEmployeeGroup
    {
        public HrmEmployeeGroup()
        {
            HrmEmployeeEmployeeGroups = new HashSet<HrmEmployeeEmployeeGroup>();
            HrmEmployeeGroupOrganisations = new HashSet<HrmEmployeeGroupOrganisation>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("desc")]
        [StringLength(150)]
        public string Desc { get; set; }
        [Column("parentGroupId")]
        public int? ParentGroupId { get; set; }
        [Column("addTS", TypeName = "timestamp with time zone")]
        public DateTime AddTs { get; set; }
        [Column("adderId")]
        public int AdderId { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }
        [Column("modderId")]
        public int? ModderId { get; set; }
        [Column("isRemoved")]
        public bool? IsRemoved { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.HrmEmployeeGroupAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.HrmEmployeeGroupModders))]
        public virtual UmUser Modder { get; set; }
        [InverseProperty(nameof(HrmEmployeeEmployeeGroup.EmployeeGroup))]
        public virtual ICollection<HrmEmployeeEmployeeGroup> HrmEmployeeEmployeeGroups { get; set; }
        [InverseProperty(nameof(HrmEmployeeGroupOrganisation.EmployeeGroup))]
        public virtual ICollection<HrmEmployeeGroupOrganisation> HrmEmployeeGroupOrganisations { get; set; }
    }
}
