using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
[Table("cm__Phone")]	public class Phone: ContactField
	{
		public int cityId { get; set; }
		public string phone { get; set; }

		public Phone() { }


		public Phone(int cityId, int id, string fieldType, string phone = default, int? contactId = default, string name = default): base(id, fieldType, contactId, name)
		{
			this.cityId = cityId;
			this.phone = phone;
		}
	}
}