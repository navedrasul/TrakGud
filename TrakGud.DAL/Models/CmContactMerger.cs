using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__ContactMerger")]
    [Index(nameof(MainContactId), Name = "fki_mainContactId")]
    [Index(nameof(MergedContactId), Name = "fki_mergedContactId_fkey")]
    public partial class CmContactMerger
    {
        [Key]
        [Column("mainContactId")]
        public int MainContactId { get; set; }
        [Key]
        [Column("mergedContactId")]
        public int MergedContactId { get; set; }
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
        [InverseProperty(nameof(UmUser.CmContactMergers))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(MainContactId))]
        [InverseProperty(nameof(CmContact.CmContactMergerMainContacts))]
        public virtual CmContact MainContact { get; set; }
        [ForeignKey(nameof(MergedContactId))]
        [InverseProperty(nameof(CmContact.CmContactMergerMergedContacts))]
        public virtual CmContact MergedContact { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmRole.CmContactMergers))]
        public virtual UmRole Modder { get; set; }
    }
}
