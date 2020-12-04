using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.UserManagement
{
[Table("um__Right_RightsSection")]	public class Right_RightsSection
	{
		public int rightId { get; set; }
		public int rightsSectionId { get; set; }

		public Right_RightsSection() { }


		public Right_RightsSection(int rightId, int rightsSectionId)		{
			this.rightId = rightId;
			this.rightsSectionId = rightsSectionId;
		}
	}
}