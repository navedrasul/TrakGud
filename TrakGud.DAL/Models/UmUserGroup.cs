using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("um__UserGroup")]
    public partial class UmUserGroup
    {
        public UmUserGroup()
        {
            GsApps = new HashSet<GsApp>();
            UmUserUserGroups = new HashSet<UmUserUserGroup>();
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
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }
        [Column("modderId")]
        public int? ModderId { get; set; }
        [Column("isRemoved")]
        public bool? IsRemoved { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.UmUserGroupAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.UmUserGroupModders))]
        public virtual UmUser Modder { get; set; }
        [InverseProperty(nameof(GsApp.UserGroup))]
        public virtual ICollection<GsApp> GsApps { get; set; }
        [InverseProperty(nameof(UmUserUserGroup.UserGroup))]
        public virtual ICollection<UmUserUserGroup> UmUserUserGroups { get; set; }
    }
}
