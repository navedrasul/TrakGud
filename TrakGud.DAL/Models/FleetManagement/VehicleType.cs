using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FleetManagement
{
[Table("fm__VehicleType")]	public class VehicleType
	{
		public string value { get; set; }
		public string text { get; set; }

		public VehicleType() { }


		public VehicleType(string value, string text)		{
			this.value = value;
			this.text = text;
		}
	}
}