using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__Bank")]	public class Bank
	{
		public int id { get; set; }
		public string name { get; set; }
		public string desc { get; set; }

		public Bank() { }


		public Bank(int id, string name, string desc = default)		{
			this.id = id;
			this.name = name;
			this.desc = desc;
		}
	}
}