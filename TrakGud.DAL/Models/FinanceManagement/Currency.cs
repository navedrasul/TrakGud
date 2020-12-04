using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__Currency")]	public class Currency
	{
		public string value { get; set; }
		public string text { get; set; }

		public Currency() { }


		public Currency(string value, string text)		{
			this.value = value;
			this.text = text;
		}
	}
}