using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
[Table("cm__PersonalInfo")]	public class PersonalInfo
	{
		public int id { get; set; }
		public string firstName { get; set; }
		public string middleName { get; set; }
		public string lastName { get; set; }
		public string salutation { get; set; }
		public string moreInfo { get; set; }

		public PersonalInfo() { }


		public PersonalInfo(int id, string firstName, string middleName = default, string lastName = default, string salutation = default, string moreInfo = default)		{
			this.id = id;
			this.firstName = firstName;
			this.middleName = middleName;
			this.lastName = lastName;
			this.salutation = salutation;
			this.moreInfo = moreInfo;
		}
	}
}