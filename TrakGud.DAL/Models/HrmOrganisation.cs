using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("hrm__Organisation")]
    public partial class HrmOrganisation
    {
        public HrmOrganisation()
        {
            HrmEmployeeGroupOrganisations = new HashSet<HrmEmployeeGroupOrganisation>();
            HrmEmployeeOrganisations = new HashSet<HrmEmployeeOrganisation>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("desc")]
        [StringLength(250)]
        public string Desc { get; set; }
        [Column("parentOrgId")]
        public int? ParentOrgId { get; set; }
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
        [InverseProperty(nameof(UmUser.HrmOrganisationAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.HrmOrganisationModders))]
        public virtual UmUser Modder { get; set; }
        [InverseProperty(nameof(HrmEmployeeGroupOrganisation.Organisation))]
        public virtual ICollection<HrmEmployeeGroupOrganisation> HrmEmployeeGroupOrganisations { get; set; }
        [InverseProperty(nameof(HrmEmployeeOrganisation.Organisation))]
        public virtual ICollection<HrmEmployeeOrganisation> HrmEmployeeOrganisations { get; set; }
    }
}
