using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("hrm__Employee_EmployeeGroup")]
    [Index(nameof(EmployeeId), Name = "fki_employeeId_fkey")]
    public partial class HrmEmployeeEmployeeGroup
    {
        [Key]
        [Column("employeeId")]
        public int EmployeeId { get; set; }
        [Key]
        [Column("employeeGroupId")]
        public int EmployeeGroupId { get; set; }
        [Column("designationAtGroup")]
        [StringLength(50)]
        public string DesignationAtGroup { get; set; }
        [Column("designationDesc")]
        [StringLength(150)]
        public string DesignationDesc { get; set; }
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
        [InverseProperty(nameof(UmUser.HrmEmployeeEmployeeGroupAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty(nameof(HrmEmployee.HrmEmployeeEmployeeGroups))]
        public virtual HrmEmployee Employee { get; set; }
        [ForeignKey(nameof(EmployeeGroupId))]
        [InverseProperty(nameof(HrmEmployeeGroup.HrmEmployeeEmployeeGroups))]
        public virtual HrmEmployeeGroup EmployeeGroup { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.HrmEmployeeEmployeeGroupModders))]
        public virtual UmUser Modder { get; set; }
    }
}
