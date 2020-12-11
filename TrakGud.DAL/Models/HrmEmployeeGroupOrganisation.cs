using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("hrm__EmployeeGroup_Organisation")]
    [Index(nameof(EmployeeGroupId), Name = "fki_employeeGroupId_fkey")]
    [Index(nameof(OrganisationId), Name = "fki_organisationId_fkey")]
    public partial class HrmEmployeeGroupOrganisation
    {
        [Key]
        [Column("employeeGroupId")]
        public int EmployeeGroupId { get; set; }
        [Key]
        [Column("organisationId")]
        public int OrganisationId { get; set; }

        [ForeignKey(nameof(EmployeeGroupId))]
        [InverseProperty(nameof(HrmEmployeeGroup.HrmEmployeeGroupOrganisations))]
        public virtual HrmEmployeeGroup EmployeeGroup { get; set; }
        [ForeignKey(nameof(OrganisationId))]
        [InverseProperty(nameof(HrmOrganisation.HrmEmployeeGroupOrganisations))]
        public virtual HrmOrganisation Organisation { get; set; }
    }
}
