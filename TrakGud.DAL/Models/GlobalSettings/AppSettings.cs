using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.GlobalSettings
{
	public class AppSettings
	{
		public int? defaultCurrencyId { get; set; }
		public string companyName { get; set; }

		public AppSettings(int? defaultCurrencyId_ = default, string companyName_ = default)		{
			this.defaultCurrencyId = defaultCurrencyId_;
			this.companyName = companyName_;
		}
	}
}