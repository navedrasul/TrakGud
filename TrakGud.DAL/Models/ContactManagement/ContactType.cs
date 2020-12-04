using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
[Table("cm__ContactType")]	public class ContactType
	{
		public string value { get; set; }
		public string text { get; set; }

		public ContactType() { }


		public ContactType(string value, string text)		{
			this.value = value;
			this.text = text;
		}
	}
}