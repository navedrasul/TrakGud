using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class Phone: ContactField
	{
		public int cityId { get; set; }
		public string phone { get; set; }

		public Phone(int cityId_, int id_, string fieldType_, string phone_ = default, int? contactId_ = default, string name_ = default): base(id_, fieldType_, contactId_, name_)
		{
			this.cityId = cityId_;
			this.phone = phone_;
		}
	}
}