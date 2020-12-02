using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.UserManagement
{
	public class RightsSection
	{
		public int id { get; set; }
		public string title { get; set; }
		public int? parentSectionId { get; set; }

		public RightsSection(int id_, string title_, int? parentSectionId_ = default)		{
			this.id = id_;
			this.title = title_;
			this.parentSectionId = parentSectionId_;
		}
	}
}