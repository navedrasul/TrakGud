using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__Contact")]
    [Index(nameof(Type), Name = "fki_type_fkey")]
    public partial class CmContact
    {
        public CmContact()
        {
            CmContactFields = new HashSet<CmContactField>();
            CmContactMergerMainContacts = new HashSet<CmContactMerger>();
            CmContactMergerMergedContacts = new HashSet<CmContactMerger>();
            CmEmails = new HashSet<CmEmail>();
            CmFaxes = new HashSet<CmFax>();
            CmPhones = new HashSet<CmPhone>();
            DBuyers = new HashSet<DBuyer>();
            DSellers = new HashSet<DSeller>();
            FimBankBranchPocs = new HashSet<FimBankBranchPoc>();
            FimCheques = new HashSet<FimCheque>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("isMerged")]
        public bool? IsMerged { get; set; }
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
        [Required]
        [Column("type")]
        [StringLength(25)]
        public string Type { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.CmContactAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.CmContactModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(Type))]
        [InverseProperty(nameof(CmContactType.CmContacts))]
        public virtual CmContactType TypeNavigation { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual CmNote CmNote { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual CmPersonalInfo CmPersonalInfo { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual CmProfessionalInfo CmProfessionalInfo { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual FmVehicle FmVehicle { get; set; }
        [InverseProperty(nameof(CmContactField.Contact))]
        public virtual ICollection<CmContactField> CmContactFields { get; set; }
        [InverseProperty(nameof(CmContactMerger.MainContact))]
        public virtual ICollection<CmContactMerger> CmContactMergerMainContacts { get; set; }
        [InverseProperty(nameof(CmContactMerger.MergedContact))]
        public virtual ICollection<CmContactMerger> CmContactMergerMergedContacts { get; set; }
        [InverseProperty(nameof(CmEmail.Contact))]
        public virtual ICollection<CmEmail> CmEmails { get; set; }
        [InverseProperty(nameof(CmFax.Contact))]
        public virtual ICollection<CmFax> CmFaxes { get; set; }
        [InverseProperty(nameof(CmPhone.Contact))]
        public virtual ICollection<CmPhone> CmPhones { get; set; }
        [InverseProperty(nameof(DBuyer.Contact))]
        public virtual ICollection<DBuyer> DBuyers { get; set; }
        [InverseProperty(nameof(DSeller.Contact))]
        public virtual ICollection<DSeller> DSellers { get; set; }
        [InverseProperty(nameof(FimBankBranchPoc.Contact))]
        public virtual ICollection<FimBankBranchPoc> FimBankBranchPocs { get; set; }
        [InverseProperty(nameof(FimCheque.IssuerContact))]
        public virtual ICollection<FimCheque> FimCheques { get; set; }
    }
}
