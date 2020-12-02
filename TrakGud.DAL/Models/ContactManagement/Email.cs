using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class Email: ContactField
	{
		public string email { get; set; }

		public Email(int id_, string fieldType_, int? contactId_ = default, string name_ = default, string email_): base(id_, fieldType_, contactId_, name_)
		{
			this.email = email_;
		}
	}
}