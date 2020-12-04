using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FleetManagement
{
[Table("fm__VehicleStatus")]	public class VehicleStatus
	{
		public string value { get; set; }
		public string text { get; set; }

		public VehicleStatus() { }


		public VehicleStatus(string value, string text)		{
			this.value = value;
			this.text = text;
		}
	}
}