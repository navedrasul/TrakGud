using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("s__ProductOfferItem")]
    [Index(nameof(ProductOfferId), Name = "fki_productOfferId_fkey")]
    public partial class SProductOfferItem
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("productId")]
        public int ProductId { get; set; }
        [Column("productOfferId")]
        public int ProductOfferId { get; set; }
        [Column("qty")]
        public float Qty { get; set; }
        [Column("maxQty")]
        public float? MaxQty { get; set; }
        [Column("unitId")]
        public int UnitId { get; set; }
    }
}
