using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
[Table("cm__CompanyInfo")]	public class CompanyInfo
	{
		public int id { get; set; }
		public string name { get; set; }

		public CompanyInfo() { }


		public CompanyInfo(int id, string name)		{
			this.id = id;
			this.name = name;
		}
	}
}