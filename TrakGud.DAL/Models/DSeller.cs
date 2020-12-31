using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__Seller")]
    [Index(nameof(SellerType), Name = "fki_sellerType_fkey")]
    public partial class DSeller
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(150)]
        public string Name { get; set; }
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
        [Required]
        [Column("sellerType")]
        [StringLength(25)]
        public string SellerType { get; set; }
    }
}
