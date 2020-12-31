using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("um__User")]
    public partial class UmUser
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("username")]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [Column("passwordHash")]
        [StringLength(128)]
        public string PasswordHash { get; set; }
        [Column("isDisabled")]
        public bool? IsDisabled { get; set; }
        [Column("fullName")]
        [StringLength(150)]
        public string FullName { get; set; }
        [Column("employeeId")]
        public int? EmployeeId { get; set; }
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
    }
}
