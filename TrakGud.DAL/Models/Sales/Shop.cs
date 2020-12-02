using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Sales
{
	public class Shop
	{
		public int id { get; set; }
		public string name { get; set; }
		public int? locationId { get; set; }
		public bool? isOnline { get; set; }

		public Shop(int id_, string name_, int? locationId_ = default, bool? isOnline_ = default)		{
			this.id = id_;
			this.name = name_;
			this.locationId = locationId_;
			this.isOnline = isOnline_;
		}
	}
}