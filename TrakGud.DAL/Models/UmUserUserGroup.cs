using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("um__User_UserGroup")]
    public partial class UmUserUserGroup
    {
        [Key]
        [Column("userId")]
        public int UserId { get; set; }
        [Key]
        [Column("userGroupId")]
        public int UserGroupId { get; set; }
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
        [InverseProperty(nameof(UmUser.UmUserUserGroupAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.UmUserUserGroupModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(UmUser.UmUserUserGroupUsers))]
        public virtual UmUser User { get; set; }
        [ForeignKey(nameof(UserGroupId))]
        [InverseProperty(nameof(UmUserGroup.UmUserUserGroups))]
        public virtual UmUserGroup UserGroup { get; set; }
    }
}
