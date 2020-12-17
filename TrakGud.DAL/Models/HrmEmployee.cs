using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("hrm__Employee")]
    public partial class HrmEmployee
    {
        public HrmEmployee()
        {
            HrmEmployeeEmployeeGroups = new HashSet<HrmEmployeeEmployeeGroup>();
            HrmEmployeeOrganisations = new HashSet<HrmEmployeeOrganisation>();
            InverseContact = new HashSet<HrmEmployee>();
            SShopEmployees = new HashSet<SShopEmployee>();
            UmUsers = new HashSet<UmUser>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("contactId")]
        public int ContactId { get; set; }
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
        [InverseProperty(nameof(UmUser.HrmEmployeeAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ContactId))]
        [InverseProperty(nameof(HrmEmployee.InverseContact))]
        public virtual HrmEmployee Contact { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.HrmEmployeeModders))]
        public virtual UmUser Modder { get; set; }
        [InverseProperty(nameof(HrmEmployeeEmployeeGroup.Employee))]
        public virtual ICollection<HrmEmployeeEmployeeGroup> HrmEmployeeEmployeeGroups { get; set; }
        [InverseProperty(nameof(HrmEmployeeOrganisation.Employee))]
        public virtual ICollection<HrmEmployeeOrganisation> HrmEmployeeOrganisations { get; set; }
        [InverseProperty(nameof(HrmEmployee.Contact))]
        public virtual ICollection<HrmEmployee> InverseContact { get; set; }
        [InverseProperty(nameof(SShopEmployee.Employee))]
        public virtual ICollection<SShopEmployee> SShopEmployees { get; set; }
        [InverseProperty(nameof(UmUser.Employee))]
        public virtual ICollection<UmUser> UmUsers { get; set; }
    }
}
