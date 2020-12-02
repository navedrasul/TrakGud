using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class Email: ContactField
	{
		public string email { get; set; }

		public Email(string email_, int id_, string fieldType_, int? contactId_ = default, string name_ = default): base(id_, fieldType_, contactId_, name_)
		{
			this.email = email_;
		}
	}
}