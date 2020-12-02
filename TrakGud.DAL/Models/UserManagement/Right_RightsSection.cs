using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.UserManagement
{
	public class Right_RightsSection
	{
		public int rightId { get; set; }
		public int rightsSectionId { get; set; }

		public Right_RightsSection(int rightId_, int rightsSectionId_)		{
			this.rightId = rightId_;
			this.rightsSectionId = rightsSectionId_;
		}
	}
}