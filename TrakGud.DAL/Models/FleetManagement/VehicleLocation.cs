using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FleetManagement
{
[Table("fm__VehicleLocation")]	public class VehicleLocation
	{
		public int id { get; set; }
		public float? latitude { get; set; }
		public float? longitude { get; set; }

		public VehicleLocation() { }


		public VehicleLocation(int id, float? latitude = default, float? longitude = default)		{
			this.id = id;
			this.latitude = latitude;
			this.longitude = longitude;
		}
	}
}