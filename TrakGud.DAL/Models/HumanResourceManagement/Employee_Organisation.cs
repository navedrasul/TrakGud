using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.HumanResourceManagement
{
[Table("hrm__Employee_Organisation")]	public class Employee_Organisation
	{
		public int employeeId { get; set; }
		public int organisationId { get; set; }
		public string designationAtOrg { get; set; }
		public string designationDesc { get; set; }

		public Employee_Organisation() { }


		public Employee_Organisation(int employeeId, int organisationId, string designationAtOrg = default, string designationDesc = default)		{
			this.employeeId = employeeId;
			this.organisationId = organisationId;
			this.designationAtOrg = designationAtOrg;
			this.designationDesc = designationDesc;
		}
	}
}