using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class PersonalInfo
	{
		public int id { get; set; }
		public string firstName { get; set; }
		public string middleName { get; set; }
		public string lastName { get; set; }
		public string salutation { get; set; }
		public string moreInfo { get; set; }

		public PersonalInfo(int id_, string firstName_, string middleName_ = default, string lastName_ = default, string salutation_ = default, string moreInfo_ = default)		{
			this.id = id_;
			this.firstName = firstName_;
			this.middleName = middleName_;
			this.lastName = lastName_;
			this.salutation = salutation_;
			this.moreInfo = moreInfo_;
		}
	}
}