using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("s__ProductOffer")]
    public partial class SProductOffer
    {
        public SProductOffer()
        {
            SProductOfferItems = new HashSet<SProductOfferItem>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(150)]
        public string Name { get; set; }
        [Column("desc")]
        [StringLength(250)]
        public string Desc { get; set; }
        [Column("price")]
        public float Price { get; set; }
        [Column("addTS", TypeName = "timestamp with time zone")]
        public DateTime AddTs { get; set; }
        [Column("adderId")]
        public int AdderId { get; set; }
        [Column("modderId")]
        public int? ModderId { get; set; }
        [Column("isRemoved")]
        public bool? IsRemoved { get; set; }
        [Column("validFromTS", TypeName = "timestamp with time zone")]
        public DateTime? ValidFromTs { get; set; }
        [Column("validToTS", TypeName = "timestamp with time zone")]
        public DateTime? ValidToTs { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.SProductOfferAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.SProductOfferModders))]
        public virtual UmUser Modder { get; set; }
        [InverseProperty(nameof(SProductOfferItem.ProductOffer))]
        public virtual ICollection<SProductOfferItem> SProductOfferItems { get; set; }
    }
}
