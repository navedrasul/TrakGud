using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.HumanResourceManagement
{
	public class EmployeeGroup_Organisation
	{
		public int employeeGroupId { get; set; }
		public int organisationId { get; set; }

		public EmployeeGroup_Organisation(int employeeGroupId_, int organisationId_)		{
			this.employeeGroupId = employeeGroupId_;
			this.organisationId = organisationId_;
		}
	}
}