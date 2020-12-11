using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__Fax")]
    [Index(nameof(CityId), Name = "fki_cityId_fkey")]
    public partial class CmFax
    {
        [Key]
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
        [Column("cityId")]
        public int CityId { get; set; }
        [Required]
        [Column("fax")]
        [StringLength(25)]
        public string Fax { get; set; }
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
        [InverseProperty(nameof(UmUser.CmFaxAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(CityId))]
        [InverseProperty(nameof(CmCity.CmFaxes))]
        public virtual CmCity City { get; set; }
        [ForeignKey(nameof(ContactId))]
        [InverseProperty(nameof(CmContact.CmFaxes))]
        public virtual CmContact Contact { get; set; }
        [ForeignKey(nameof(FieldType))]
        [InverseProperty(nameof(CmContactFieldType.CmFaxes))]
        public virtual CmContactFieldType FieldTypeNavigation { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.CmFaxModders))]
        public virtual UmUser Modder { get; set; }
    }
}
