using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("s__ShopEmployee")]
    public partial class SShopEmployee
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("designation")]
        [StringLength(50)]
        public string Designation { get; set; }
        [Column("employeeId")]
        public int EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty(nameof(HrmEmployee.SShopEmployees))]
        public virtual HrmEmployee Employee { get; set; }
    }
}
