using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class Phone: ContactField
	{
		public int cityId { get; set; }
		public string phone { get; set; }

		public Phone(int id_, string fieldType_, int? contactId_ = default, string name_ = default, int cityId_, string phone_ = default): base(id_, fieldType_, contactId_, name_)
		{
			this.cityId = cityId_;
			this.phone = phone_;
		}
	}
}