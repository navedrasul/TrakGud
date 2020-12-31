using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__Buyer")]
    [Index(nameof(Rct), Name = "fki_RCT_fkey")]
    [Index(nameof(Rst), Name = "fki_RST_fkey")]
    [Index(nameof(BuyerType), Name = "fki_buyerType_fkey")]
    [Index(nameof(CommentsThreadId), Name = "fki_commentsThreadId_fkey")]
    public partial class DBuyer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        [Column("buyerType")]
        [StringLength(25)]
        public string BuyerType { get; set; }
        [Column("commentsThreadId")]
        public int? CommentsThreadId { get; set; }
        [Column("contactId")]
        public int? ContactId { get; set; }
        [Column("addTS", TypeName = "timestamp with time zone")]
        public DateTime AddTs { get; set; }
        [Column("adderId")]
        public int AdderId { get; set; }
        [Column("modderId")]
        public int? ModderId { get; set; }
        [Column("RCT")]
        [StringLength(25)]
        public string Rct { get; set; }
        [Column("RST")]
        [StringLength(25)]
        public string Rst { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }
    }
}
