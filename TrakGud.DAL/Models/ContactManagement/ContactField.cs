using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
[Table("cm__ContactField")]	public class ContactField
	{
		public int id { get; set; }
		public string fieldType { get; set; }
		public int? contactId { get; set; }
		public string name { get; set; }

		public ContactField() { }


		public ContactField(int id, string fieldType, int? contactId = default, string name = default)		{
			this.id = id;
			this.fieldType = fieldType;
			this.contactId = contactId;
			this.name = name;
		}
	}
}