using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("um__Role")]
    public partial class UmRole
    {
        public UmRole()
        {
            CmContactMergers = new HashSet<CmContactMerger>();
            UmRoleRights = new HashSet<UmRoleRight>();
            UmUserRoles = new HashSet<UmUserRole>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("title")]
        [StringLength(50)]
        public string Title { get; set; }
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

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.UmRoleAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.UmRoleModders))]
        public virtual UmUser Modder { get; set; }
        [InverseProperty(nameof(CmContactMerger.Modder))]
        public virtual ICollection<CmContactMerger> CmContactMergers { get; set; }
        [InverseProperty(nameof(UmRoleRight.Role))]
        public virtual ICollection<UmRoleRight> UmRoleRights { get; set; }
        [InverseProperty(nameof(UmUserRole.Role))]
        public virtual ICollection<UmUserRole> UmUserRoles { get; set; }
    }
}
