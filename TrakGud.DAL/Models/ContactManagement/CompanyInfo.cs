using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class CompanyInfo
	{
		public int id { get; set; }
		public string name { get; set; }

		public CompanyInfo(int id_, string name_)		{
			this.id = id_;
			this.name = name_;
		}
	}
}