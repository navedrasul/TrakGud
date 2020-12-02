using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ShipmentManagement
{
	public class ShipmentLocationType
	{
		public string value { get; set; }
		public string text { get; set; }

		public ShipmentLocationType(string value_, string text_)		{
			this.value = value_;
			this.text = text_;
		}
	}
}