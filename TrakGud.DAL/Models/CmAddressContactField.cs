using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__Address_ContactField")]
    [Index(nameof(AddressId), Name = "fki_addressId_fkey")]
    [Index(nameof(ContactFieldId), Name = "fki_contactFieldId_fkey")]
    public partial class CmAddressContactField
    {
        [Key]
        [Column("addressId")]
        public int AddressId { get; set; }
        [Key]
        [Column("contactFieldId")]
        public int ContactFieldId { get; set; }
    }
}
