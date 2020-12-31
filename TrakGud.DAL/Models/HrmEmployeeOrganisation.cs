using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("hrm__Employee_Organisation")]
    public partial class HrmEmployeeOrganisation
    {
        [Key]
        [Column("employeeId")]
        public int EmployeeId { get; set; }
        [Key]
        [Column("organisationId")]
        public int OrganisationId { get; set; }
        [Column("designationAtOrg")]
        [StringLength(50)]
        public string DesignationAtOrg { get; set; }
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
    }
}
