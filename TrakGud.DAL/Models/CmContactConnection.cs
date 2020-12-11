using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Keyless]
    [Table("cm__ContactConnection")]
    public partial class CmContactConnection
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("fieldType")]
        [StringLength(25)]
        public string FieldType { get; set; }
        [Column("contactId")]
        public int? ContactId { get; set; }
        [Column("name")]
        [StringLength(25)]
        public string Name { get; set; }
        [Column("connectionId")]
        public int ConnectionId { get; set; }
        [Required]
        [Column("title")]
        [StringLength(25)]
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
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ConnectionId))]
        public virtual CmContact Connection { get; set; }
        [ForeignKey(nameof(FieldType))]
        public virtual CmContactFieldType FieldTypeNavigation { get; set; }
        [ForeignKey(nameof(Id))]
        public virtual CmContactField IdNavigation { get; set; }
        [ForeignKey(nameof(ModderId))]
        public virtual UmUser Modder { get; set; }
    }
}
