using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FleetManagement
{
	public class VehicleCapacityUnitType
	{
		public string value { get; set; }
		public string text { get; set; }

		public VehicleCapacityUnitType(string value_, string text_)		{
			this.value = value_;
			this.text = text_;
		}
	}
}