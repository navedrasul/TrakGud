using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.UserManagement
{
[Table("um__RightsSection")]	public class RightsSection
	{
		public int id { get; set; }
		public string title { get; set; }
		public int? parentSectionId { get; set; }

		public RightsSection() { }


		public RightsSection(int id, string title, int? parentSectionId = default)		{
			this.id = id;
			this.title = title;
			this.parentSectionId = parentSectionId;
		}
	}
}