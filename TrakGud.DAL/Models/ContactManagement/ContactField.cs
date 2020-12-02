using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class ContactField
	{
		public int id { get; set; }
		public string fieldType { get; set; }
		public int? contactId { get; set; }
		public string name { get; set; }

		public ContactField(int id_, string fieldType_, int? contactId_ = default, string name_ = default)		{
			this.id = id_;
			this.fieldType = fieldType_;
			this.contactId = contactId_;
			this.name = name_;
		}
	}
}