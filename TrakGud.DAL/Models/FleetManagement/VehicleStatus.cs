using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FleetManagement
{
	public class VehicleStatus
	{
		public string value { get; set; }
		public string text { get; set; }

		public VehicleStatus(string value_, string text_)		{
			this.value = value_;
			this.text = text_;
		}
	}
}