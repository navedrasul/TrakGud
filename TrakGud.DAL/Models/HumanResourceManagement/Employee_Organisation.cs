using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.HumanResourceManagement
{
	public class Employee_Organisation
	{
		public int employeeId { get; set; }
		public int organisationId { get; set; }
		public string designationAtOrg { get; set; }
		public string designationDesc { get; set; }

		public Employee_Organisation(int employeeId_, int organisationId_, string designationAtOrg_ = default, string designationDesc_ = default)		{
			this.employeeId = employeeId_;
			this.organisationId = organisationId_;
			this.designationAtOrg = designationAtOrg_;
			this.designationDesc = designationDesc_;
		}
	}
}