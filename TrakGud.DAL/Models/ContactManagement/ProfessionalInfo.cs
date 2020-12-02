using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class ProfessionalInfo
	{
		public int id { get; set; }
		public string designation { get; set; }
		public string department { get; set; }
		public string moreInfo { get; set; }
		public int? companyInfoId { get; set; }

		public ProfessionalInfo(int id_, string designation_ = default, string department_ = default, string moreInfo_ = default, int? companyInfoId_ = default)		{
			this.id = id_;
			this.designation = designation_;
			this.department = department_;
			this.moreInfo = moreInfo_;
			this.companyInfoId = companyInfoId_;
		}
	}
}