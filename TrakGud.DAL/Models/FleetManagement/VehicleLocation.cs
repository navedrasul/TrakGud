using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FleetManagement
{
	public class VehicleLocation
	{
		public int id { get; set; }
		public float? latitude { get; set; }
		public float? longitude { get; set; }

		public VehicleLocation(int id_, float? latitude_ = default, float? longitude_ = default)		{
			this.id = id_;
			this.latitude = latitude_;
			this.longitude = longitude_;
		}
	}
}