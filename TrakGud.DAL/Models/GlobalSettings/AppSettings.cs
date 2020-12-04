using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.GlobalSettings
{
[Table("gs__AppSettings")]	public class AppSettings
	{
		public int? defaultCurrencyId { get; set; }
		public string companyName { get; set; }

		public AppSettings() { }


		public AppSettings(int? defaultCurrencyId = default, string companyName = default)		{
			this.defaultCurrencyId = defaultCurrencyId;
			this.companyName = companyName;
		}
	}
}