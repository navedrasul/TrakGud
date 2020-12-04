using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Sales
{
[Table("s__Shop")]	public class Shop
	{
		public int id { get; set; }
		public string name { get; set; }
		public int? locationId { get; set; }
		public bool? isOnline { get; set; }

		public Shop() { }


		public Shop(int id, string name, int? locationId = default, bool? isOnline = default)		{
			this.id = id;
			this.name = name;
			this.locationId = locationId;
			this.isOnline = isOnline;
		}
	}
}