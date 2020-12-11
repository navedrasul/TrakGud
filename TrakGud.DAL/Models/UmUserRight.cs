using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("um__User_Right")]
    [Index(nameof(UserId), Name = "fki_userId_fkey")]
    public partial class UmUserRight
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("title")]
        [StringLength(150)]
        public string Title { get; set; }
        [Column("desc")]
        public string Desc { get; set; }
        [Column("isActive")]
        public bool IsActive { get; set; }
        [Column("addTS", TypeName = "timestamp with time zone")]
        public DateTime AddTs { get; set; }
        [Column("adderId")]
        public int AdderId { get; set; }
        [Column("modderId")]
        public int? ModderId { get; set; }
        [Column("isRemoved")]
        public bool? IsRemoved { get; set; }
        [Column("userId")]
        public int UserId { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.UmUserRightAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.UmUserRightModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(UmUser.UmUserRightUsers))]
        public virtual UmUser User { get; set; }
    }
}
