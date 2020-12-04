using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
[Table("cm__Email")]	public class Email: ContactField
	{
		public string email { get; set; }

		public Email() { }


		public Email(string email, int id, string fieldType, int? contactId = default, string name = default): base(id, fieldType, contactId, name)
		{
			this.email = email;
		}
	}
}