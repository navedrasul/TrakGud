using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
	public class Bank
	{
		public int id { get; set; }
		public string name { get; set; }
		public string desc { get; set; }

		public Bank(int id_, string name_, string desc_ = default)		{
			this.id = id_;
			this.name = name_;
			this.desc = desc_;
		}
	}
}