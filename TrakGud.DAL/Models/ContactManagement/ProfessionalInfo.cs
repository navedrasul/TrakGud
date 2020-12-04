using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
[Table("cm__ProfessionalInfo")]	public class ProfessionalInfo
	{
		public int id { get; set; }
		public string designation { get; set; }
		public string department { get; set; }
		public string moreInfo { get; set; }
		public int? companyInfoId { get; set; }

		public ProfessionalInfo() { }


		public ProfessionalInfo(int id, string designation = default, string department = default, string moreInfo = default, int? companyInfoId = default)		{
			this.id = id;
			this.designation = designation;
			this.department = department;
			this.moreInfo = moreInfo;
			this.companyInfoId = companyInfoId;
		}
	}
}