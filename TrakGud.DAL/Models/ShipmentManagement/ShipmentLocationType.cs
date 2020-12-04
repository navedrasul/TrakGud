using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ShipmentManagement
{
[Table("sm__ShipmentLocationType")]	public class ShipmentLocationType
	{
		public string value { get; set; }
		public string text { get; set; }

		public ShipmentLocationType() { }


		public ShipmentLocationType(string value, string text)		{
			this.value = value;
			this.text = text;
		}
	}
}