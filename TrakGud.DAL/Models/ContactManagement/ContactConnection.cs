using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
[Table("cm__ContactConnection")]	public class ContactConnection: ContactField
	{
		public int connectionId { get; set; }
		public string title { get; set; }

		public ContactConnection() { }


		public ContactConnection(int connectionId, string title, int id, string fieldType, int? contactId = default, string name = default): base(id, fieldType, contactId, name)
		{
			this.connectionId = connectionId;
			this.title = title;
		}
	}
}