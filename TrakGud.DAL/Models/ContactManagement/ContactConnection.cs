using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class ContactConnection: ContactField
	{
		public int connectionId { get; set; }
		public string title { get; set; }

		public ContactConnection(int connectionId_, string title_, int id_, string fieldType_, int? contactId_ = default, string name_ = default): base(id_, fieldType_, contactId_, name_)
		{
			this.connectionId = connectionId_;
			this.title = title_;
		}
	}
}