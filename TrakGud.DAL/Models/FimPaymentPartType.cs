using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fim__PaymentPartType")]
    public partial class FimPaymentPartType
    {
        public FimPaymentPartType()
        {
            FimPaymentParts = new HashSet<FimPaymentPart>();
        }

        [Key]
        [Column("value")]
        [StringLength(25)]
        public string Value { get; set; }
        [Required]
        [Column("text")]
        [StringLength(25)]
        public string Text { get; set; }

        [InverseProperty(nameof(FimPaymentPart.PaymentPartTypeNavigation))]
        public virtual ICollection<FimPaymentPart> FimPaymentParts { get; set; }
    }
}
